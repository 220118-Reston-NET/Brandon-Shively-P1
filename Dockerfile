from mcr.microsoft.com/dotnet/aspnet:latest as build

workdir /app

copy *.sln ./
copy StarWarsApi/*.csproj StarWarsApi/
copy StarWarsBL/*.csproj StarWarsBL/
copy StarWarsDL/*.csproj StarWarsDL/
copy StarWarsModel/*.csproj StarWarsModel/
copy StarWarsTest/*.csproj StarWarsTest/

copy . ./

run dotnet publish -c Release -o publish

from mcr.microsoft.com/dotnet/aspnet:latest as runtime

workdir /appcopy --from+build app/publish ./

cmd ["dotnet", "StarWarsApi.dll"]

expose 80

