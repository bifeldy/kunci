# See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /src
COPY ["Kuncii/Kuncii/Kuncii.csproj", "Kuncii/Kuncii/"]
RUN dotnet restore "Kuncii/Kuncii/Kuncii.csproj" --disable-parallel
COPY . .
WORKDIR /src/Kuncii/Kuncii/
RUN dotnet build "Kuncii.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kuncii.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kuncii.dll"]