#pragma checksum "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ba72431c00e42ae42c9102627e5a86c006b085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_SingleCourse), @"mvc.1.0.view", @"/Views/Course/SingleCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/SingleCourse.cshtml", typeof(AspNetCore.Views_Course_SingleCourse))]
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
#line 1 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp;

#line default
#line hidden
#line 2 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.Models;

#line default
#line hidden
#line 3 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\_ViewImports.cshtml"
using OnlineTutorApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ba72431c00e42ae42c9102627e5a86c006b085", @"/Views/Course/SingleCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_SingleCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/owl-carousel/assets/owl.carousel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/owl-carousel/assets/owl.theme.default.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/single-course.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("author photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewCount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/owl-carousel/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
  
    ViewData["Title"] = "SingleCourse";

#line default
#line hidden
            BeginContext(65, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05673612e5e049c194d166edbc549003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(142, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a71d9d0c1b314aaf9694bf15849ebda7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c1a2f687c114d988a06da13f7b26373", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(278, 148, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"left-container col-lg-3\">\r\n            <ul>\r\n                <li>Video<span>");
            EndContext();
            BeginContext(427, 69, false);
#line 13 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                          Write(Model.Course.Videos.Where(x => x.CourseId == Model.Course.ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(496, 57, true);
            WriteLiteral("</span></li>\r\n                <li>Didaktik material<span>");
            EndContext();
            BeginContext(554, 80, false);
#line 14 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                      Write(Model.Course.DidacticMaterials.Where(x => x.CourseId == Model.Course.ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(634, 48, true);
            WriteLiteral("</span></li>\r\n                <li>Sillabus<span>");
            EndContext();
            BeginContext(683, 71, false);
#line 15 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                             Write(Model.Course.Sillabus.Where(x => x.CourseId == Model.Course.ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(754, 44, true);
            WriteLiteral("</span></li>\r\n                <li>Kuiz<span>");
            EndContext();
            BeginContext(799, 70, false);
#line 16 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                         Write(Model.Course.Quizzes.Where(x => x.CourseId == Model.Course.ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(869, 189, true);
            WriteLiteral("</span></li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"right-container col-lg-9\">\r\n            <div class=\"header\">\r\n                <div class=\"author\">\r\n                    ");
            EndContext();
            BeginContext(1058, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a88b06d20a5b4c05991ca76950aca66a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1068, "~/images/profilePhotos/", 1068, 23, true);
#line 22 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
AddHtmlAttributeValue("", 1091, Model.CourseUser.AppUser.Image, 1091, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1143, 28, true);
            WriteLiteral("\r\n                    <span>");
            EndContext();
            BeginContext(1172, 29, false);
#line 23 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                     Write(Model.CourseUser.AppUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1203, 32, false);
#line 23 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                                    Write(Model.CourseUser.AppUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1235, 165, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"category\">\r\n                    <span>Kateqoriya:</span><span style=\"color: #333333; font-weight: 600;\">");
            EndContext();
            BeginContext(1401, 26, false);
#line 26 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                                                                       Write(Model.Course.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 202, true);
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <p class=\"course-title\">The most impressive is collection of share me online college courses</p>\r\n            <span class=\"course-price\">");
            EndContext();
            BeginContext(1630, 19, false);
#line 30 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                  Write(Model.Course.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1649, 65, true);
            WriteLiteral("</span>\r\n            <div class=\"course-image\">\r\n                ");
            EndContext();
            BeginContext(1714, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01bcefee5d1f4b0493c29313ff0490de", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1724, "~/images/courses/", 1724, 17, true);
#line 32 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
AddHtmlAttributeValue("", 1741, Model.Course.Image, 1741, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1769, 4370, true);
            WriteLiteral(@"
            </div>
            <div class=""course-tab-content"">
                <ul id=""tab-content-nav"" onclick=""tabContentClick.call(this)"" class=""tab-content-nav"">
                    <li class=""selected""><span>Didaktik Material</span></li>
                    <li class=""""><span>Sillabus</span></li>
                    <li class=""""><span>Kuiz</span></li>
                </ul>
                <ul id=""tab-content"" class=""tab-content"">
                    <li class="""">
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-titl");
            WriteLiteral(@"e"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                    </li>
                    <li class=""active-content"">
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                    ");
            WriteLiteral(@"        </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                    </li>
                    <li class="""">
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=");
            WriteLiteral(@"""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                        <div class=""file"">
                            <i class=""far fa-file-alt""></i>
                            <span class=""file-title"">
                                yyy urb fgyu erge bg eugb eg bg hvn hgirb ghirhb hgiour hg
                                irr gh ghr r egbg gu uvrb bhv
                            </span>
                        </div>
                 ");
            WriteLiteral(@"   </li>
                </ul>
            </div>
        </div>
        <div class=""col-md-12 pt-5"" style=""text-align:center;"">
            <h3>Videolar</h3>
        </div>
        <div class=""owl-carousel owl-theme"" style=""display:block; padding:25px 0 50px 0; "">
");
            EndContext();
#line 117 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
             foreach (var video in Model.Videos)
            {

#line default
#line hidden
            BeginContext(6204, 55, true);
            WriteLiteral("                <div class=\"img\">\r\n                    ");
            EndContext();
            BeginContext(6259, 865, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f644f56e74284ac3aae2f36f56b858e6", async() => {
                BeginContext(6350, 414, true);
                WriteLiteral(@"
                        <button style=""border:none; background-color:transparent; cursor:pointer;"" type=""submit"">
                            <div class=""card-caption"">
                                <div class=""card-style"">
                                    <video class=""video-secondary-video"" style=""height:175px; width:100%;"" autoPictureInPicture controlslist>
                                        ");
                EndContext();
                BeginContext(6764, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b397fc4635d4c5999d14ff254a59221", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6777, "~/videos/", 6777, 9, true);
#line 125 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
AddHtmlAttributeValue("", 6786, video.Path, 6786, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6816, 151, true);
                WriteLiteral("\r\n                                    </video>\r\n                                    <h5 style=\"padding-bottom:15px; font-size:1rem; font-weight:bold;\">");
                EndContext();
                BeginContext(6968, 11, false);
#line 127 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                                                                                  Write(video.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6979, 138, true);
                WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
                                                                                        WriteLiteral(video.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7124, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 133 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Course\SingleCourse.cshtml"
            }

#line default
#line hidden
            BeginContext(7165, 132, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.0/jquery.slim.min.js\"></script>\r\n");
            EndContext();
            BeginContext(7297, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b10eb46fc6fc446983c804d92668a176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7359, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7361, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757a2c2751054833a847c2ba21948d28", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
