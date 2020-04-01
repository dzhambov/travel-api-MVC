#pragma checksum "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ffec3b607111a3e825bee19794b5b38840b02c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_Index), @"mvc.1.0.view", @"/Views/Destination/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Destination/Index.cshtml", typeof(AspNetCore.Views_Destination_Index))]
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
#line 1 "C:\Users\dzham\desktop\travel-api-MVC\Views\_ViewImports.cshtml"
using TravelApiMVC;

#line default
#line hidden
#line 5 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
using TravelApiMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffec3b607111a3e825bee19794b5b38840b02c7", @"/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af2089794ecb5b00b701b89af240e4c0485f77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelApiMVC.Models.Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 28, true);
            WriteLiteral("\r\n<h1>Destinations!</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(164, 49, true);
            WriteLiteral("  <h3>No destinations have been added yet!</h3>\r\n");
            EndContext();
#line 13 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
 foreach (Destination destination in Model)
{

#line default
#line hidden
            BeginContext(267, 25, true);
            WriteLiteral("  <ul>\r\n    <li>Country: ");
            EndContext();
            BeginContext(293, 19, false);
#line 18 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
            Write(destination.Country);

#line default
#line hidden
            EndContext();
            BeginContext(312, 21, true);
            WriteLiteral("</li>\r\n    <li>City: ");
            EndContext();
            BeginContext(334, 89, false);
#line 19 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
         Write(Html.ActionLink($"{destination.City}", "Details", new { id = destination.DestinationId }));

#line default
#line hidden
            EndContext();
            BeginContext(423, 23, true);
            WriteLiteral("</li>\r\n    <li>Rating: ");
            EndContext();
            BeginContext(447, 18, false);
#line 20 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
           Write(destination.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(465, 16, true);
            WriteLiteral("</li>\r\n  </ul>\r\n");
            EndContext();
#line 22 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
}

#line default
#line hidden
            BeginContext(484, 46, true);
            WriteLiteral("\r\n <button class=\"btn btn-outline-success\"><p>");
            EndContext();
            BeginContext(531, 66, false);
#line 24 "C:\Users\dzham\desktop\travel-api-MVC\Views\Destination\Index.cshtml"
                                       Write(Html.ActionLink("➕Add a new destination", "Create", "Destination"));

#line default
#line hidden
            EndContext();
            BeginContext(597, 13, true);
            WriteLiteral("</p></button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelApiMVC.Models.Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
