FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SampleWeb.csproj", "/"]
RUN dotnet restore "/SampleWeb.csproj"

COPY . .
RUN dotnet publish -c Release -o /app SampleWeb.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS publish
WORKDIR /app
COPY --from=build /app ./
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet", "SampleWeb.dll"]
