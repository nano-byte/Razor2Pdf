# ASP.NET Core Runtime and WeasyPrint Docker image

This Docker image is based on [ASP.NET Core Runtime image](https://hub.docker.com/_/microsoft-dotnet-aspnet/) and adds [WeasyPrint](https://weasyprint.org/). This can be used to build .NET webapps that shell out to WeasyPrint for generating PDFs.

## Usage

Reference the docker image `weasyprint/aspnet-core`.

You can optionally [specify a tag](https://hub.docker.com/r/weasyprint/aspnet-core/tags) to control the version of .NET and WeasyPrint to use. For example, the image tagged `5.0.2-52.2` contains .NET 5.0.2 and WeasyPrint 52.2.

## Building

To publish a new release of this image:

- Adjust the version numbers in `.env` if necessary.
- Run `docker-compose build`.
- Run `docker-compose push`.
