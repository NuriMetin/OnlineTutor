#pragma checksum "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d67d490c1b7c87f8ef7f1314d5036cddd59d45d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_PlayingVideo), @"mvc.1.0.view", @"/Views/Video/PlayingVideo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Video/PlayingVideo.cshtml", typeof(AspNetCore.Views_Video_PlayingVideo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67d490c1b7c87f8ef7f1314d5036cddd59d45d0", @"/Views/Video/PlayingVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_PlayingVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayingVideoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/single-video.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("videoId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewCount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
  
    ViewData["Title"] = "PlayingVideo";

#line default
#line hidden
            BeginContext(71, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f9b86b93ee442c99876639f24a5618f", async() => {
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
            BeginContext(126, 321, true);
            WriteLiteral(@"
<div class=""main-container"" style=""height:1200px !important;"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""video-primary"">
                <div class=""video"">
                    <video id=""video-primary"" controls autoPictureInPicture controlslist>
                        ");
            EndContext();
            BeginContext(447, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68a8af07b9bf4e3f8ac6c9f9c5382690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 460, "~/videos/", 460, 9, true);
#line 12 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
AddHtmlAttributeValue("", 469, Model.Video.Path, 469, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(505, 105, true);
            WriteLiteral("\r\n                    </video>\r\n                    <div class=\"video-content\">\r\n                        ");
            EndContext();
            BeginContext(610, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec86230984f54cb6bcd268de8d3499cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 15 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Video.ID);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(672, 88, true);
            WriteLiteral("\r\n                        <h1 class=\"primary-video-title\">\r\n                            ");
            EndContext();
            BeginContext(761, 17, false);
#line 17 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                       Write(Model.Video.Title);

#line default
#line hidden
            EndContext();
            BeginContext(778, 198, true);
            WriteLiteral("\r\n                        </h1>\r\n                        <div class=\"left\">\r\n                            <span class=\"primary-video-views\">\r\n                                <span class=\"view_count\">");
            EndContext();
            BeginContext(977, 21, false);
#line 21 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                    Write(Model.Video.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(998, 108, true);
            WriteLiteral("</span><span> views - </span><span class=\"primary-video-publish-date\">\r\n                                    ");
            EndContext();
            BeginContext(1107, 23, false);
#line 22 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                               Write(Model.Video.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 301, true);
            WriteLiteral(@"
                                </span>
                            </span>
                        </div>
                        <div class=""right"" id=""rating"">
                            <button class=""like"" id=""btn_like"" style=""cursor:pointer; border:none; background-color:transparent;""><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1431, "\"", 1470, 2);
#line 27 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
WriteAttributeValue("", 1439, ViewBag.LikeStyle, 1439, 18, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1457, "fa-thumbs-up", 1458, 13, true);
            EndWriteAttribute();
            BeginContext(1471, 37, true);
            WriteLiteral("></i></button> <span id=\"like_Count\">");
            EndContext();
            BeginContext(1509, 56, false);
#line 27 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                                                                                                                                                                            Write(Model.LikesForVideos.Where(x => x.Liked == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1565, 148, true);
            WriteLiteral("</span>\r\n                            <button class=\"dislike\" id=\"btn_dislike\" style=\"cursor:pointer;  border:none; background-color:transparent;\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1713, "\"", 1757, 2);
#line 28 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
WriteAttributeValue("", 1721, ViewBag.DisLikeStyle, 1721, 21, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1742, "fa-thumbs-down", 1743, 15, true);
            EndWriteAttribute();
            BeginContext(1758, 40, true);
            WriteLiteral("></i></button> <span id=\"dislike_Count\">");
            EndContext();
            BeginContext(1799, 57, false);
#line 28 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                                                                                                                                                                                           Write(Model.LikesForVideos.Where(x => x.Liked == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1856, 132, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"comment\">\r\n");
            EndContext();
#line 33 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                       int commentCount = 0;
                        try { commentCount = Model.Comments.Count(); } catch { commentCount = 0; }
                    

#line default
#line hidden
            BeginContext(2157, 66, true);
            WriteLiteral("                    <span id=\"commentCount\" class=\"comment-count\">");
            EndContext();
            BeginContext(2224, 12, false);
#line 36 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                             Write(commentCount);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 38, true);
            WriteLiteral(" comments</span>\r\n                    ");
            EndContext();
            BeginContext(2274, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e69232cd9a34a69b3fcb9d52c8c01b5", async() => {
                BeginContext(2301, 250, true);
                WriteLiteral("\r\n                        <input class=\"comment-text\" id=\"commentText\" type=\"text\" placeholder=\"add comment...\">\r\n                        <input type=\"button\" class=\"btn btn-primary btn-comment\" id=\"btn_comment\" value=\"Comment\">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2558, 43, true);
            WriteLiteral("\r\n                    <div id=\"comments\">\r\n");
            EndContext();
#line 42 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                          
                            try
                            {
                                

#line default
#line hidden
#line 45 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                 foreach (var comment in Model.Comments)
                                {

#line default
#line hidden
            BeginContext(2802, 173, true);
            WriteLiteral("                                    <div class=\"users-comment\">\r\n                                        <div class=\"username\">\r\n                                            ");
            EndContext();
            BeginContext(2976, 20, false);
#line 49 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                       Write(comment.AppUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2996, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2998, 23, false);
#line 49 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                             Write(comment.AppUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3021, 73, true);
            WriteLiteral("\r\n                                            <span class=\"comment-date\">");
            EndContext();
            BeginContext(3095, 19, false);
#line 50 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                                  Write(comment.CommentDate);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 173, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <span class=\"comment-content\">\r\n                                            ");
            EndContext();
            BeginContext(3288, 19, false);
#line 53 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                       Write(comment.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(3307, 95, true);
            WriteLiteral("\r\n                                        </span>\r\n                                    </div>\r\n");
            EndContext();
#line 56 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                }

#line default
#line hidden
#line 56 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                 
                            }
                            catch
                            {

                            }
                        

#line default
#line hidden
            BeginContext(3594, 115, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"video-secondary\">\r\n");
            EndContext();
#line 67 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                 foreach (var video in Model.Videos)
                {

#line default
#line hidden
            BeginContext(3782, 69, true);
            WriteLiteral("                    <div class=\"secondary\">\r\n                        ");
            EndContext();
            BeginContext(3851, 851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f05fb89a8424fd496d7564f892c8f51", async() => {
                BeginContext(3942, 278, true);
                WriteLiteral(@"
                            <button id=""btn_video"" type=""submit"" style=""background:none; border:none; cursor:pointer; display:flex;"">
                                <video class=""video-secondary-video"" autoPictureInPicture controlslist>
                                    ");
                EndContext();
                BeginContext(4220, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3eafcc067d3e4792b2beddb0fd0abb05", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4233, "~/videos/", 4233, 9, true);
#line 73 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
AddHtmlAttributeValue("", 4242, video.Path, 4242, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4274, 185, true);
                WriteLiteral("\r\n                                </video>\r\n                                <div class=\"video-secondary-content\">\r\n                                    <h2 class=\"video-secondary-title\">");
                EndContext();
                BeginContext(4460, 11, false);
#line 76 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                                 Write(video.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4471, 90, true);
                WriteLiteral("</h2>\r\n                                    <span class=\"video-secondary-views view_count\">");
                EndContext();
                BeginContext(4562, 15, false);
#line 77 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                                                                              Write(video.ViewCount);

#line default
#line hidden
                EndContext();
                BeginContext(4577, 118, true);
                WriteLiteral(" views</span>\r\n                                </div>\r\n                            </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
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
            BeginContext(4702, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 82 "D:\OwnProjects\OnlineTutor\OnlineTutorApp\Views\Video\PlayingVideo.cshtml"
                }

#line default
#line hidden
            BeginContext(4751, 147, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(4898, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb3011d997d4219b177c85956637cd3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4935, 2, true);
            WriteLiteral("\r\n");
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
