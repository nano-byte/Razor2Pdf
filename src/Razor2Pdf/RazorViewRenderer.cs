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
public class RazorViewRenderer : IRazorViewRenderer
{
    private readonly IRazorViewEngine _viewEngine;
    private readonly ITempDataProvider _tempDataProvider;
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly IServiceProvider _serviceProvider;

    public RazorViewRenderer(IRazorViewEngine viewEngine, ITempDataProvider tempDataProvider, IHttpContextAccessor contextAccessor, IServiceProvider serviceProvider)
    {
        _viewEngine = viewEngine;
        _tempDataProvider = tempDataProvider;
        _contextAccessor = contextAccessor;
        _serviceProvider = serviceProvider;
    }

    public async Task<string> RenderAsync<T>(string viewPath, T model)
    {
        var actionContext = new ActionContext(
            _contextAccessor.HttpContext ?? new DefaultHttpContext {RequestServices = _serviceProvider},
            new RouteData(),
            new ActionDescriptor());
        var view = FindView(viewPath);

        using var writer = new StringWriter();
        var viewContext = new ViewContext(
            actionContext,
            view,
            new ViewDataDictionary<T>(new EmptyModelMetadataProvider(), new ModelStateDictionary()) {Model = model},
            new TempDataDictionary(actionContext.HttpContext, _tempDataProvider),
            writer,
            new HtmlHelperOptions());
        await view.RenderAsync(viewContext);
        return writer.ToString();
    }

    private IView FindView(string viewPath)
    {
        var searchResult = _viewEngine.GetView(null, viewPath, false);
        if (searchResult.Success)
            return searchResult.View;
        else
            throw new InvalidOperationException(string.Join(Environment.NewLine, new[] {$"Unable to find view '{viewPath}'. The following locations were searched:"}.Concat(searchResult.SearchedLocations)));
    }
}
