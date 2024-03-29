﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using NanoByte.Razor2Pdf;

namespace Sample.Pages;

public class ReportModel : PageModel, IPdfModel
{
    public string ViewPath => "/Pages/Report.cshtml";

    public required string Name { get; set; }
}
