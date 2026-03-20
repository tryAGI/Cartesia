#!/usr/bin/env bash
set -euo pipefail

# Cartesia spec is hosted on Stainless GCS with hash-based URLs.
# To update: check cartesia-ai/cartesia-python/.stats.yml for the latest URL.
readonly openapi_url="https://storage.googleapis.com/stainless-sdk-openapi-specs/cartesia-noahlt%2Fnoah-testing-e5a73fdf4a13966d2f5a4e1e85fbeae6d29bd66c3d73e44a1fcf8bc4afe4b27f.yml"

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace Cartesia \
  --clientClassName CartesiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
