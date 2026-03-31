FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet nuget locals all --clear
RUN dotnet restore APIDemo/APIDemo.csproj --no-cache
RUN dotnet publish APIDemo/APIDemo.csproj -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "APIDemo.dll"]