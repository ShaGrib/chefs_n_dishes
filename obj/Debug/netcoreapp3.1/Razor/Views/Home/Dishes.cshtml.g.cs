#pragma checksum "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d08fc024eb3410b8fe23873791b75258ff177038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\_ViewImports.cshtml"
using chefs_n_dishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\_ViewImports.cshtml"
using chefs_n_dishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d08fc024eb3410b8fe23873791b75258ff177038", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2ef749da9da9277fabbfff3736ce7454c091af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""m-5"">
    <div class=""d-flex row justify-content-between"">
        <div></div>
        <h1 class=""/""><a href=""/"">Chefs</a>
            | Dishes
        </h1>
        <a href=""/dishes/new"" class=""text-center d-flex align-items-center"">Add a Dish</a>
    </div>
    <div class=""d-flex justify-content-start"">
        <h5 class=""col-5"">Yum, take a look at our tasty dishes!</h5>
    </div>
    <hr class=""border border-3 border-dark rounded-3 col-10"">
    <div>
        <table class=""table table-striped table-hover table-bordered border border-3 border-dark"">
            <thead class=""table-secondary"">
                <tr");
            BeginWriteAttribute("class", " class=\"", 710, "\"", 718, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <th class=\"col-5\">Name</th>\r\n                    <th class=\"col-3\">Chef</th>\r\n                    <th class=\"col-2\">Tastiness</th>\r\n                    <th class=\"col-2\">Calories</th>\r\n                </tr>\r\n            </thead>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
              
                foreach (Dish d in ViewBag.allDishes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                       Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                       Write(d.Chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                                         Write(d.Chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                       Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                       Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Aluni\Downloads\coding_dojo\c#\wk2\d5\chefs_n_dishes\Views\Home\Dishes.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591