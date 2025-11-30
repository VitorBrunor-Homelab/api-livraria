FROM mcr.microsift.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["API Livraria.csproj", "./"]
RUN dotnet restore "API Livraria.csproj"

COPY . .
RUN dotnet publish "API Livraria.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "API Livraria.dll"]