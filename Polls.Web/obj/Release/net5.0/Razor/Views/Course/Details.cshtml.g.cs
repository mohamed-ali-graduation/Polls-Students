#pragma checksum "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3813e7ee2aad757589537e8cae9cd94c2d699c987a6dbb1e12b83cabdbd8c02c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\_ViewImports.cshtml"
using Polls.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
using Polls.Domain.ViewModel.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3813e7ee2aad757589537e8cae9cd94c2d699c987a6dbb1e12b83cabdbd8c02c", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9d53f53c9feea446876f93f5d825edaa3f77113707f00cbc425c09e010d5128d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPollQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: \'Times New Roman\', Times, serif;font-weight: bold;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
  
    ViewData["Title"] = "Course Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">
        <h2 style=""font-family: 'Times New Roman', Times, serif;"">Course Details</h2>
    </div>
</section>

<section id=""portfolio-details"" class=""portfolio-details"">
    <div class=""container"">
        <div class=""row gy-4"">
            <div class=""col-lg-4"">
                <div class=""portfolio-info"">
                    <ul style=""font-size:125%;font-family: 'Times New Roman', Times, serif;"">
                        <li><strong>Title</strong>: ");
#nullable restore
#line 21 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Sections</strong>: ");
#nullable restore
#line 22 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                                  Write(Model.SessionsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Views</strong>: ");
#nullable restore
#line 23 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                               Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <hr />\r\n                    <h4 style=\"font-family: \'Times New Roman\', Times, serif;\">Departments:</h4>\r\n                    <ul style=\"line-height:80%\">\r\n");
#nullable restore
#line 28 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                         foreach(var department in Model.Departments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>- ");
#nullable restore
#line 30 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                             Write(department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 33 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                     if(Model.Poll)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3813e7ee2aad757589537e8cae9cd94c2d699c987a6dbb1e12b83cabdbd8c02c7764", async() => {
                WriteLiteral("\r\n                        Go To Poll");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""portfolio-info"">
                    <div class=""swiper-wrapper align-items-center"">
                        <div>
                            <div style=""width:max-content"">
                                <h3 style=""font-family: 'Times New Roman', Times, serif;"">Description</h3>
                            </div>
                            <p>");
#nullable restore
#line 48 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                <div class=\"swiper-pagination\"></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
             if (Model.Sessions.Count() != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-12"">
                    <div class=""portfolio-info"">
                        <div style=""width:max-content"">
                            <h3 style=""font-family: 'Times New Roman', Times, serif;"">Sessions</h3>
                        </div>
                        <div class=""container"" data-aos=""fade-up"">
                            <div class=""col-12"" style=""margin-left:auto;margin-right:auto"">
");
#nullable restore
#line 63 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                 foreach (var item in Model.Sessions)
                                {
                                    string ModalId = "#" + "modid" + item.Id.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-3 d-inline\">\r\n                                        <button class=\"session-button\"data-bs-toggle=\"modal\" data-bs-target=\"");
#nullable restore
#line 67 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                                                                                        Write(ModalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <h4>");
#nullable restore
#line 68 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        </button>\r\n                                    </div>\r\n");
#nullable restore
#line 71 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                }                             

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>   \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 76 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
#nullable restore
#line 81 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
 foreach (var item in Model.Sessions)
{
    string ModalId = "modid" + item.Id.ToString();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 3670, "\"", 3683, 1);
#nullable restore
#line 85 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 3675, ModalId, 3675, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel1"">");
#nullable restore
#line 89 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - Descriptions</h5>
                    <button
                        type=""button""
                        class=""btn-close""
                        data-bs-dismiss=""modal""
                        aria-label=""Close""
                    ></button>
                </div>
                <div class=""modal-body"">
                    <p>");
#nullable restore
#line 98 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-secondary"" data-bs-dismiss=""modal"">
                        Close
                    </button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 108 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Course\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
