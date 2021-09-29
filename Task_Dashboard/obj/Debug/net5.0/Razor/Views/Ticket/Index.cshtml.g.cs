#pragma checksum "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d31c3a57f498c5d4c364e7d220dea0e44ea230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
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
#line 1 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\_ViewImports.cshtml"
using Task_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\_ViewImports.cshtml"
using Task_Dashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d31c3a57f498c5d4c364e7d220dea0e44ea230", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd9f6f123da09ec15dce0fd2b2fa43f6e60b738", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.cerulean.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runaat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
  

    List<ServiceRequest> Request = new List<ServiceRequest>();
    List<Person> RequesterName = new List<Person>();
    List<Status> status = new List<Status>();
    List<WorkOrder> workOrders = new List<WorkOrder>();

    List<string> TicketName = new List<string>();
    List<string> Details = new List<string>();
    List<string> statusHash = new List<string>();
    List<string> reqIdHash = new List<string>();
    List<string> dueDate = new List<string>();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
     foreach (var sr in ViewData["SR"] as IEnumerable<ServiceRequest>)
    {
        Request.Add(sr);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
     foreach (var s in ViewData["status"] as IEnumerable<Status>)
    {
        status.Add(s);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
     foreach (var p in ViewData["person"] as IEnumerable<Person>)
    {
        RequesterName.Add(p);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
     foreach (WorkOrder ticket in Model)
    {
        workOrders.Add(ticket);
        TicketName.Add(ticket.Ticket);
        Details.Add(ticket.Summary);
        statusHash.Add(ticket.StatusId.ToString());
        reqIdHash.Add(ticket.RequesterId.ToString());
        dueDate.Add(ticket.DueDate.ToString());

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
     for (int i = 0; i < Request.Count; ++i)
    {
        TicketName.Add(Request[i].Ticket);
        statusHash.Add(Request[i].StatusId.ToString());
        reqIdHash.Add(Request[i].RequesterId.ToString());
        Details.Add(Request[i].Summary);
        dueDate.Add(Request[i].DueDate.ToString());
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d31c3a57f498c5d4c364e7d220dea0e44ea2307687", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.10.25/datatables.min.css"" />
    <script src=""https://code.jquery.com/jquery-3.6.0.js"" integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="" crossorigin=""anonymous""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.10.25/datatables.min.js""></script>
    <script src=""https://kit.fontawesome.com/5b2bd23d5f.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css"" integrity=""sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2d31c3a57f498c5d4c364e7d220dea0e44ea2308893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        jQuery(function ($) {\r\n            $(\'table.d\').DataTable();\r\n        })(jQuery);\r\n    </script>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n<div style=\"background-color: white;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h2 style=\"text-align:center\">Alloy Tickets</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d31c3a57f498c5d4c364e7d220dea0e44ea23011104", async() => {
                WriteLiteral(@"
                <table id=""table1"" class=""d"" style=""border-collapse: separate; border-spacing: 1em; background-color: white;"">
                    <thead>
                        <tr>
                            <th style=""max-width: 80px;"">Ticket</th>
                            <th style=""max-width: 80px;"">Description</th>
                            <th style=""max-width: 110px;"">Requester</th>
                            <th style=""max-width: 80px;"">Due Date</th>
                            <th style=""max-width: 80px;"">Status</th>
                            <th style=""max-width: 80px;"">Alloy 8 Link</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 90 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                         for (int i = 0; i < TicketName.Count; ++i)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 93 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                               Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                <td style=""max-width: 50px;"">
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter-");
#nullable restore
#line 96 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                                   Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                        Description\r\n                                    </button>\r\n\r\n                                    <!-- Modal -->\r\n                                    <div class=\"modal\"");
                BeginWriteAttribute("id", " id=\"", 4268, "\"", 4308, 2);
                WriteAttributeValue("", 4273, "exampleModalCenter-", 4273, 19, true);
#nullable restore
#line 101 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 4292, TicketName[i], 4292, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            "" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"" style=""background-color: none;"">
                                            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header"">
                                                        <h5 class=""modal-title""");
                BeginWriteAttribute("id", " id=\"", 4994, "\"", 5037, 2);
                WriteAttributeValue("", 4999, "exampleModalLongTitle-", 4999, 22, true);
#nullable restore
#line 107 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 5021, TicketName[i], 5021, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 107 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                       Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                            <span aria-hidden=""true"">&times;</span>
                                                        </button>
                                                    </div>
                                                    <div class=""modal-body"">
                                                        ");
#nullable restore
#line 113 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                   Write(Details[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
");
#nullable restore
#line 124 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                     for (int p = 0; p < RequesterName.Count; ++p)
                                    {
                                        if (RequesterName[p].Id.ToString().Equals(reqIdHash[i]))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                       Write(RequesterName[p].FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                       ; 

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 128 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                   Write(RequesterName[p].LastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                  ;
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 133 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                               Write(dueDate[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 136 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                     for (int l = 0; l < status.Count; ++l)
                                    {
                                        if (status[l].Id.ToString().Equals(statusHash[i]))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                       Write(status[l].Status1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                              
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td>\r\n\r\n");
#nullable restore
#line 149 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                      
                                        foreach (WorkOrder work in Model)
                                        {
                                            if (work.Ticket.Equals(TicketName[i]))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <a");
                BeginWriteAttribute("href", " href=\"", 7674, "\"", 7761, 3);
                WriteAttributeValue("", 7681, "http://srvalloy.cityofsalem.net/wp/WorkOrder.aspx?ID=", 7681, 53, true);
#nullable restore
#line 154 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 7734, work.Id.ToString(), 7734, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7755, "&tab=1", 7755, 6, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\" target=\"_blank\" role=\"button\">Link Button</a>\r\n");
#nullable restore
#line 155 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                      
                                        for (int a = 0; a < Request.Count; ++a)
                                            if (Request[a].Ticket.Equals(TicketName[i]))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <a");
                BeginWriteAttribute("href", " href=\"", 8273, "\"", 8360, 3);
                WriteAttributeValue("", 8280, "http://srvalloy.cityofsalem.net/wp/ServiceRequest.aspx?ID=", 8280, 58, true);
#nullable restore
#line 162 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 8338, Request[a].Id, 8338, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8354, "&tab=1", 8354, 6, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\" target=\"_blank\" role=\"button\">Link Button</a>\r\n");
#nullable restore
#line 163 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                            }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 168 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <div style=\"background-color: white;\">\r\n                <h2 style=\"text-align:center\">TDX Tasks</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d31c3a57f498c5d4c364e7d220dea0e44ea23025096", async() => {
                WriteLiteral(@"
                    <table id=""table2"" class=""d"" style=""border-collapse: separate; border-spacing: 1em; background-color: white;"">
                        <thead>
                            <tr>
                                <th style=""max-width: 80px;"">Ticket</th>
                                <th style=""max-width: 80px;"">Description</th>
                                <th style=""max-width: 110px;"">Requester</th>
                                <th style=""max-width: 80px;"">Due Date</th>
                                <th style=""max-width: 80px;"">Status</th>
                                <th style=""max-width: 80px;"">Alloy 8 Link</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 191 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                             for (int i = 0; i < TicketName.Count; ++i)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 194 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                   Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                    <td style=""max-width: 50px;"">
                                        <!-- Button trigger modal -->
                                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter-");
#nullable restore
#line 197 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                                       Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                            Description\r\n                                        </button>\r\n\r\n                                        <!-- Modal -->\r\n                                        <div class=\"modal\"");
                BeginWriteAttribute("id", " id=\"", 10404, "\"", 10444, 2);
                WriteAttributeValue("", 10409, "exampleModalCenter-", 10409, 19, true);
#nullable restore
#line 202 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 10428, TicketName[i], 10428, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                            <div class=""modal-dialog"" role=""document"">
                                                "" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"" style=""background-color: none;"">
                                                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                                    <div class=""modal-content"">
                                                        <div class=""modal-header"">
                                                            <h5 class=""modal-title""");
                BeginWriteAttribute("id", " id=\"", 11154, "\"", 11197, 2);
                WriteAttributeValue("", 11159, "exampleModalLongTitle-", 11159, 22, true);
#nullable restore
#line 208 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 11181, TicketName[i], 11181, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 208 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                           Write(TicketName[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                                <span aria-hidden=""true"">&times;</span>
                                                            </button>
                                                        </div>
                                                        <div class=""modal-body"">
                                                            ");
#nullable restore
#line 214 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                       Write(Details[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </div>
                                                        <div class=""modal-footer"">
                                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
");
#nullable restore
#line 225 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                         for (int p = 0; p < RequesterName.Count; ++p)
                                        {
                                            if (RequesterName[p].Id.ToString().Equals(reqIdHash[i]))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                           Write(RequesterName[p].FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                           ; 

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 229 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                       Write(RequesterName[p].LastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                                                                      ;
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 234 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                   Write(dueDate[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 237 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                         for (int l = 0; l < status.Count; ++l)
                                        {
                                            if (status[l].Id.ToString().Equals(statusHash[i]))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 241 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                           Write(status[l].Status1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 241 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                                  
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n\r\n\r\n                                    <td>\r\n\r\n");
#nullable restore
#line 250 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                          
                                            foreach (WorkOrder work in Model)
                                            {
                                                if (work.Ticket.Equals(TicketName[i]))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <a");
                BeginWriteAttribute("href", " href=\"", 14006, "\"", 14093, 3);
                WriteAttributeValue("", 14013, "http://srvalloy.cityofsalem.net/wp/WorkOrder.aspx?ID=", 14013, 53, true);
#nullable restore
#line 255 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 14066, work.Id.ToString(), 14066, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 14087, "&tab=1", 14087, 6, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\" target=\"_blank\" role=\"button\">Link Button</a>\r\n");
#nullable restore
#line 256 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                }
                                            }
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 259 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                          
                                            for (int a = 0; a < Request.Count; ++a)
                                                if (Request[a].Ticket.Equals(TicketName[i]))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <a");
                BeginWriteAttribute("href", " href=\"", 14637, "\"", 14724, 3);
                WriteAttributeValue("", 14644, "http://srvalloy.cityofsalem.net/wp/ServiceRequest.aspx?ID=", 14644, 58, true);
#nullable restore
#line 263 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 14702, Request[a].Id, 14702, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 14718, "&tab=1", 14718, 6, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\" target=\"_blank\" role=\"button\">Link Button</a>\r\n");
#nullable restore
#line 264 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                                                }
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 269 "C:\Users\kcardoza\Documents\GitHub\Task_Dashboard\Task_Dashboard\Views\Ticket\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
