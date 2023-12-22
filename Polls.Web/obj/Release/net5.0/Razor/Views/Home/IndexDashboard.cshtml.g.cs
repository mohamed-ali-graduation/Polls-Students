#pragma checksum "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9a059698335c64bcd2f10689bdefa47a9189130fd7bdef2f9683a2c2d613ba60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexDashboard), @"mvc.1.0.view", @"/Views/Home/IndexDashboard.cshtml")]
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
#line 1 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
using Polls.Domain.ViewModel.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9a059698335c64bcd2f10689bdefa47a9189130fd7bdef2f9683a2c2d613ba60", @"/Views/Home/IndexDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9d53f53c9feea446876f93f5d825edaa3f77113707f00cbc425c09e010d5128d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_IndexDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardHomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialScripts/_DashboardHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-xxl flex-grow-1 container-p-y"">
        <div class=""row"">
            <div class=""col-lg-8 mb-4 order-0"">
                <div class=""card"">
                    <div class=""dropdown p-3 d-inline"" style=""float:right;width:max-content"">
");
#nullable restore
#line 14 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                          
                            var courseId = Model.Courses[0].Id;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button class=""btn btn-sm btn-outline-primary dropdown-toggle""
                                    type=""button""
                                    id=""growthReportId""
                                    data-bs-toggle=""dropdown""
                                    data-id=""");
#nullable restore
#line 20 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                        Write(courseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                    aria-haspopup=\"true\"\r\n                                    aria-expanded=\"false\">\r\n                                ");
#nullable restore
#line 23 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                           Write(Model.Courses[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n");
            WriteLiteral("           \r\n                        <div class=\"dropdown-menu dropdown-menu-end\" aria-labelledby=\"growthReportId\">\r\n");
#nullable restore
#line 29 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                             foreach(var item in Model.Courses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"dropdown-item down\" href=\"javascript:void(0);\" data-name=\"");
#nullable restore
#line 31 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 31 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 31 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 32 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div id=""can"">
                        <canvas class=""m-3"" id=""bar""></canvas>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 order-1"">
                <div class=""row"">
                    <div class=""card"">
                        <div class=""card-body p-3"">
                            <h3 class=""text-right"">All Polls Stats In ");
#nullable restore
#line 44 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <div id=""can2"">
                                <canvas class=""m-3 mb-5"" id=""pie""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-lg-6 col-xl-6 order-0 mb-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <ul class=""p-0 m-0"">
                            <li class=""d-flex mb-4 pb-1"">
                                <div class=""avatar flex-shrink-0 me-3"">
                                    <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                                </div>
                                <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                                    <div class=""me-2"">
                                        <h6 ");
            WriteLiteral("class=\"mb-0\">Courses</h6>\r\n                                    </div>\r\n                                    <div class=\"user-progress\">\r\n                                        <small class=\"fw-semibold\">");
#nullable restore
#line 67 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                              Write(Model.CoursesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </div>
                                </div>
                            </li>
                            <li class=""d-flex mb-4 pb-1"">
                                <div class=""avatar flex-shrink-0 me-3"">
                                    <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                                </div>
                                <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                                    <div class=""me-2"">
                                        <h6 class=""mb-0"">Sessions</h6>
                                    </div>
                                    <div class=""user-progress"">
                                        <small class=""fw-semibold"">");
#nullable restore
#line 80 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                              Write(Model.SessionsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </div>
                                </div>
                            </li>
                            <li class=""d-flex mb-4 pb-1"">
                                <div class=""avatar flex-shrink-0 me-3"">
                                    <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                                </div>
                                <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                                    <div class=""me-2"">
                                        <h6 class=""mb-0"">Instructors</h6>
                                    </div>
                                    <div class=""user-progress"">
                                        <small class=""fw-semibold"">");
#nullable restore
#line 93 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                              Write(Model.InstructorsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </div>
                                </div>
                            </li>
                            <li class=""d-flex mb-4 pb-1"" style=""margin-bottom: -5px;"">
                                <div class=""avatar flex-shrink-0 me-3"">
                                    <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                                </div>
                                <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                                    <div class=""me-2"">
                                        <h6 class=""mb-0"">Students Polls</h6>
                                    </div>
                                    <div class=""user-progress"">
                                        <small class=""fw-semibold"">");
#nullable restore
#line 106 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                              Write(Model.StudentsPollsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-6  order-2 mb-4"">
                <div class=""card"">
                    <div class=""card-header d-flex align-items-center justify-content-between"">
                        <h5 class=""card-title m-0 me-2"">Highest rating for coaches</h5>
                    </div>
                    <div class=""card-body"">
                        <ul class=""p-0 m-0"">
");
#nullable restore
#line 121 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                             foreach (var item in Model.Instructors)
                            {
                                string stringReview = new string(item.TotalReview.ToString().Take(3).ToArray());
                                string review = stringReview.Length < 3 ? stringReview + ".0" : stringReview;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"d-flex mb-4 pb-1\">\r\n                                    <div class=\"avatar flex-shrink-0 me-3\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 7034, "\"", 7104, 2);
            WriteAttributeValue("", 7040, "data:image/*;base64,", 7040, 20, true);
#nullable restore
#line 128 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
WriteAttributeValue("", 7060, Convert.ToBase64String(item.ProfilePicture), 7060, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""User"" class=""rounded"" />
                                    </div>
                                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                                        <div class=""me-2"">
                                            <small class=""text-muted d-block mb-1"">");
#nullable restore
#line 132 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                              Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            <h6 class=\"mb-0\">");
#nullable restore
#line 133 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                        Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 133 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                                        Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                        <div class=\"user-progress d-flex align-items-center gap-1\">\r\n                                            <h6 class=\"mb-0\">");
#nullable restore
#line 136 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                                                        Write(review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                            <span class=\"text-muted\">&starf;</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 141 "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Home\IndexDashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a059698335c64bcd2f10689bdefa47a9189130fd7bdef2f9683a2c2d613ba6017708", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardHomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591