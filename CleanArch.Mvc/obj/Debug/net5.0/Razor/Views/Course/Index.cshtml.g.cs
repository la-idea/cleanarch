#pragma checksum "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861a57988f41c363a8fe10c7d564fcbf0e168746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861a57988f41c363a8fe10c7d564fcbf0e168746", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad188cbe7dd57a8794ff436f3b6d4e994ac68bef", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CleanArch.Application.ViewModels.CourseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row course-content\">\r\n");
#nullable restore
#line 5 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
         foreach(var course in Model.Courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"course-img-container\">\r\n                    <div class=\"course-img\"");
            BeginWriteAttribute("style", " style=\"", 292, "\"", 336, 3);
            WriteAttributeValue("", 300, "background-image:url(", 300, 21, true);
#nullable restore
#line 8 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
WriteAttributeValue("", 321, course.ImgUrl, 321, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 335, ")", 335, 1, true);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                </div>\r\n");
            WriteLiteral("                <span>");
#nullable restore
#line 11 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
                 Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 12 "C:\Users\gabriell\Desktop\Internet Explorer\CleanArchitecture\CleanArch\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CleanArch.Application.ViewModels.CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
