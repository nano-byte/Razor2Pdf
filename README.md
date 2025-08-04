# Razor2Pdf

[![Build](https://github.com/nano-byte/Razor2Pdf/actions/workflows/build.yml/badge.svg)](https://github.com/nano-byte/Razor2Pdf/actions/workflows/build.yml)
[![NuGet](https://img.shields.io/nuget/v/NanoByte.Razor2Pdf.svg)](https://www.nuget.org/packages/NanoByte.Razor2Pdf/)
[![API documentation](https://img.shields.io/badge/api-docs-orange.svg)](https://razor2pdf.nano-byte.net/)  
Razor2Pdf renders [ASP.NET Core Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/) as PDFs using [WeasyPrint](https://weasyprint.org/).

## Usage

1. Ensure that the `weasyprint` command is in your `PATH`. You can:
   - follow the [WeasyPrint installation instructions](https://weasyprint.readthedocs.io/en/stable/install.html) or
   - use our [ASP.NET Core Runtime and WeasyPrint Docker image](docker/).
2. Add a reference to the [`NanoByte.Razor2Pdf`](https://www.nuget.org/packages/NanoByte.Razor2Pdf/) NuGet package to your project.
3. Add a call to `services.AddRazor2Pdf()` in your `ConfigureServices()` method in `Startup.cs`.

You can now use dependency injection to get an instance of `IPdfRenderer` and use it like this:

```csharp
FileStreamResult result = await pdfRenderer.RenderAsync("path/to/my/view", new MyViewModel(...));
```

See the [sample project](https://github.com/nano-byte/Razor2Pdf/tree/master/src/Sample/) for more details.

## Building

The source code is in [`src/`](src/), config for building the API documentation is in [`doc/`](doc/) and generated build artifacts are placed in `artifacts/`. The source code does not contain version numbers. Instead the version is determined during CI using [GitVersion](https://gitversion.net/).

To build run `.\build.ps1` or `./build.sh` (.NET SDK is automatically downloaded if missing using [0install](https://0install.net/)).

You can use also user Docker Compose to build the library and run the included sample project at http://localhost:8080/:

    cd src
    docker-compose up

## Contributing

We welcome contributions to this project such as bug reports, recommendations and pull requests.

This repository contains an [EditorConfig](http://editorconfig.org/) file. Please make sure to use an editor that supports it to ensure consistent code style, file encoding, etc.. For full tooling support for all style and naming conventions consider using JetBrains' [ReSharper](https://www.jetbrains.com/resharper/) or [Rider](https://www.jetbrains.com/rider/) products.
