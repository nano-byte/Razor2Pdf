using System.Threading.Tasks;

namespace NanoByte.Razor2Pdf
{
    /// <summary>
    /// Renders Razor Views in-memory instead of providing an HTTP responses.
    /// </summary>
    public interface IRazorViewRenderer
    {
        /// <summary>
        /// Renders a Razor View.
        /// </summary>
        /// <param name="viewPath">The path of the Razor View to render.</param>
        /// <param name="model">The model to pass to the Razor View.</param>
        Task<string> RenderAsync<T>(string viewPath, T model);
    }
}
