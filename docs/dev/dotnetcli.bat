
REM Cria Soluçao
dotnet sln add src/flyApi.Domain/FlyApiContext.Domain.csproj

REM Adiciona projeto a solução
dotnet sln add src/FlyApi.Infra/FlyApi.Infra.csproj

REM Criaçao "Domain" e "Infra"
dotnet new classlib

REM Adiciona referencia
dotnet add FlyApi.Infra/FlyApi.Infra.csproj 
      reference FlyApi.Domain/FlyApiContext.Domain.csproj

REM Adiciona Package AspNetCore.All
dotnet add package Microsoft.AspNetCore.All -v 2.0.5