# ASP.NET Core Runtime and WeasyPrint Docker image

This Docker image is based on [ASP.NET Core Runtime image](https://hub.docker.com/_/microsoft-dotnet-core-aspnet/) and adds [WeasyPrint](https://weasyprint.org/). This can be used to build .NET webapps that shell out to WeasyPrint for generating PDFs.

## Usage

Reference the docker image `weasyprint/aspnet-core`.

You can optionally [specify a tag](https://hub.docker.com/r/weasyprint/aspnet-core/tags) to control the version of .NET Core and WeasyPrint to use. For example, the image tagged `3.1.5-51` contains .NET Core 3.1.5 and WeasyPrint 51.

## Building

To publish a new release of this image:

- Adjust the version numbers in `.env` if necessary.
- Run `docker-compose build`.
- Run `docker-compose push`.
