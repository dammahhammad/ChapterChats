#pragma checksum "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f42963f1c6439cc45fe8f27ac5e911cac2f376f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetEvents), @"mvc.1.0.view", @"/Views/Event/GetEvents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f42963f1c6439cc45fe8f27ac5e911cac2f376f", @"/Views/Event/GetEvents.cshtml")]
    public class Views_Event_GetEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
  
    ViewData["Title"] = "GetEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    .table, th, tr {
        width: 15in;
        border: 2px solid pink;
    }
</style>

<div class=""container"">
    <h3 class=""display-4"">All Events</h3><br />
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
                    <th>Edit</th>
                </tr>
            </thead>
");
#nullable restore
#line 33 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
             foreach (var eve in Model)
            {
                if (User.Identity.Name == "myadmin@bookevents.com")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody class=\"tbody\">\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 39 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Starttime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.DisplayFor(modelItem => eve.Invitations));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { title = eve.Title }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 52 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"

                }
                else
                {
                    if (eve.Type == "Public")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody class=\"tbody\">\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 60 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 61 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 62 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 63 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Starttime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"
                               Write(Html.DisplayFor(modelItem => eve.Invitations));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>--</td>\r\n                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 73 "D:\mohammad-hammad\WebApplication1\Views\Event\GetEvents.cshtml"

                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
