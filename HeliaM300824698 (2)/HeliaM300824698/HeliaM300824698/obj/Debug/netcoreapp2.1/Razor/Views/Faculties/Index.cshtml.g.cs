#pragma checksum "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6de060598ce44ad1c4108ffb36e87576bf3b18fc087f9f556a5830a9ad450f5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculties_Index), @"mvc.1.0.view", @"/Views/Faculties/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Faculties/Index.cshtml", typeof(AspNetCore.Views_Faculties_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6de060598ce44ad1c4108ffb36e87576bf3b18fc087f9f556a5830a9ad450f5b", @"/Views/Faculties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"93e6056854855c38562691374946ea83ba86292d530978df81d671130eda717b", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HeliaM_300824698.Models.Faculty>>
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
            BeginContext(53, 93, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n<table id=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(147, 45, false);
#line 12 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(192, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 44, false);
#line 15 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 46, false);
#line 18 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(394, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 41, false);
#line 21 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 39, false);
#line 24 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ext));

#line default
#line hidden
            EndContext();
            BeginContext(586, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(704, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(753, 44, false);
#line 33 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(853, 43, false);
#line 36 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(952, 45, false);
#line 39 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.department));

#line default
#line hidden
            EndContext();
            BeginContext(997, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1053, 40, false);
#line 42 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1149, 38, false);
#line 45 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ext));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1242, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de060598ce44ad1c4108ffb36e87576bf3b18fc087f9f556a5830a9ad450f5b9422", async() => {
                BeginContext(1294, 4, true);
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
#line 48 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
                                       WriteLiteral(item.facultyId);

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
            BeginContext(1302, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1322, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de060598ce44ad1c4108ffb36e87576bf3b18fc087f9f556a5830a9ad450f5b11870", async() => {
                BeginContext(1376, 6, true);
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
#line 49 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
                                         WriteLiteral(item.facultyId);

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
            BeginContext(1386, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Helia\OneDrive\Desktop\github\PrimeMinisters\FacultyManagment\HeliaM300824698 (2)\HeliaM300824698\HeliaM300824698\Views\Faculties\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1425, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HeliaM_300824698.Models.Faculty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
