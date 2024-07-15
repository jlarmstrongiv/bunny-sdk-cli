# Contributing

## Installing

## Updating

- `dotnet build` (only if testing locally)

- Increment version in `bunny-sdk.csproj`
- `./build.sh`
- `git add -A`
- `git commit -m "message"`
- `git push`
- `git tag v0.0.1`
- `git push origin v0.0.1`

```
gh release create v0.0.1 --notes="" \
  "build/bunny-sdk-osx-arm64.gz" \
  "build/bunny-sdk-osx-x64.gz" \
  "build/bunny-sdk-linux-arm64.gz" \
  "build/bunny-sdk-linux-x64.gz" \
  "build/bunny-sdk-win-arm64.gz" \
  "build/bunny-sdk-win-x64.gz" \
  "build/bunny-sdk-win-x86.gz"
```
