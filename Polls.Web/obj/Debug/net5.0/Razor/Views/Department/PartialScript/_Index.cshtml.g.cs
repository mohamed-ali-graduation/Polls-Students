#pragma checksum "E:\Projects\Graduation Project\Polls-Students-\Polls.Web\Views\Department\PartialScript\_Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2807da038d77c04dc869549678ffb8e8915d9accf31344faa5460d4b8f00dd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_PartialScript__Index), @"mvc.1.0.view", @"/Views/Department/PartialScript/_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2807da038d77c04dc869549678ffb8e8915d9accf31344faa5460d4b8f00dd52", @"/Views/Department/PartialScript/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9d53f53c9feea446876f93f5d825edaa3f77113707f00cbc425c09e010d5128d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_PartialScript__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    $("".editbtn"").click(function() {
        var id = $(this).data(""id"");
        var textId = ""#"" + $(this).data(""textid"");
        var div = ""#"" + $(this).data(""div"");
        var nameId = ""#"" + $(this).data(""newname"");

        $.ajax({
            url: '/api/Department/' + id + ""/"" + $(nameId).val(),
            type: 'put',
            data: { newName: $(nameId).val() },
            success: function() {
                $(textId).empty();
                $(textId).html($(nameId).val());
                toastr.success(""Update Successfully"", ""Success"");
            },
            error: function() { 
                toastr.error(""Update failed"", ""Failed"");
            }
        });
    });

    $("".deletebtn"").click(function() {
        var id = $(this).data(""id"");
        var rowid = ""#"" + $(this).data(""row"");

        bootbox.confirm({
            message: ""Are you sure you want to Delete this Department?"",
            buttons: {
                confirm: {
         ");
            WriteLiteral(@"           label: 'Yes',
                    className: 'btn-danger'
                },
                cancel: {
                    label: 'No',
                    className: 'btn-success'
                }
            },
            callback: function (result) {
                if (result) { 
                    $.ajax({
                        url: '/api/Department/' + id,
                        type: 'delete',
                        success: function() { 
                            $(rowid).fadeOut(500);
                            toastr.success(""Delete Successfully"", ""Success"");
                        },
                        error: function() {
                            toastr.error(""Delete Failed"", ""Error"");
                        }
                    });
                }
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591