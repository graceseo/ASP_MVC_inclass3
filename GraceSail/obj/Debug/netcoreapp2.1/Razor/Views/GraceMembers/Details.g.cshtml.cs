#pragma checksum "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a21397b05d5d8a9b1cd7e0fca2f513f80b6ce04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GraceMembers_Details), @"mvc.1.0.view", @"/Views/GraceMembers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GraceMembers/Details.cshtml", typeof(AspNetCore.Views_GraceMembers_Details))]
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
#line 1 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\_ViewImports.cshtml"
using GraceSail;

#line default
#line hidden
#line 2 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\_ViewImports.cshtml"
using GraceSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a21397b05d5d8a9b1cd7e0fca2f513f80b6ce04", @"/Views/GraceMembers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"641ed1f369805c204c41c5d516e722018c7af22a", @"/Views/_ViewImports.cshtml")]
    public class Views_GraceMembers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraceSail.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(75, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d3c7fdddc74d3dbdda56031f9888eb", async() => {
                BeginContext(81, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 3068, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0547cd2b4641479eba27c77d6581de6d", async() => {
                BeginContext(185, 102, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(288, 44, false);
#line 21 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
                EndContext();
                BeginContext(332, 99, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <!--Link to Memebership View --Grace -->\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 431, "\"", 543, 1);
#line 25 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
WriteAttributeValue("", 438, Url.Action("Index", "GraceMemberShips", new {Memberid=Model.MemberId ,memberFullName = Model.FullName }), 438, 105, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(544, 15, true);
                WriteLiteral(">\r\n            ");
                EndContext();
                BeginContext(560, 40, false);
#line 26 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
                EndContext();
                BeginContext(600, 39, true);
                WriteLiteral("</a>\r\n</dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(640, 45, false);
#line 29 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(685, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(729, 41, false);
#line 32 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(770, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(814, 44, false);
#line 35 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(858, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(902, 40, false);
#line 38 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(942, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(986, 51, false);
#line 41 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseFirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1037, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1081, 47, false);
#line 44 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpouseFirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1128, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1172, 50, false);
#line 47 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseLastName));

#line default
#line hidden
                EndContext();
                BeginContext(1222, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1266, 46, false);
#line 50 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpouseLastName));

#line default
#line hidden
                EndContext();
                BeginContext(1312, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1356, 42, false);
#line 53 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
                EndContext();
                BeginContext(1398, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1442, 38, false);
#line 56 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
                EndContext();
                BeginContext(1480, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1524, 40, false);
#line 59 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
                EndContext();
                BeginContext(1564, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1608, 36, false);
#line 62 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
                EndContext();
                BeginContext(1644, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1688, 46, false);
#line 65 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
                EndContext();
                BeginContext(1734, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1778, 42, false);
#line 68 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
                EndContext();
                BeginContext(1820, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1864, 45, false);
#line 71 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
                EndContext();
                BeginContext(1909, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1953, 41, false);
#line 74 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
                EndContext();
                BeginContext(1994, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2038, 41, false);
#line 77 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2079, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2123, 37, false);
#line 80 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2160, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2204, 46, false);
#line 83 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearJoined));

#line default
#line hidden
                EndContext();
                BeginContext(2250, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2294, 42, false);
#line 86 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearJoined));

#line default
#line hidden
                EndContext();
                BeginContext(2336, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2380, 43, false);
#line 89 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
                EndContext();
                BeginContext(2423, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2467, 39, false);
#line 92 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
                EndContext();
                BeginContext(2506, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2550, 46, false);
#line 95 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExempt));

#line default
#line hidden
                EndContext();
                BeginContext(2596, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2640, 42, false);
#line 98 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskExempt));

#line default
#line hidden
                EndContext();
                BeginContext(2682, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2726, 49, false);
#line 101 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UseCanadaPost));

#line default
#line hidden
                EndContext();
                BeginContext(2775, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2819, 45, false);
#line 104 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UseCanadaPost));

#line default
#line hidden
                EndContext();
                BeginContext(2864, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2908, 58, false);
#line 107 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(2966, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3010, 67, false);
#line 110 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
                EndContext();
                BeginContext(3077, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(3124, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e9dd3b016d422b9df5f9f2c19b6beb", async() => {
                    BeginContext(3176, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 115 "C:\SCHOOL\GitHub\ASP_MVC_ClassAssingmnet\GraceSail\Views\GraceMembers\Details.cshtml"
                           WriteLiteral(Model.MemberId);

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
                BeginContext(3184, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(3192, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16dc7d2235374962833749dc25673b57", async() => {
                    BeginContext(3214, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3230, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3247, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraceSail.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591