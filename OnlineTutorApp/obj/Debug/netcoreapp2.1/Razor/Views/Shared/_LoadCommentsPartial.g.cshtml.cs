#pragma checksum "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5b5009f3ff42dfbf8e6b859515f70b4cd3d201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadCommentsPartial), @"mvc.1.0.view", @"/Views/Shared/_LoadCommentsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadCommentsPartial.cshtml", typeof(AspNetCore.Views_Shared__LoadCommentsPartial))]
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
#line 1 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5b5009f3ff42dfbf8e6b859515f70b4cd3d201", @"/Views/Shared/_LoadCommentsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadCommentsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayingVideoVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
 foreach (var comment in Model.Comments)
{

#line default
#line hidden
            BeginContext(70, 77, true);
            WriteLiteral("    <div class=\"users-comment\">\r\n        <div class=\"username\">\r\n            ");
            EndContext();
            BeginContext(148, 20, false);
#line 7 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
       Write(comment.AppUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(168, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(170, 23, false);
#line 7 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
                             Write(comment.AppUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(193, 41, true);
            WriteLiteral("\r\n            <span class=\"comment-date\">");
            EndContext();
            BeginContext(235, 19, false);
#line 8 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
                                  Write(comment.CommentDate);

#line default
#line hidden
            EndContext();
            BeginContext(254, 77, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <span class=\"comment-content\">\r\n            ");
            EndContext();
            BeginContext(332, 19, false);
#line 11 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
       Write(comment.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(351, 31, true);
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\Admin\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadCommentsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayingVideoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591