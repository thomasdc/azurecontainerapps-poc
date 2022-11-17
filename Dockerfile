FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Install npm
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

# Restore npm packages
WORKDIR /src/front-src
COPY ["front-src/package*.json", "."]
RUN npm ci

# Restore nuget packages
WORKDIR /src
COPY ["SampleWeb.csproj", "."]
RUN dotnet restore "./SampleWeb.csproj"

# Copy all sources
COPY . .

# Compile frontend
WORKDIR /src/front-src
RUN npm run build

# Compile backend
WORKDIR /src
RUN dotnet publish "SampleWeb.csproj" -c Release -o /app --no-restore /p:UseAppHost=false

########################

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS publish
COPY --from=build /app .
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet", "SampleWeb.dll"]
