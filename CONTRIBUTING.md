# Contributing

## Installing

## Updating

- `dotnet build` (only if testing locally)

- Build [runtime ids](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog) with `./build.sh`

  - `dotnet publish --runtime osx-arm64`
  - `dotnet publish --runtime osx-x64`
  - `dotnet publish --runtime linux-arm64`
  - `dotnet publish --runtime linux-x64`
  - `dotnet publish --runtime win-arm64`
  - `dotnet publish --runtime win-x64`
  - `dotnet publish --runtime win-x86`

- `./build.sh`
- `git add -A`
- `git commit -m "message"`
- `git push`
- `git tag v0.0.1`
- `git push origin v0.0.1`

```
gh release create v0.0.1 \
  "build/bunny-sdk-osx-arm64.gz" \
  "build/bunny-sdk-osx-x64.gz" \
  "build/bunny-sdk-linux-arm64.gz" \
  "build/bunny-sdk-linux-x64.gz" \
  "build/bunny-sdk-win-arm64.gz" \
  "build/bunny-sdk-win-x64.gz" \
  "build/bunny-sdk-win-x86.gz"
```
