FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY ./CloudRunDemo/CloudRunDemo.csproj ./CloudRunDemo/CloudRunDemo.csproj
COPY *.sln ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o build --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build ./build .
ENV ASPNETCORE_URLS=http://*:8080
EXPOSE 8080
ENTRYPOINT [ "dotnet", "CloudRunDemo.dll" ]