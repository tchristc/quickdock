#pragma checksum "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDock - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3595358b2f38cfd410b82dc10bc9b9480c0edd48"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

    [Microsoft.AspNetCore.Components.RouteAttribute("/quickdock")]
    public class QuickDock___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 24 "C:\Users\TomCC\source\repos\BlazorTest\BlazorTest.WebApplication1\BlazorTest.WebApplication1.App\Pages\QuickDock - Copy.cshtml"
            
    static Random Rand = new Random();

    long x = 0;
    long y = 0;

    void MouseMove(UIMouseEventArgs e)
    {
        x = e.ClientX;
        y = e.ClientY;
    }


    string RandomColor()
    {
        var randomColor = $"#{Rand.Next(256):X}{Rand.Next(256):X}{Rand.Next(256):X}";
        return randomColor;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591