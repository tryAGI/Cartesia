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

# Cartesia historically exposed a Stainless-hosted aggregate spec through
# cartesia-python/.stats.yml. Newer releases only expose an endpoint count there,
# while the public docs still expose one complete OpenAPI fragment per endpoint.
readonly stats_url="https://raw.githubusercontent.com/cartesia-ai/cartesia-python/main/.stats.yml"

echo "Fetching latest spec URL from .stats.yml..."
openapi_url=$(fetch_spec "$stats_url" | sed -n 's/^openapi_spec_url:[[:space:]]*//p' | sed -n '1p')

if [ -n "$openapi_url" ]; then
  echo "Spec URL: $openapi_url"
  fetch_spec "$openapi_url" -o openapi.yaml
else
  echo ".stats.yml does not expose openapi_spec_url; assembling the latest public API fragments."
  python3 fetch-openapi.py openapi.yaml --fallback-spec openapi.yaml
fi

# Cartesia documents Sonic 3.6 as generally available, alongside its immutable
# production snapshot, preview track, Odia, Urdu, and locale-aware language
# codes. The Stainless OpenAPI document currently lags those documented values,
# so apply a fail-closed, idempotent override before generation.
python3 patch-openapi.py openapi.yaml

install_autosdk_cli
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Cartesia \
  --clientClassName CartesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
