# #See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["BMO.Api/BMO.Api.csproj", "BMO.Api/"]
# RUN dotnet restore "BMO.Api/BMO.Api.csproj"
# COPY . .
# WORKDIR "/src/BMO.Api"
# RUN dotnet build "BMO.Api.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "BMO.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "BMO.Api.dll"]

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy the csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80

# Copy the published application from the build stage
COPY --from=build-env /app/out .

# Set the command to run your application
CMD ["dotnet", "BMO.Api.dll"]
