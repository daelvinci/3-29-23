#pragma checksum "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab26b152421579a58f09bb3f993026290a7a82f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\_ViewImports.cshtml"
using _32923.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\_ViewImports.cshtml"
using _32923.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\_ViewImports.cshtml"
using _32923.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab26b152421579a58f09bb3f993026290a7a82f", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1786f01cbf77535bc9ce3fba0e3b289856d866", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StdGrp>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
  Layout=null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:red\" ; text-align:center\">Students: </h1>\r\n<ul>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
     foreach (var item in Model.Students)
    {
        string text = item.Point <= 65 ? "Mezun Olmadi" : $"Point: {item.Point}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
        Write($"ID: {item.Id} - {text} - Fullname: {item.FullName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h1 style=\"color:red\" ; text-align:center\">Groups: </h1>\r\n<ul>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
     foreach (var item in Model.Groups)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 19 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
        Write($"ID: {item.Id} -  Name: {item.Name}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\SONY\Desktop\backnew\32923\32923\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StdGrp> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591