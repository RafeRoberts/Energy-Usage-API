#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Energy Usage API/Energy Usage API.csproj", "Energy Usage API/"]
RUN dotnet restore "Energy Usage API/Energy Usage API.csproj"
COPY . .
WORKDIR "/src/Energy Usage API"
RUN dotnet build "Energy Usage API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Energy Usage API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Energy Usage API.dll"]