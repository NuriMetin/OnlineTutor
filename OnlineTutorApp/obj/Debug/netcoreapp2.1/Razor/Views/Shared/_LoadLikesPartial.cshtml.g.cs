#pragma checksum "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadLikesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8056a37b4b82006026c78cfa30621846dbe56d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadLikesPartial), @"mvc.1.0.view", @"/Views/Shared/_LoadLikesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadLikesPartial.cshtml", typeof(AspNetCore.Views_Shared__LoadLikesPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8056a37b4b82006026c78cfa30621846dbe56d39", @"/Views/Shared/_LoadLikesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadLikesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayingVideoVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 104, true);
            WriteLiteral("<button class=\"like\" id=\"btn_like\" style=\"cursor:pointer; border:none; background-color:transparent;\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 127, "\"", 166, 2);
#line 2 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadLikesPartial.cshtml"
WriteAttributeValue("", 135, ViewBag.LikeStyle, 135, 18, false);

#line default
#line hidden
            WriteAttributeValue(" ", 153, "fa-thumbs-up", 154, 13, true);
            EndWriteAttribute();
            BeginContext(167, 37, true);
            WriteLiteral("></i></button> <span id=\"like_Count\">");
            EndContext();
            BeginContext(205, 56, false);
#line 2 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadLikesPartial.cshtml"
                                                                                                                                                                                Write(Model.LikesForVideos.Where(x => x.Liked == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(261, 120, true);
            WriteLiteral("</span>\r\n<button class=\"dislike\" id=\"btn_dislike\" style=\"cursor:pointer;  border:none; background-color:transparent;\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 381, "\"", 425, 2);
#line 3 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadLikesPartial.cshtml"
WriteAttributeValue("", 389, ViewBag.DisLikeStyle, 389, 21, false);

#line default
#line hidden
            WriteAttributeValue(" ", 410, "fa-thumbs-down", 411, 15, true);
            EndWriteAttribute();
            BeginContext(426, 40, true);
            WriteLiteral("></i></button> <span id=\"dislike_Count\">");
            EndContext();
            BeginContext(467, 57, false);
#line 3 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Shared\_LoadLikesPartial.cshtml"
                                                                                                                                                                                               Write(Model.LikesForVideos.Where(x => x.Liked == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(524, 7, true);
            WriteLiteral("</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayingVideoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
