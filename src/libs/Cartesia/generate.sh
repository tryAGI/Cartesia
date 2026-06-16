#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: resolved from cartesia-ai/cartesia-python/.stats.yml (Stainless-hosted)

# Cartesia spec is hosted on Stainless GCS with hash-based URLs that change each update.
# We dynamically resolve the latest URL from cartesia-ai/cartesia-python/.stats.yml.
readonly stats_url="https://raw.githubusercontent.com/cartesia-ai/cartesia-python/main/.stats.yml"

echo "Fetching latest spec URL from .stats.yml..."
openapi_url=$(fetch_spec --fail --silent --show-error --location "$stats_url" | grep 'openapi_spec_url:' | sed 's/openapi_spec_url: *//')

if [ -z "$openapi_url" ]; then
  echo "ERROR: Could not extract openapi_spec_url from .stats.yml"
  exit 1
fi

echo "Spec URL: $openapi_url"
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace Cartesia \
  --clientClassName CartesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
