FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cuebit/Cuebit.csproj", "Cuebit/"]
RUN dotnet restore "Cuebit/Cuebit.csproj"
COPY . .
WORKDIR "/src/Cuebit"
RUN dotnet build "Cuebit.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cuebit.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cuebit.dll"]
