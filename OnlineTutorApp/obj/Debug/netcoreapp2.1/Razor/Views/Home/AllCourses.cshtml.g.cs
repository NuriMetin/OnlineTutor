#pragma checksum "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873c805ea97cb57f8d2649d318395f6dc182abfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCourses), @"mvc.1.0.view", @"/Views/Home/AllCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllCourses.cshtml", typeof(AspNetCore.Views_Home_AllCourses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873c805ea97cb57f8d2649d318395f6dc182abfc", @"/Views/Home/AllCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("...."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
  
    ViewData["Title"] = "AllCourses";

#line default
#line hidden
            BeginContext(61, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(65, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51fbf27bc4354355861dd8c35c1cddac", async() => {
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
            BeginContext(113, 440, true);
            WriteLiteral(@"
<div class=""courses pb-5"">
    <div class=""popular-course-header pt-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""head pb-3"">
                    <h3>Bütün kurslar</h3>
                </div>
            </div>
        </div>
    </div>
    <div class=""course-body"">
        <div class=""container"">
            <div class=""row"">
                <input type=""hidden"" id=""userId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 553, "\"", 576, 1);
#line 19 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
WriteAttributeValue("", 561, ViewBag.UserId, 561, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(577, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 20 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                 for (int i = 0; i < Model.Courses.Count(); i++)
                {

#line default
#line hidden
            BeginContext(667, 181, true);
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-12 col-md-6 col-lg-4 col-xl-4 mt-4\">\r\n                        <div class=\"card\">\r\n                            <span class=\"btn-eye\">");
            EndContext();
            BeginContext(848, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3ee58a60f8b4e9daa636d6bc10a5d3b", async() => {
                BeginContext(947, 29, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>Bax");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                                                         WriteLiteral(Model.Courses.ElementAt(i).ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 93, true);
            WriteLiteral("</span>\r\n                            <div class=\"narrow\"></div>\r\n                            ");
            EndContext();
            BeginContext(1073, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81f17b151fce4713bf7e7f2c0bb5a0cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1083, "~/images/courses/", 1083, 17, true);
#line 26 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
AddHtmlAttributeValue("", 1100, Model.Courses.ElementAt(i).Image, 1100, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1163, 53, true);
            WriteLiteral("\r\n                            <span class=\"category\">");
            EndContext();
            BeginContext(1217, 40, false);
#line 27 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                              Write(Model.Courses.ElementAt(i).Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 146, true);
            WriteLiteral("</span>\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\"><a href=\"single-course.html\">");
            EndContext();
            BeginContext(1404, 32, false);
#line 29 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                               Write(Model.Courses.ElementAt(i).Title);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 64, true);
            WriteLiteral("</a></h5>\r\n                                <p class=\"card-text\">");
            EndContext();
            BeginContext(1501, 34, false);
#line 30 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                Write(Model.Courses.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 128, true);
            WriteLiteral("</p>\r\n                                <div class=\"course-meta\">\r\n                                    <p class=\"course-author\">\r\n");
            EndContext();
#line 33 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                         for (int k = 0; k < Model.CourseUsers.Count(); k++)
                                        {
                                            

#line default
#line hidden
#line 35 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                             if (Model.CourseUsers.ElementAt(k).CourseId == Model.Courses.ElementAt(i).ID)
                                            {

#line default
#line hidden
            BeginContext(1971, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(2019, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18c341a6d9b843749d28366a8266c655", async() => {
                BeginContext(2113, 43, false);
#line 37 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                                                                                        Write(Model.CourseUsers.ElementAt(k).AppUser.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2156, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2158, 46, false);
#line 37 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                                                                                                                                     Write(Model.CourseUsers.ElementAt(k).AppUser.Surname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                                     WriteLiteral(Model.CourseUsers.ElementAt(k).AppUser.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                            }

#line default
#line hidden
#line 38 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(2300, 162, true);
            WriteLiteral("                                        <span>tərəfindən</span>\r\n                                    </p>\r\n                                    <p class=\"price\">€ ");
            EndContext();
            BeginContext(2463, 33, false);
#line 42 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                  Write(Model.Courses.ElementAt(i).Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2496, 216, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"post-meta\">\r\n                                    <ul>\r\n                                        <li><i class=\"fas fa-eye\"></i> ");
            EndContext();
            BeginContext(2713, 36, false);
#line 46 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                                  Write(Model.Courses.ElementAt(i).ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 13, true);
            WriteLiteral(" baxış</li>\r\n");
            EndContext();
#line 47 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                         if (User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
            BeginContext(2882, 70, true);
            WriteLiteral("                                            <li class=\"course-like\">\r\n");
            EndContext();
#line 50 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                   string heartStyle = "far";
                                                    

#line default
#line hidden
#line 51 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                     try
                                                    {
                                                        if (Model.Courses.ElementAt(i).LikeForCourses.Where(x => x.AppUserId == ViewBag.UserId).Select(x => x.Liked).FirstOrDefault() == true)
                                                        {
                                                            heartStyle = "fas";
                                                        }
                                                    }
                                                    catch { heartStyle = "far"; }

#line default
#line hidden
            BeginContext(3724, 50, true);
            WriteLiteral("                                                <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3774, "\"", 3802, 2);
#line 60 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
WriteAttributeValue("", 3782, heartStyle, 3782, 11, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3793, "fa-heart", 3794, 9, true);
            EndWriteAttribute();
            BeginContext(3803, 94, true);
            WriteLiteral("></i>\r\n\r\n                                                <input type=\"hidden\" class=\"courseId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3897, "\"", 3935, 1);
#line 62 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
WriteAttributeValue("", 3905, Model.Courses.ElementAt(i).ID, 3905, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3936, 60, true);
            WriteLiteral(" />\r\n                                                <span> ");
            EndContext();
            BeginContext(3997, 84, false);
#line 63 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                                  Write(Model.LikeForCourses.Where(x => x.CourseId == Model.Courses.ElementAt(i).ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(4081, 62, true);
            WriteLiteral("</span>\r\n\r\n                                            </li>\r\n");
            EndContext();
#line 66 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4186, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 67 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                         if (!User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
            BeginContext(4307, 98, true);
            WriteLiteral("                                            <li>\r\n                                                ");
            EndContext();
            BeginContext(4405, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95122beaaefb48079c2465111f64bbfa", async() => {
                BeginContext(4452, 29, true);
                WriteLiteral(" <i class=\"far fa-heart\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4485, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4536, 84, false);
#line 71 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                           Write(Model.LikeForCourses.Where(x => x.CourseId == Model.Courses.ElementAt(i).ID).Count());

#line default
#line hidden
            EndContext();
            BeginContext(4620, 53, true);
            WriteLiteral("\r\n                                            </li>\r\n");
            EndContext();
#line 73 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4716, 292, true);
            WriteLiteral(@"                                        <li class=""add-to-card""><i class=""fas fa-cart-plus""></i> Səbətə at</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 80 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Home\AllCourses.cshtml"
                }

#line default
#line hidden
            BeginContext(5027, 147, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(5174, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284b7f7ade574882b891d3302ee2fa30", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
