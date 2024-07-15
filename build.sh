#!/usr/bin/env bash
set -euo pipefail

rm -rf ./bin ./obj

dotnet publish --runtime osx-arm64
dotnet publish --runtime osx-x64
dotnet publish --runtime linux-arm64
dotnet publish --runtime linux-x64
dotnet publish --runtime win-arm64
dotnet publish --runtime win-x64
dotnet publish --runtime win-x86

