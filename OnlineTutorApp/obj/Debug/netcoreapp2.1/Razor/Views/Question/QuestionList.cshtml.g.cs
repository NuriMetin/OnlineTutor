#pragma checksum "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212657852b3e63e2049d39b750edcc712282b8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_QuestionList), @"mvc.1.0.view", @"/Views/Question/QuestionList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/QuestionList.cshtml", typeof(AspNetCore.Views_Question_QuestionList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212657852b3e63e2049d39b750edcc712282b8a7", @"/Views/Question/QuestionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e37400414b5f1efb3e9448b8f36e92c5c9af4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_QuestionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ControlTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-bottom:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
  
    ViewData["Title"] = "Questions";

#line default
#line hidden
            BeginContext(71, 234, true);
            WriteLiteral("<div class=\"co-md-12 pb-3\" style=\"text-align:center;\">\r\n    <h2>Suallar</h2>\r\n</div>\r\n<div class=\"main-container \" style=\"padding-left:40%; padding-bottom:30px;\">\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(305, 1192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be91377f521d4a7c93d927a1f8ceaeda", async() => {
                BeginContext(403, 38, true);
                WriteLiteral("\r\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 441, "\"", 462, 1);
#line 13 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
WriteAttributeValue("", 449, Model.QuizId, 449, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(463, 80, true);
                WriteLiteral(" name=\"qiuzId\" />\r\n                <ol class=\"answers-question-list\" type=\"1\">\r\n");
                EndContext();
#line 15 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                     foreach (var question in Model.Questions)
                    {

#line default
#line hidden
                BeginContext(630, 109, true);
                WriteLiteral("                        <li style=\"list-style-type:decimal; font-weight:bold;\">\r\n                            ");
                EndContext();
                BeginContext(740, 16, false);
#line 18 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                       Write(question.Content);

#line default
#line hidden
                EndContext();
                BeginContext(756, 38, true);
                WriteLiteral("<input type=\"hidden\" name=\"questionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 794, "\"", 814, 1);
#line 18 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
WriteAttributeValue("", 802, question.ID, 802, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(815, 108, true);
                WriteLiteral(" />\r\n                            <ol type=\"A\" style=\"margin-left:0 !important; padding-left:0 !important\">\r\n");
                EndContext();
#line 20 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                                 foreach (var answer in question.Answers)
                                {

#line default
#line hidden
                BeginContext(1033, 117, true);
                WriteLiteral("                                    <li style=\"list-style-type:upper-latin; font-weight:lighter;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1150, "\"", 1178, 2);
                WriteAttributeValue("", 1157, "question_", 1157, 9, true);
#line 22 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
WriteAttributeValue("", 1166, question.ID, 1166, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1179, "\"", 1197, 1);
#line 22 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
WriteAttributeValue("", 1187, answer.ID, 1187, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1198, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(1203, 14, false);
#line 22 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                                                                                                                                                                    Write(answer.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1217, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 23 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                                }

#line default
#line hidden
                BeginContext(1259, 66, true);
                WriteLiteral("                            </ol>\r\n                        </li>\r\n");
                EndContext();
#line 26 "C:\Users\Hewlett-Packard\Desktop\OnlineTutor\OnlineTutorApp\Views\Question\QuestionList.cshtml"
                    }

#line default
#line hidden
                BeginContext(1348, 142, true);
                WriteLiteral("                </ol>\r\n                <input style=\"margin-left:20%;\" type=\"submit\" value=\"Təstiqlə\" class=\"btn btn-success\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1497, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591