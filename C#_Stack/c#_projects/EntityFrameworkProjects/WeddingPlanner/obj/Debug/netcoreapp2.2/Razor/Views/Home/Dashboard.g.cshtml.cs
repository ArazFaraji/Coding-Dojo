#pragma checksum "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e537b49c0dda7f45d615212ca309e021e335624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e537b49c0dda7f45d615212ca309e021e335624", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 125, true);
            WriteLiteral("<div class=\"row\">\n    <H1>Welcome to the Wedding Planner</H1>\n    <a href=\"/Logout\" style=\"float:right;\">Log Out</a>\n</div>\n\n");
            EndContext();
#line 6 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
  
    bool Attending = false;
    

#line default
#line hidden
            BeginContext(162, 201, true);
            WriteLiteral("\n<div class=\"col-sm-6\">\n    <table class=\"table table-striped\">\n        <tr>\n            <th>Wedding</th>\n            <th>Date</th>\n            <th>Guest</th>\n            <th>Action</th>\n        </tr>\n");
            EndContext();
#line 18 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
         foreach(var i in ViewBag.AllWeddings)
        {

#line default
#line hidden
            BeginContext(420, 39, true);
            WriteLiteral("            <tr>\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 459, "\"", 491, 2);
            WriteAttributeValue("", 466, "/WeddingInfo/", 466, 13, true);
#line 21 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 479, i.WeddingId, 479, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(492, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(494, 11, false);
#line 21 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                   Write(i.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(505, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(509, 11, false);
#line 21 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                  Write(i.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(520, 30, true);
            WriteLiteral("</a></td>\n                <td>");
            EndContext();
            BeginContext(551, 6, false);
#line 22 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
               Write(i.Date);

#line default
#line hidden
            EndContext();
            BeginContext(557, 27, true);
            WriteLiteral(" </td>\n                <td>");
            EndContext();
            BeginContext(585, 17, false);
#line 23 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
               Write(i.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(602, 28, true);
            WriteLiteral("</td>\n                <td> \n");
            EndContext();
#line 25 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                      
                        if(i.Creator.UserId == ViewBag.User.UserId)
                        {

#line default
#line hidden
            BeginContext(747, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 777, "\"", 803, 2);
            WriteAttributeValue("", 784, "delete/", 784, 7, true);
#line 28 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 791, i.WeddingId, 791, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 29 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#line 32 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                             foreach(var a in i.Attendees)
                            {
                                if(a.UserId == ViewBag.User.UserId)
                                {
                                    Attending = true;
                                }
                            }

#line default
#line hidden
#line 38 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                             
                            if(Attending == true)
                            {

#line default
#line hidden
            BeginContext(1286, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1320, "\"", 1347, 2);
            WriteAttributeValue("", 1327, "/UnRSVP/", 1327, 8, true);
#line 41 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1335, i.WeddingId, 1335, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 13, true);
            WriteLiteral(">Un-RSVP</a>\n");
            EndContext();
#line 42 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                Attending = false;
                            }
                            else if(Attending == false)
                            {

#line default
#line hidden
            BeginContext(1528, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1562, "\"", 1587, 2);
            WriteAttributeValue("", 1569, "/RSVP/", 1569, 6, true);
#line 46 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1575, i.WeddingId, 1575, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 10, true);
            WriteLiteral(">RSVP</a>\n");
            EndContext();
#line 47 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
                            }

                        }
                    

#line default
#line hidden
            BeginContext(1677, 41, true);
            WriteLiteral("                </td>\n\n            </tr>\n");
            EndContext();
#line 54 "/Users/araz/Documents/codingDojo/C#_Stack/c#_projects/EntityFrameworkProjects/WeddingPlanner/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1728, 85, true);
            WriteLiteral("    </table>\n</div>\n\n\n\n\n<a href=\"/NewWedding\" class=\"btn btn-primary\">New Wedding</a>");
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
