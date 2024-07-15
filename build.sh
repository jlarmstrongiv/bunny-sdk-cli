#!/usr/bin/env bash
set -euo pipefail

rm -rf ./bin ./obj

# runtime ids https://learn.microsoft.com/en-us/dotnet/core/rid-catalog

dotnet publish --runtime osx-arm64
dotnet publish --runtime osx-x64
dotnet publish --runtime linux-arm64
dotnet publish --runtime linux-x64
dotnet publish --runtime win-arm64
dotnet publish --runtime win-x64
dotnet publish --runtime win-x86

gzip -k 'bin/Release/net8.0/osx-arm64/bunny-sdk'
gzip -k 'bin/Release/net8.0/osx-x64/bunny-sdk'
gzip -k 'bin/Release/net8.0/linux-arm64/bunny-sdk'
gzip -k 'bin/Release/net8.0/linux-x64/bunny-sdk'
gzip -k 'bin/Release/net8.0/win-arm64/bunny-sdk.exe'
gzip -k 'bin/Release/net8.0/win-x64/bunny-sdk.exe'
gzip -k 'bin/Release/net8.0/win-x86/bunny-sdk.exe'

rm -rf build
mkdir build
mv 'bin/Release/net8.0/osx-arm64/bunny-sdk.gz' 'build/bunny-sdk-osx-arm64.gz'
mv 'bin/Release/net8.0/osx-x64/bunny-sdk.gz' 'build/bunny-sdk-osx-x64.gz'
mv 'bin/Release/net8.0/linux-arm64/bunny-sdk.gz' 'build/bunny-sdk-linux-arm64.gz'
mv 'bin/Release/net8.0/linux-x64/bunny-sdk.gz' 'build/bunny-sdk-linux-x64.gz'
mv 'bin/Release/net8.0/win-arm64/bunny-sdk.exe.gz' 'build/bunny-sdk-win-arm64.gz'
mv 'bin/Release/net8.0/win-x64/bunny-sdk.exe.gz' 'build/bunny-sdk-win-x64.gz'
mv 'bin/Release/net8.0/win-x86/bunny-sdk.exe.gz' 'build/bunny-sdk-win-x86.gz'