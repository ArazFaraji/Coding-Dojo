#pragma checksum "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9873567578d14e80848531f7acdbf044251ae582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes;

#line default
#line hidden
#line 2 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873567578d14e80848531f7acdbf044251ae582", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e01085002f792202768963d7d0c07b88e1c684e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
  
    ViewData["Title"] = "Dishes";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(47, 17, false);
#line 4 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 305, true);
            WriteLiteral(@"</h1>

<a href=""/NewDish"">Add a Dish</a>
<h1>Yum, take a look at our tasty dishes!</h1>

<div class=""col-sm-6"">
    <table class=""table table-striped"">
        <tr>
            <th>Name</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
        </tr>
");
            EndContext();
#line 17 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
         foreach(var l in ViewBag.AllDishes)
        {

#line default
#line hidden
            BeginContext(426, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(465, 6, false);
#line 20 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
               Write(l.Name);

#line default
#line hidden
            EndContext();
            BeginContext(471, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(500, 19, false);
#line 21 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
               Write(l.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(519, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(521, 18, false);
#line 21 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                    Write(l.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(539, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(567, 11, false);
#line 22 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
               Write(l.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(578, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(606, 10, false);
#line 23 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
               Write(l.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(616, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/ChefsAndDishes/Views/Home/Dishes.cshtml"
        }

#line default
#line hidden
            BeginContext(653, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
