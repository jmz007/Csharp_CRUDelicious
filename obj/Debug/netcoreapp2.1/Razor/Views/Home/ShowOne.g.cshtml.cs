#pragma checksum "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a6dd37a88d1687dda3a67e9954811affbaf1281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowOne), @"mvc.1.0.view", @"/Views/Home/ShowOne.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowOne.cshtml", typeof(AspNetCore.Views_Home_ShowOne))]
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
#line 1 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\_ViewImports.cshtml"
using Csharp_CRUDelicious;

#line default
#line hidden
#line 1 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
using Csharp_CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6dd37a88d1687dda3a67e9954811affbaf1281", @"/Views/Home/ShowOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0274729559a360c221af32b9769650c0930fd933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
  
    ViewData["Title"] = "View Dish";

#line default
#line hidden
            BeginContext(89, 66, true);
            WriteLiteral("<div class=\"container\">\n    <!-- <div class=\"header\">\n        <h1>");
            EndContext();
            BeginContext(156, 10, false);
#line 8 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(166, 18, true);
            WriteLiteral("</h1>\n        <h4>");
            EndContext();
            BeginContext(185, 10, false);
#line 9 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
       Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(195, 61, true);
            WriteLiteral("</h4>\n        <hr>\n    </div>\n    <div class=\"info\">\n\n    <p>");
            EndContext();
            BeginContext(257, 17, false);
#line 14 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(274, 22, true);
            WriteLiteral("</p>\n    <p>Calories: ");
            EndContext();
            BeginContext(297, 14, false);
#line 15 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
            Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(311, 23, true);
            WriteLiteral("</p>\n    <p>Tastiness: ");
            EndContext();
            BeginContext(335, 15, false);
#line 16 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
             Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(350, 24, true);
            WriteLiteral("</p>\n    </div>\n\n    <p>");
            EndContext();
            BeginContext(375, 26, false);
#line 19 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
  Write(Model.CreatedAt.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(401, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(414, 26, false);
#line 20 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
  Write(Model.UpdatedAt.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(440, 189, true);
            WriteLiteral("</p>\n    <button type=\"button\" class=\"btn btn-dark\"onclick=\"window.location.href=\'/\'\">Home</button> \n    \n    <button type=\"button\" class=\"btn btn-dark\"onclick=\"window.location.href=\'/edit/");
            EndContext();
            BeginContext(630, 12, false);
#line 23 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
                                                                              Write(Model.DishId);

#line default
#line hidden
            EndContext();
            BeginContext(642, 73, true);
            WriteLiteral("\'\">Edit</a> -->\n\n\n<div class=\"card\">\n  <div class=\"card-header\">\n    <h2>");
            EndContext();
            BeginContext(716, 10, false);
#line 28 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(726, 78, true);
            WriteLiteral("</h2>\n  </div>\n  <div class=\"card-body\">\n    <h5 class=\"card-title\">from chef ");
            EndContext();
            BeginContext(805, 10, false);
#line 31 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
                                Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(815, 31, true);
            WriteLiteral("</h5>\n    <p class=\"card-text\">");
            EndContext();
            BeginContext(847, 17, false);
#line 32 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
                    Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(864, 40, true);
            WriteLiteral("</p>\n    <p class=\"card-text\">Calories: ");
            EndContext();
            BeginContext(905, 14, false);
#line 33 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
                              Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(919, 12, true);
            WriteLiteral(" Tastiness: ");
            EndContext();
            BeginContext(932, 15, false);
#line 33 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
                                                         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(947, 61, true);
            WriteLiteral("</p>\n\n    <a href=\"/\" class=\"btn btn-primary\">Home</a>\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1034, 2);
            WriteAttributeValue("", 1015, "/edit/", 1015, 6, true);
#line 36 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
WriteAttributeValue("", 1021, Model.DishId, 1021, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1035, 40, true);
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1075, "\"", 1103, 2);
            WriteAttributeValue("", 1082, "/Delete/", 1082, 8, true);
#line 37 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\ShowOne.cshtml"
WriteAttributeValue("", 1090, Model.DishId, 1090, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 136, true);
            WriteLiteral(" class=\"btn btn-primary\">Delete</a>\n  </div>\n</div>\n\n\n<!-- <button type=\"button\" class=\"btn btn-dark\"onclick=\"window.location.href=\' -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
