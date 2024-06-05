FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
WORKDIR "/src/src/ob.core.api"
RUN dotnet publish "ob.core.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/publish .

#Install linux dependencies.
RUN apt-get update && apt-get -y install libgdiplus
ENV LD_LIBRARY_PATH="/usr/lib"

ENTRYPOINT ["dotnet", "ob.core.api.dll"]