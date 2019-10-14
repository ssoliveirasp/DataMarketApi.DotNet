
REM Cria Soluçao
dotnet new sln

REM Adiciona projeto a solução
dotnet sln add FlyApi.Api/FlyApi.Api.csproj
dotnet sln add flyApi.Domain/FlyApiContext.Domain.csproj

REM Criaçao "Domain" e "Infra"
dotnet new classlib

dotnet new classlib FlyApi.Infra.CrossCutting.Caching

REM Adiciona referencia
dotnet add FlyApi.Infra/FlyApi.Infra.csproj 
      reference FlyApi.Domain/FlyApiContext.Domain.csproj

REM Adiciona Package AspNetCore.All
dotnet add package Microsoft.AspNetCore.All -v 2.0.5