#pragma checksum "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5df588065281bad8f38facc8715551a656be663a92179546c6cd8c7c32d122ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssignFaculties_Index), @"mvc.1.0.view", @"/Views/AssignFaculties/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AssignFaculties/Index.cshtml", typeof(AspNetCore.Views_AssignFaculties_Index))]
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
#line 2 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\_ViewImports.cshtml"
using HeliaM_300824698.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5df588065281bad8f38facc8715551a656be663a92179546c6cd8c7c32d122ca", @"/Views/AssignFaculties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"93e6056854855c38562691374946ea83ba86292d530978df81d671130eda717b", @"/Views/_ViewImports.cshtml")]
    public class Views_AssignFaculties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HeliaM_300824698.Models.AssignFaculty>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 91, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<table id=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(151, 53, false);
#line 11 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Faculty.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(204, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 52, false);
#line 14 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Faculty.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(312, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(368, 53, false);
#line 17 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course.courseName));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 59, false);
#line 20 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course.courseDepartment));

#line default
#line hidden
            EndContext();
            BeginContext(536, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(654, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(703, 52, false);
#line 29 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Faculty.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(755, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(811, 51, false);
#line 32 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Faculty.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(862, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(918, 52, false);
#line 35 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Course.courseName));

#line default
#line hidden
            EndContext();
            BeginContext(970, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1026, 58, false);
#line 38 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Course.courseDepartment));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1139, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df588065281bad8f38facc8715551a656be663a92179546c6cd8c7c32d122ca8629", async() => {
                BeginContext(1189, 4, true);
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
#line 41 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
                                       WriteLiteral(item.classId);

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
            BeginContext(1197, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1217, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df588065281bad8f38facc8715551a656be663a92179546c6cd8c7c32d122ca11081", async() => {
                BeginContext(1269, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
                                         WriteLiteral(item.classId);

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
            BeginContext(1279, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\AssignFaculties\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1318, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HeliaM_300824698.Models.AssignFaculty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
