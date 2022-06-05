# ASP.NET Core Runtime and WeasyPrint Docker image

This Docker image is based on [ASP.NET Core Runtime image](https://hub.docker.com/_/microsoft-dotnet-aspnet/) and adds [WeasyPrint](https://weasyprint.org/). This can be used to build .NET webapps that shell out to WeasyPrint for generating PDFs.

## Usage

Reference the docker image `weasyprint/aspnet-core:TAG`, where `TAG` is one of the available [image tags](https://hub.docker.com/r/weasyprint/aspnet-core/tags). The tag specified the version of .NET and WeasyPrint used. For example, the image tagged `5.0.5-55.0` contains .NET 6.0.5 and WeasyPrint 55.0.

## Building

To publish a new release of this image:

- Adjust the version numbers in `.env` if necessary.
- Run `docker-compose build`.
- Run `docker-compose push`.
