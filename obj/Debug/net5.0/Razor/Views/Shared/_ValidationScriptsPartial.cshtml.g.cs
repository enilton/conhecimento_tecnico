#pragma checksum "C:\Projetos\conhecimento_tecnico\Views\Shared\_ValidationScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b8a6ff150b45de28670b97aaa5a260b45a8993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ValidationScriptsPartial), @"mvc.1.0.view", @"/Views/Shared/_ValidationScriptsPartial.cshtml")]
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
#line 1 "C:\Projetos\conhecimento_tecnico\Views\_ViewImports.cshtml"
using IEL_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\conhecimento_tecnico\Views\_ViewImports.cshtml"
using IEL_Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b8a6ff150b45de28670b97aaa5a260b45a8993", @"/Views/Shared/_ValidationScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ac269b921502a78c43f2bbd4715a30c2cec5de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ValidationScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b8a6ff150b45de28670b97aaa5a260b45a89933906", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b8a6ff150b45de28670b97aaa5a260b45a89934945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script src=""http://digitalbush.com/wp-content/uploads/2014/10/jquery.maskedinput.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.0/jquery.mask.js""></script>

 <script>
        $(document).ready(function () { 

            $(""#CPF"").mask('000.000.000-00', {reverse: true});
            $(""#Telefone"").mask('(00) 9 0000-0000', {reverse: true});
            $(""#Endereco_CEP"").mask('00000-000', {reverse: true});
            $(""#SalarioProposto"").mask('000.000,00', {reverse: true});
            $(""#CategoriaHabilitacao"").hide();
            $(""#HoraInicio"").mask('00:00', {reverse: true});
            $(""#HoraFim"").mask('00:00', {reverse: true});

            $(""#Habilitacao"").click(function() {
                 habilitarCategoria($(""#Habilitacao"").is(':checked'))
            });
      
           $(""#Endereco_IdentificadorUF"").change(function() {
 ");
            WriteLiteral(@"               listaCidade($(this).val());
           });

           $(""#Endereco_CEP"").blur(function() {
                buscarEndereco($(this).val());
           });

           $(""#addDiaDeTrabalho"").click(function () {
               adicionarDiaDeTrabalho(                
                
               );
           });

           $(""#TempoDescanso"").blur(function() {
                calcularCargaHorariaDiaria();
           });
        });

        function calcularCargaHorariaDiaria(){

            var hs =  $(""#HoraInicio"").val();
            var hf =  $(""#HoraFim"").val();
            var descanso = $(""#TempoDescanso"").val();

            if (hs && hf && descanso) {

                //horainicial to time
                var horaInicioT = new Date(2000,0,1,hs.split(':')[0],hs.split(':')[1]);
                var horaFimT = new Date(2000,0,1,hf.split(':')[0],hf.split(':')[1]);               

                var chDiaria = ((horaFimT.getTime() - horaInicioT.getTime())/1000");
            WriteLiteral(@"/60/60) - descanso

                if (chDiaria > 10)
                    alert('Carga horária maior que 10H');

                $(""#CargaHorariaDiaria"").val(chDiaria);
            }
          
        }

        function listaCidade(estadoId) { 
            $.ajax({
                url: '/Profissionais/ListaCidadeAsync',
                dataType: 'json',
                method: 'GET',
                data: { estadoId: estadoId },
                success: function (data) {
                    console.log('Success:', data);
                    listaCidadeCallBack(data);

                },
                error: function (data) {                    
                    console.warn('Error:', data);

                }
            })
        }

        function listaCidadeCallBack(json) {      
            console.log(json);
            $(""#IdentificadorMunicipio :gt(0)"").remove();
            $(json).each(function() {
                
                $(""#IdentificadorMunicipio""");
            WriteLiteral(@").append(""<option value='"" + this.id + ""'>"" + this.nome + ""</option>"");
            });
        }

        function buscarEndereco(cep) {           

            $.ajax({
                url: '/Profissionais/BuscaEnderecoAsync',
                dataType: 'json',
                method: 'GET',
                data: { cep: cep },
                success: function (data) {
                    console.log('Success:', data);
                    buscarEnderecoCallBack(data);

                },
                error: function (data) {                   
                    console.warn('Error:', data);

                }
            })
        }

        function buscarEnderecoCallBack(json) {
            $(""#Endereco_Logradouro"").val(json.logradouro)
        }

        function habilitarCategoria(ativo) {
            if(ativo)
                    $(""#CategoriaHabilitacao"").show();  
                else
                    $(""#CategoriaHabilitacao"").hide(); 
        }

        // ");
            WriteLiteral(@"function adicionarDiaDeTrabalho(estadoId) { 
        //    $.ajax({
        //        url: '/Profissionais/AdicionarDiaDeTrabalhoAsync',
        //        dataType: 'json',
        //        method: 'POST',
        //        data: {  },
        //        success: function (data) {
        //            console.log('Success:', data);

        //        },
        //        error: function (data) {                    
        //            console.warn('Error:', data);

        //        }
        //    })
        //}


    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
