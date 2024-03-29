#pragma checksum "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d9157a2e5dfba084d6cb836615fe519f0d71b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_CreateEvent), @"mvc.1.0.view", @"/Views/Event/CreateEvent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d9157a2e5dfba084d6cb836615fe519f0d71b8", @"/Views/Event/CreateEvent.cshtml")]
    #nullable restore
    public class Views_Event_CreateEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.EventModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"container\">\n    <br />\n    <h3>Create Event</h3>\n    <hr />\n");
#nullable restore
#line 8 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
     if (ViewBag.IsSuccess)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
            <strong>Congratulations!</strong> You have successfully created a new event.
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
");
#nullable restore
#line 16 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<form method=\"post\" asp-action=\"GetEvents\" asp-controller=\"Event\">\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 21 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Title, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 22 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 23 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 27 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 28 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 29 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n\n        ");
#nullable restore
#line 34 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Date, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 35 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Date, String.Format("0:dd/MM/yyyy"), new { @class = "form-control", type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 36 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 40 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Location, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 41 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Location, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 42 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 46 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Starttime, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 47 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextBoxFor(m => m.Starttime, new { @class = "form-control", type = "Time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 48 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Starttime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 52 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Type, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 53 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.DropDownList("Type", new List<SelectListItem> {
                new SelectListItem {Text="Public"},
                new SelectListItem {Text="Private"}
                }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 60 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Duration, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 61 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.DropDownList("Duration", new List<SelectListItem> {
                new SelectListItem {Text="1"},
                new SelectListItem {Text="2"},
                new SelectListItem {Text="3"},
                new SelectListItem {Text="4"}
                }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 70 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(model => model.Invitations, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 71 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.EditorFor(model => model.Invitations, new { htmlAttributes = new { @class = "form-control", placeholder = "Write emails separated by comma" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 72 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(model => model.Invitations, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 76 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Description, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 77 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 78 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 82 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.LabelFor(m => m.Details, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 83 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.TextAreaFor(m => m.Details, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 84 "D:\Nagarro-Data\mohammad-hammad-MVC\mohammad-hammad-MVC\WebApplication1\Views\Event\CreateEvent.cshtml"
   Write(Html.ValidationMessageFor(m => m.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        <button class=\"btn btn-primary\" type=\"submit\"> Add Event</button>\n    </div>\n</form>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.EventModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
