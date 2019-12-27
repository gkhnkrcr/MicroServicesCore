FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MicroServices/MicroServices.csproj", "MicroServices/"]
RUN dotnet restore "MicroServices/MicroServices.csproj"
COPY . .
WORKDIR "/src/MicroServices"
RUN dotnet build "MicroServices.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroServices.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroServices.dll"]