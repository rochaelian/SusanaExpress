#pragma checksum "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04218705fc58804c2014f400a898d20acf16f1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_CrearCliente), @"mvc.1.0.view", @"/Views/Cliente/CrearCliente.cshtml")]
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
#line 1 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\_ViewImports.cshtml"
using WebSusanaMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\_ViewImports.cshtml"
using WebSusanaMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04218705fc58804c2014f400a898d20acf16f1e9", @"/Views/Cliente/CrearCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf23ff0781f95f23501980fd26ca493975fe403d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_CrearCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Susana.Entity.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
  
    ViewBag.Title = "Nuevo Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"well well-sm text-primary text-center\">\r\n    ");
#nullable restore
#line 7 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
Write(ViewBag.MensajeInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <fieldset>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 16 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
           Write(Html.LabelFor(model => model.Nombre, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    ");
#nullable restore
#line 18 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
               Write(Html.EditorFor(model => model.Nombre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 22 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
           Write(Html.LabelFor(model => model.ApUno, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    ");
#nullable restore
#line 24 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
               Write(Html.EditorFor(model => model.ApUno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 28 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
           Write(Html.LabelFor(model => model.ApDos, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    ");
#nullable restore
#line 30 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
               Write(Html.EditorFor(model => model.ApDos, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 35 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
           Write(Html.LabelFor(model => model.Direccion, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-8\">\r\n                    ");
#nullable restore
#line 37 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
               Write(Html.EditorFor(model => model.Direccion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
           Write(Html.LabelFor(model => model.Telefono, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 43 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
               Write(Html.EditorFor(model => model.Telefono, new { htmlAttributes = new { @class = "form-control", @type = "number" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </fieldset>\r\n\r\n        <div class=\"form-actions col-md-offset-2\">\r\n            <input class=\"btn btn-primary\" type=\"submit\" name=\"btnguardar\" value=\"Guardar\" />|\r\n            ");
#nullable restore
#line 51 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
       Write(Html.ActionLink("Regresar al Listado", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-primary text-success text-center\">\r\n    ");
#nullable restore
#line 57 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
Write(ViewBag.MensajeExito);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n<div class=\"text-primary text-danger text-center\">\r\n    ");
#nullable restore
#line 60 "D:\Users\Elian\Desktop\Proyecto Componentes\SusanaExpress\WebSusanaMvc\Views\Cliente\CrearCliente.cshtml"
Write(ViewBag.MensajeError);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Susana.Entity.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
