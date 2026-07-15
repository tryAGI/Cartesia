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
openapi_url=$(fetch_spec "$stats_url" | sed -n 's/^openapi_spec_url:[[:space:]]*//p' | sed -n '1p')

if [ -n "$openapi_url" ]; then
  echo "Spec URL: $openapi_url"
  fetch_spec "$openapi_url" -o openapi.yaml
elif [ -f openapi.yaml ]; then
  echo "WARNING: .stats.yml does not expose openapi_spec_url; using the checked-in spec."
else
  echo "ERROR: .stats.yml does not expose openapi_spec_url and no checked-in spec exists."
  exit 1
fi

install_autosdk_cli
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Cartesia \
  --clientClassName CartesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
