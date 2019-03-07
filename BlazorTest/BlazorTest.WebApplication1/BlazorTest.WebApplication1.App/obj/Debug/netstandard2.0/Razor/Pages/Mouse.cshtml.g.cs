#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\Mouse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9981c3e6cb7040670ee317abc8fabaf216f78e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.WebApplication1.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorTest.WebApplication1.App;
    using BlazorTest.WebApplication1.App.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/mouse")]
    public class Mouse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<style>\r\n    .input_canvas{\r\n        position: absolute; \r\n        top: 0; \r\n        left: 0; \r\n        height: 100%; \r\n        width: 100%\r\n    }\r\n</style>\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "input_canvas");
            builder.AddAttribute(3, "onmousemove", Microsoft.AspNetCore.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Components.UIMouseEventArgs>(e=> MouseMove(e)));
            builder.CloseElement();
            builder.AddContent(4, "\r\n");
            builder.AddMarkupContent(5, "<h1>Mouse</h1>\r\n\r\n");
            builder.OpenElement(6, "p");
            builder.AddContent(7, "X: ");
            builder.AddContent(8, x);
            builder.AddContent(9, " Y: ");
            builder.AddContent(10, y);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 17 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\Mouse.cshtml"
            
    long x = 0;
    long y = 0;

    void MouseMove(UIMouseEventArgs e)
    {
        x = e.ClientX;
        y = e.ClientY;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591