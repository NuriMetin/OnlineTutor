#pragma checksum "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b491927e5140b9adb9fbe78887200aecab0f33b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlTest_UsersResults), @"mvc.1.0.view", @"/Views/ControlTest/UsersResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControlTest/UsersResults.cshtml", typeof(AspNetCore.Views_ControlTest_UsersResults))]
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
#line 1 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp;

#line default
#line hidden
#line 2 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b491927e5140b9adb9fbe78887200aecab0f33b", @"/Views/ControlTest/UsersResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlTest_UsersResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineTutorApp.ViewModels.ResultViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
  
    ViewData["Title"] = "UsersResults";

#line default
#line hidden
            BeginContext(113, 521, true);
            WriteLiteral(@"
<div class=""container-fluid pt-5"" style="" padding-bottom:40px;"">
    <div class=""container pb-4"" style=""text-align:center;"">
        <h2>Nəticələr</h2>
    </div>
    <table class=""table col-md-12"">
        <thead>
            <tr>
                <th>
                    İstifadəçi adı
                </th>
                <th>
                    Tarix
                </th>
                <th>
                    Nəticə
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 26 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(691, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(764, 13, false);
#line 30 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
                   Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(777, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(857, 9, false);
#line 33 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
                   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(866, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(946, 11, false);
#line 36 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
                   Write(item.Result);

#line default
#line hidden
            EndContext();
            BeginContext(957, 64, true);
            WriteLiteral(" doğru cavab\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\ControlTest\UsersResults.cshtml"
            }

#line default
#line hidden
            BeginContext(1036, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineTutorApp.ViewModels.ResultViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
