# clean-architecture

#1
dotnet tool install --global dotnet-ef --version 3.0.0-*
dotnet tool install -g dotnet-aspnet-codegenerator

#2
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.Extensions.DependencyInjection --version 3.1.3

#3 scalfold
dotnet aspnet-codegenerator controller -name ValuesController -async -api --readWriteActions -outDir Controllers