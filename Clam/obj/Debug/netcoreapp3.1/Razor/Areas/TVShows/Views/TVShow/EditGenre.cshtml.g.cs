#pragma checksum "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c7e1eec9610b7b079f42480ea5c8d764180470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TVShows_Views_TVShow_EditGenre), @"mvc.1.0.view", @"/Areas/TVShows/Views/TVShow/EditGenre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c7e1eec9610b7b079f42480ea5c8d764180470", @"/Areas/TVShows/Views/TVShow/EditGenre.cshtml")]
    public class Areas_TVShows_Views_TVShow_EditGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clam.Areas.TVShows.Models.SectionTVShowCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
   var Name = ViewBag.Name;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
  
    ViewData["Title"] = "EditGenre";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var Gid = ViewBag.Gid;

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\"><a href=\"/tvshows/manage\">Genres</a></li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">Edit ");
#nullable restore
#line 11 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
                                                               Write(Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Genre</li>\r\n    </ol>\r\n</nav>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n");
#nullable restore
#line 17 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
         using (Html.BeginForm(actionName: "EditGenre", controllerName: "TVShow", method: FormMethod.Post, new { enctype = "multipart/form-data", id = Gid, category = Name }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
       Write(Html.ValidationSummary(message: "Ensure Field is filled in by specific requirements.", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
           Write(Html.LabelFor(model => model.Genre, null, new { @class = "col-md-4 col-form-label control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-8\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
               Write(Html.TextBoxFor(model => model.Genre, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
               Write(Html.ValidationMessageFor(model => model.Genre, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
           Write(Html.LabelFor(model => model.FormFile, null, new { @class = "col-md-4 col-form-label control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-8\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
               Write(Html.TextBoxFor(model => model.FormFile, null, new { @class = "form-control-file border", @type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
               Write(Html.ValidationMessageFor(model => model.FormFile, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Gorilla Rig\source\repos\Clam\Clam\Areas\TVShows\Views\TVShow\EditGenre.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clam.Areas.TVShows.Models.SectionTVShowCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591