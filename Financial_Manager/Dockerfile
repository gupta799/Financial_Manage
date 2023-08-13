FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Financial_Manager/Financial_Manager.csproj", "Financial_Manager/"]

RUN dotnet restore "Financial_Manager/Financial_Manager.csproj"
COPY . .
WORKDIR "/src/Financial_Manager"
RUN dotnet build "Financial_Manager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Financial_Manager.csproj" -c Release -o /app/publish /p:UseAppHost=flase

FROM base AS final
COPY --from=publish /app/publish .
WORKDIR /app
CMD  dotnet Financial_Manager.dll