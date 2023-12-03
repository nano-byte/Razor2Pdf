# For trying out Sample.csproj

FROM mcr.microsoft.com/dotnet/sdk AS build

WORKDIR /src
COPY *.sln .
COPY Razor2Pdf/Razor2Pdf.csproj Razor2Pdf/
COPY Sample/Sample.csproj Sample/
RUN dotnet restore

COPY . .
RUN echo "dummy" > /README.md
RUN dotnet publish Sample -o /app/publish /p:UseAppHost=false

FROM weasyprint/aspnet-core:7.0.14-60.1
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Sample.dll"]
