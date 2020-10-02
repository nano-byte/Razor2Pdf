using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NanoByte.Razor2Pdf
{
    /// <summary>
    /// Renders Razor Pages as PDFs.
    /// </summary>
    public interface IPdfRenderer
    {
        /// <summary>
        /// Renders a Razor View as a PDF.
        /// </summary>
        /// <param name="viewPath">The path of the Razor View to render.</param>
        /// <param name="model">The model to pass to the Razor View.</param>
        Task<FileStreamResult> RenderAsync<T>(string viewPath, T model);

        /// <summary>
        /// Renders a Razor View as a PDF.
        /// </summary>
        /// <param name="viewPath">The path of the Razor View to render.</param>
        Task<FileStreamResult> RenderAsync(string viewPath);

        /// <summary>
        /// Renders a Razor View as a PDF.
        /// </summary>
        /// <param name="model">The model for the view to render.</param>
        Task<FileStreamResult> RenderAsync<T>(T model)
            where T : IPdfModel;
    }
}
