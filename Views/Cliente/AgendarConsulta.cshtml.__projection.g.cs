//------------------------------------------------------------------------------
// <auto-generated>
//     O c�digo foi gerado por uma ferramenta.
//     Vers�o de Tempo de Execu��o:4.0.30319.42000
//
//     As altera��es ao arquivo poder�o causar comportamento incorreto e ser�o perdidas se
//     o c�digo for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_AgendarConsulta_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_AgendarConsulta_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
  
    ViewBag.Title = "Agendar Consulta -";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden

#line 3 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
using (Html.BeginForm())
{
    

#line default
#line hidden

#line 4 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                            

    

#line default
#line hidden

#line 6 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
   __o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                              __o = Html.LabelFor(model => model.dataHoraAtendimento);


#line default
#line hidden

#line 8 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                     __o = Html.LabelFor(model => model.nomeAnimal);


#line default
#line hidden

#line 9 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                    foreach (var animal in ViewBag.animal)
                    {
                        

#line default
#line hidden

#line 10 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                  __o = animal.Value;


#line default
#line hidden

#line 11 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                 __o = animal.Text;


#line default
#line hidden

#line 12 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                           
                    }

#line default
#line hidden

#line 13 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                    foreach (var veteClinica in ViewBag.veterinario)
                    {
                        

#line default
#line hidden

#line 14 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                  __o = veteClinica.idVeterinario;


#line default
#line hidden

#line 15 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                              __o = veteClinica.nomeVeterinario;


#line default
#line hidden

#line 16 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                                             __o = veteClinica.nomeClinica;


#line default
#line hidden

#line 17 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                                                                        __o = veteClinica.logradouroEndereco;


#line default
#line hidden

#line 18 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                                                                                                        __o = veteClinica.numeroEndereco;


#line default
#line hidden

#line 19 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                                                                                                                                      __o = veteClinica.cepEndereco;


#line default
#line hidden

#line 20 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                                                                                                                                                                                                                            
                    }

#line default
#line hidden

#line 21 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                    __o = Url.Action("Index", "Cliente", new { @area = "" });


#line default
#line hidden

#line 22 "C:\Users\marcu\AppData\Local\Temp\B79A5A93E128E163D71A4C47D892C6EEFAA0\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
          
}

#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_AgendarConsulta_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_AgendarConsulta_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
  
    ViewBag.Title = "Agendar Consulta -";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden

#line 3 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
using (Html.BeginForm())
{
    

#line default
#line hidden

#line 4 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
                            

    

#line default
#line hidden

#line 6 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
   __o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.dataHoraAtendimento, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 8 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.dataHoraAtendimento, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 9 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.dataHoraAtendimento, "", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.descricaoAtendimento, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 11 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.descricaoAtendimento, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 12 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.descricaoAtendimento, "", new { @class = "text-danger" });


#line default
#line hidden

#line 13 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.idClinica, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 14 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.idClinica, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 15 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.idClinica, "", new { @class = "text-danger" });


#line default
#line hidden

#line 16 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.nomeClinica, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 17 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.nomeClinica, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 18 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.nomeClinica, "", new { @class = "text-danger" });


#line default
#line hidden

#line 19 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.idVeterinario, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 20 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.idVeterinario, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 21 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.idVeterinario, "", new { @class = "text-danger" });


#line default
#line hidden

#line 22 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.nomeVeterinario, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 23 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.nomeVeterinario, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 24 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.nomeVeterinario, "", new { @class = "text-danger" });


#line default
#line hidden

#line 25 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
       __o = Html.LabelFor(model => model.especVeterinario, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 26 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.EditorFor(model => model.especVeterinario, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 27 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
           __o = Html.ValidationMessageFor(model => model.especVeterinario, "", new { @class = "text-danger" });


#line default
#line hidden

#line 28 "C:\Users\3bdsmod\AppData\Local\Temp\A05C55BDF74E2062EA28C098470B73B3C374\2\Tcc\Views\Cliente\AgendarConsulta.cshtml"
__o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden
}
}
}
