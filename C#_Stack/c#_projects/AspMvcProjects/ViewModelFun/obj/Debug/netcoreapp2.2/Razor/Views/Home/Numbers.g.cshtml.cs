#pragma checksum "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/Home/Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e12c55c53e9ec361b0e9aa8dee0a8f96abf3089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Numbers.cshtml", typeof(AspNetCore.Views_Home_Numbers))]
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
#line 1 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/Home/Numbers.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e12c55c53e9ec361b0e9aa8dee0a8f96abf3089", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 33, true);
            WriteLiteral("\n<h1>Here are some numbers!</h1>\n");
            EndContext();
#line 5 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/Home/Numbers.cshtml"
 foreach (int num in Model)
{

#line default
#line hidden
            BeginContext(103, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(111, 3, false);
#line 7 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/Home/Numbers.cshtml"
  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(114, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 8 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/AspMvcProjects/ViewModelFun/Views/Home/Numbers.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
