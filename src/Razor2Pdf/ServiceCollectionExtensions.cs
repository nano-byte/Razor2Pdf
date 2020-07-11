using Microsoft.Extensions.DependencyInjection;

namespace NanoByte.Razor2Pdf
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds support for rendering Razor Pages as PDFs.
        /// </summary>
        public static IServiceCollection AddRazor2Pdf(this IServiceCollection services)
            => services.AddTransient<IRazorViewRenderer, RazorViewRenderer>()
                       .AddTransient<IPdfRenderer, PdfRenderer>();
    }
}
