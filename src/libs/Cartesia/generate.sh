#!/usr/bin/env bash
set -euo pipefail

# Cartesia spec is hosted on Stainless GCS with hash-based URLs that change each update.
# We dynamically resolve the latest URL from cartesia-ai/cartesia-python/.stats.yml.
readonly stats_url="https://raw.githubusercontent.com/cartesia-ai/cartesia-python/main/.stats.yml"

echo "Fetching latest spec URL from .stats.yml..."
openapi_url=$(curl --fail --silent --show-error --location "$stats_url" | grep 'openapi_spec_url:' | sed 's/openapi_spec_url: *//')

if [ -z "$openapi_url" ]; then
  echo "ERROR: Could not extract openapi_spec_url from .stats.yml"
  exit 1
fi

echo "Spec URL: $openapi_url"

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace Cartesia \
  --clientClassName CartesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
