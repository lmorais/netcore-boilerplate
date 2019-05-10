FROM microsoft/dotnet:2.2-sdk AS build-env
ADD . /app
WORKDIR /app
RUN dotnet build
RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/core/runtime:2.2
WORKDIR /app
COPY --from=build-env /app /app/
CMD ["dotnet", "bin/Release/netcoreapp2.2/Net.Core.Api.Boilerplate.dll"]