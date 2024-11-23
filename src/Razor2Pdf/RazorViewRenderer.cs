using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;

namespace NanoByte.Razor2Pdf;

/// <summary>
/// Renders Razor Views in-memory instead of providing an HTTP responses.
/// </summary>
public class RazorViewRenderer(IRazorViewEngine viewEngine, ITempDataProvider tempDataProvider, IHttpContextAccessor contextAccessor, IServiceProvider serviceProvider)
    : IRazorViewRenderer
{
    public async Task<string> RenderAsync<T>(string viewPath, T model)
    {
        var actionContext = new ActionContext(
            contextAccessor.HttpContext ?? new DefaultHttpContext {RequestServices = serviceProvider},
            new RouteData(),
            new ActionDescriptor());
        var view = FindView(viewPath);

        await using var writer = new StringWriter();
        var viewContext = new ViewContext(
            actionContext,
            view,
            new ViewDataDictionary<T>(new EmptyModelMetadataProvider(), new ModelStateDictionary()) {Model = model},
            new TempDataDictionary(actionContext.HttpContext, tempDataProvider),
            writer,
            new HtmlHelperOptions());
        await view.RenderAsync(viewContext);
        return writer.ToString();
    }

    private IView FindView(string viewPath)
    {
        var searchResult = viewEngine.GetView(null, viewPath, false);
        if (searchResult.Success)
            return searchResult.View;
        else
            throw new InvalidOperationException(string.Join(Environment.NewLine, new[] {$"Unable to find view '{viewPath}'. The following locations were searched:"}.Concat(searchResult.SearchedLocations)));
    }
}
