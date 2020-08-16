Razor2Pdf renders [APS.NET Core Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/) as PDFs using [WeasyPrint](https://weasyprint.org/).

[**GitHub repository**](https://github.com/nano-byte/Razor2Pdf)

## Usage

1. Ensure that the `weasyprint` command is in your `PATH`. You can:
   - follow the [WeasyPrint installation instructions](https://weasyprint.readthedocs.io/en/stable/install.html) or
   - use our [ASP.NET Core Runtime and WeasyPrint Docker image](https://hub.docker.com/r/weasyprint/aspnet-core).
2. Add a reference to the [NanoByte.Razor2Pdf](https://www.nuget.org/packages/NanoByte.Razor2Pdf/) NuGet package to your project.
3. Add a call to `services.AddRazor2Pdf()` in your `ConfigureServices()` method in `Startup.cs`.

You can now use dependency injection to get an instance of `IPdfRenderer` and use it like this:

```csharp
FileStreamResult result = await pdfRenderer.RenderAsync("path/to/my/view", new MyViewModel(...));
```

See the [sample project](https://github.com/nano-byte/Razor2Pdf/tree/master/src/Sample/) for more details.
