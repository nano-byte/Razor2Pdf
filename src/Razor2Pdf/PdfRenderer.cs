using System;
using System.Threading.Tasks;
using Medallion.Shell;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IO;

namespace NanoByte.Razor2Pdf;

/// <summary>
/// Renders Razor Pages as PDFs.
/// </summary>
public class PdfRenderer(IRazorViewRenderer renderer, IWebHostEnvironment environment) : IPdfRenderer
{
    private static readonly RecyclableMemoryStreamManager _streamManager = new();

    public async Task<FileStreamResult> RenderAsync<T>(string viewPath, T model)
    {
        string html = await renderer.RenderAsync(viewPath, model);
        var stream = _streamManager.GetStream();

        var result = await
            Command.Run("weasyprint",
                        ["-", "-"],
                        opts => opts.WorkingDirectory(environment.WebRootPath))
                   .RedirectFrom(html)
                   .RedirectTo(stream)
                   .Task;
        if (!result.Success) throw new Exception(result.StandardError);
        stream.Position = 0;

        return new FileStreamResult(stream, contentType: "application/pdf");
    }

    public Task<FileStreamResult> RenderAsync(string viewPath)
        => RenderAsync(viewPath, new object());

    public Task<FileStreamResult> RenderAsync<T>(T model) where T : IPdfModel
        => RenderAsync(model.ViewPath, model);
}
