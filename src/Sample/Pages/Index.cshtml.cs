using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NanoByte.Razor2Pdf;

namespace Sample.Pages;

public class IndexModel : PageModel
{
    private readonly IPdfRenderer _pdfRenderer;

    public IndexModel(IPdfRenderer pdfRenderer)
    {
        _pdfRenderer = pdfRenderer;
    }

    [BindProperty]
    public string Name { get; set; } = "Smith";

    public async Task<FileStreamResult> OnPostReportAsync()
    {
        return await _pdfRenderer.RenderAsync(new ReportModel {Name = Name});
    }
}
