FROM microsoft/aspnetcore:1.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:1.1 AS build
WORKDIR /src
COPY Citiesinfo.API/Citiesinfo.API.csproj Citiesinfo.API/
RUN dotnet restore Citiesinfo.API/Citiesinfo.API.csproj
COPY . .
WORKDIR /src/Citiesinfo.API
RUN dotnet build Citiesinfo.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Citiesinfo.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Citiesinfo.API.dll"]
