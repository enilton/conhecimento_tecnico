#pragma checksum "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8648ec943ce80077b24169a2e7cb6fca76a6afe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profissionais_Details), @"mvc.1.0.view", @"/Views/Profissionais/Details.cshtml")]
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
#line 1 "C:\Users\enilton.junior\source\repos\IEL Application\Views\_ViewImports.cshtml"
using IEL_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enilton.junior\source\repos\IEL Application\Views\_ViewImports.cshtml"
using IEL_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
using IEL_Application.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8648ec943ce80077b24169a2e7cb6fca76a6afe8", @"/Views/Profissionais/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ac269b921502a78c43f2bbd4715a30c2cec5de", @"/Views/_ViewImports.cshtml")]
    public class Views_Profissionais_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEL_Application.Models.Profissional>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Profissional</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            \r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 28 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.CPF, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.CPF, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.CPF, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 36 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Telefone, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 52 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Habilitacao, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.CheckBoxFor(model => model.Habilitacao, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Habilitacao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 60 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.CategoriaHabilitacao, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.CategoriaHabilitacao, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.CategoriaHabilitacao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 68 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.LinguaEstrangeira, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.DropDownListFor(model => model.LinguaEstrangeira, Html.GetEnumSelectList<LinguaEstrangeiraEnum>(), htmlAttributes: new { @class = "control-label col-md-12", @disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 71 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.LinguaEstrangeira, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 76 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Endereco.IdentificadorUF, htmlAttributes: new { @class = "control-label col-md-2", @disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.DropDownListFor(
                        model => model.Endereco.IdentificadorUF, 
                        (IEnumerable <SelectListItem>) ViewData["estados"], 
                        htmlAttributes: new { @class = "control-label col-md-12", @disabled = true }
                        
                    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 84 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.IdentificadorUF, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n         \r\n             <div class=\"form-group\">\r\n                 ");
#nullable restore
#line 90 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
            Write(Html.LabelFor(model => model.Endereco.IdentificadorMunicipio, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  <div class=\"col-md-10\">\r\n                    <select id=\"IdentificadorMunicipio\" class=\"control-label col-md-2\" disabled>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8648ec943ce80077b24169a2e7cb6fca76a6afe815468", async() => {
                WriteLiteral("Cidade");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                    ");
#nullable restore
#line 95 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.IdentificadorMunicipio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 100 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Endereco.CEP, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 102 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Endereco.CEP, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 103 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.CEP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 108 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Endereco.Logradouro, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 110 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Endereco.Logradouro, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 111 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.Logradouro, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            \r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 117 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Endereco.Numero, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 119 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Endereco.Numero, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 120 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.Numero, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 125 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Endereco.Complemento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 127 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.Endereco.Complemento, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 128 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Endereco.Complemento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 133 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.Cargo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 135 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.DropDownListFor(model => model.Cargo, Html.GetEnumSelectList<CargoEnum>(), htmlAttributes: new { @class = "control-label col-md-12", @disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 136 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Cargo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 141 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
           Write(Html.LabelFor(model => model.SalarioProposto, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 143 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.EditorFor(model => model.SalarioProposto, new { htmlAttributes = new { @class = "form-control", @disabled = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 144 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.SalarioProposto, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8648ec943ce80077b24169a2e7cb6fca76a6afe824404", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "C:\Users\enilton.junior\source\repos\IEL Application\Views\Profissionais\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8648ec943ce80077b24169a2e7cb6fca76a6afe826556", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEL_Application.Models.Profissional> Html { get; private set; }
    }
}
#pragma warning restore 1591
