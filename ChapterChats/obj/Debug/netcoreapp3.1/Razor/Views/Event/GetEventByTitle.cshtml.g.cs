#pragma checksum "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c7c8b5cb5192e4b6ec68f6cd8040845d37ecef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetEventByTitle), @"mvc.1.0.view", @"/Views/Event/GetEventByTitle.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c7c8b5cb5192e4b6ec68f6cd8040845d37ecef", @"/Views/Event/GetEventByTitle.cshtml")]
    #nullable restore
    public class Views_Event_GetEventByTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.EventModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
  
    ViewData["Title"] = "GetEventByTitle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral(@"
<style>
    .table, th, tr {
        width: 15in;
        border: 2px solid pink;
    }
</style>


<div class=""container"">
    <h3 class=""display-4"">Details</h3><br />
    <div class=""row"">
        <table class=""table table-bordered table-hover"">
            <thead class=""thead"">
                <tr>
                    <th>Title</th>
                    <th>Email</th>
                    <th>Date</th>
                    <th>Location</th>
                    <th>Start Time</th>
                    <th>Type</th>
                    <th>Duration</th>
                    <th>Description</th>
                    <th>Details</th>
                    <th>Invitations</th>
                </tr>
            </thead>
");
#nullable restore
#line 34 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
             foreach (var eve in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody class=\"tbody\">\n                    <tr>\n                        <td>");
#nullable restore
#line 38 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 40 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 41 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 42 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Starttime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
                       Write(Html.DisplayFor(m => eve.Invitations));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                </tbody>\n");
#nullable restore
#line 50 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n    <p>\n        ");
#nullable restore
#line 54 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\GetEventByTitle.cshtml"
   Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.EventModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591