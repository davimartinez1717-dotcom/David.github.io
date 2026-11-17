# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["AlumnosWeb/AlumnosWeb.csproj", "AlumnosWeb/"]
RUN dotnet restore "AlumnosWeb/AlumnosWeb.csproj"

COPY . .
WORKDIR /src/AlumnosWeb
RUN dotnet publish "AlumnosWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_HTTP_PORTS=10000
EXPOSE 10000
ENTRYPOINT ["dotnet", "AlumnosWeb.dll"]
