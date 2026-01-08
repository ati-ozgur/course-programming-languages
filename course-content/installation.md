## Kurulum/installation


### Windows Java/.NET/Node/Deno

**.NET**
```cmd
scoop bucket add versions
scoop install versions/dotnet7-sdk
scoop install versions/dotnet8-sdk
scoop install versions/dotnet9-sdk
scoop install versions/dotnet10-sdk
```
**Java**

```cmd
REM latest version
scoop bucket add java
scoop install java/openjdk
REM install a specific version
scoop install java/openjdk25
scoop install java/openjdk24

```
**node for javascript/typescript**

```cmd
REM latest version
scoop install main/nodejs
scoop install main/nodejs-lts
REM install a specific version
scoop bucket add versions
scoop install versions/nodejs24

```


### Linux .NET


```bash
# install the latest version/10
brew install dotnet

# install a specific version (8, 9, etc.)
brew install dotnet@10
brew install dotnet@9
brew install dotnet@8

```


### Linux .NET


```bash
# install the latest version
mise use dotnet

# install a specific version (8, 9, etc.)
mise use dotnet@8
mise use dotnet@9

```

