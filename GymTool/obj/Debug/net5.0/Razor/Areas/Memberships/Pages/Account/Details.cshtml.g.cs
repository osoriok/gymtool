#pragma checksum "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08ddd7abf53f1ba04c9ad4e73b4af76266ef7efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Memberships_Pages_Account_Details), @"mvc.1.0.razor-page", @"/Areas/Memberships/Pages/Account/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\_ViewImports.cshtml"
using GymTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\_ViewImports.cshtml"
using GymTool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\_ViewImports.cshtml"
using GymTool.Areas.Memberships.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Membresia/Informacion")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ddd7abf53f1ba04c9ad4e73b4af76266ef7efa", @"/Areas/Memberships/Pages/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53c6a31bffceae7df31d54c03c7a2ed152e28b3", @"/Areas/Memberships/Pages/_ViewImports.cshtml")]
    public class Areas_Memberships_Pages_Account_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Atr&aacute;s"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Memberships", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Memberships", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Memberships", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
  
    String roleAdmin = "Administrador";
    if (Model.Input.DataMembership != null)
    {
        var name = Model.Input.DataMembership.Nombre;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container p-4\" style=\"min-width: 320px\">\r\n\r\n            <h1>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ddd7abf53f1ba04c9ad4e73b4af76266ef7efa6684", async() => {
                WriteLiteral("Atr&aacute;s");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
           Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h1>
            <div class=""row"">
                <div class=""col"" style=""min-width: 300px"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h2>Informaci&oacute;n</h2>


                            <table class=""tableCursos"">
                                <tbody>
                                    <tr>
                                        <th>
                                            Nombre
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p>");
#nullable restore
#line 31 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                          Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th>
                                            Descripci&oacute;n
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p>");
#nullable restore
#line 41 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                          Write(Model.Input.DataMembership.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </td>
                                    </tr>

                                    <tr>
                                        <th>
                                            Clientes asociados
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
");
#nullable restore
#line 52 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                             if (!Model.Input.DataMembership.CantidadClientes.Equals(0))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"text-success\">");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                                               Write(Model.Input.DataMembership.CantidadClientes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 55 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">\r\n                                            ");
#nullable restore
#line 59 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                       Write(Model.Input.DataMembership.CantidadClientes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </td>
                                    </tr>

                                   


                                    <tr>
                                        <th>
                                            Periodo
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p>");
#nullable restore
#line 75 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                          Write(Model.Input.DataMembership.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                                                               Write(Model.Input.DataMembership.Periodo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th>
                                            Monto
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p>");
#nullable restore
#line 85 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                          Write(Model.Input.DataMembership.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </td>
                                    </tr>

                                </tbody>
                            </table>
                            <div class=""col text-right"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ddd7abf53f1ba04c9ad4e73b4af76266ef7efa14824", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                      
                                        var dataMembership = JsonConvert.SerializeObject(Model.Input.DataMembership);
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"hidden\" name=\"accMembresia\" id=\"accMembresia\" value=\"false\" />\r\n                                    <input type=\"hidden\" name=\"DataMembership\"");
                BeginWriteAttribute("value", " value=\"", 4601, "\"", 4624, 1);
#nullable restore
#line 98 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
WriteAttributeValue("", 4609, dataMembership, 4609, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 99 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                     if (User.IsInRole(roleAdmin))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"submit\" name=\"accion\" title=\"Eliminar\" value=\"Eliminar\" class=\"btn btn-danger text-white\" onclick=\"javascript: confirmar(\'Eliminar\',\'Membresia\')\">\r\n");
#nullable restore
#line 102 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"submit\" name=\"accion\" title=\"Editar\" value=\"  Editar  \" class=\"btn btn-success \">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label class=\"text-danger\">");
#nullable restore
#line 107 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
                                                      Write(Model.Input.DataMembership.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div><!--<div  class=\"form-group\">-->\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 117 "C:\Users\Usuario\source\repos\GymTool\GymTool\Areas\Memberships\Pages\Account\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel>)PageContext?.ViewData;
        public DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
