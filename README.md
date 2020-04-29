# Api Health

Web api created in .Net Core Cli

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Step 0

```bash
mkdir social-media.API
mkdir social-media.INFRASTRUCTURE
mkdir Test

cd social-media.API
dotnet new webapi

cd ..
dotnet new classlib -f netstandard2.1 -n social-media.CORE

cd social-media.INFRASTRUCTURE
dotnet new classlib -f netstandard2.1

cd ../Test
dotnet new mstest -f netcoreapp3.1 -n social-media.UnitTest
dotnet new mstest -f netcoreapp3.1 -n social-media.IntegrationTest

cd..
dotnet new sln
dotnet sln clean-architecture.sln add social-media.API/social-media.API.csproj
dotnet sln clean-architecture.sln add social-media.CORE/social-media.CORE.csproj
dotnet sln clean-architecture.sln add social-media.INFRASTRUCTURE/social-media.INFRASTRUCTURE.csproj

*References*

dotnet add social-media.API/social-media.API.csproj reference social-media.CORE/social-media.CORE.csproj

cd social-media.API
dotnet add reference ../social-media.INFRASTRUCTURE/social-media.INFRASTRUCTURE.csproj

cd..
dotnet add social-media.INFRASTRUCTURE/social-media.INFRASTRUCTURE.csproj reference social-media.CORE/social-media.CORE.csproj
```

 ### Step 1

```bash
dotnet tool install --global dotnet-ef --version 3.0.0-*
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

<!--
### Step 2

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.Extensions.DependencyInjection --version 3.1.3
``` -->

### Create api controller

```bash
dotnet aspnet-codegenerator controller -name PostController -async -api -outDir Controllers
```
<!-- 
### libman install CORSClient
```bash
libman install jquery@3.2.1 --provider cdnjs --destination wwwroot/scripts/jquery --files jquery.min.js
```

### Building and running

To create an optimised version of the app:

* **Health.API**
```bash
dotnet watch run
```

* **CORSClient**
```bash
dotnet watch run
```

## Authors

* **Ernesto Vargas** - *Initial work* - [AkiraGothick](https://github.com/akiragothick)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details -->