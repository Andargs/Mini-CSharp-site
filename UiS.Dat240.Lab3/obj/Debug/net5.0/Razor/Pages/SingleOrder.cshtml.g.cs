#pragma checksum "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d6cad010fa989d217205c8e029a8483bbd3b95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UiS.Dat240.Lab3.Pages.Pages_SingleOrder), @"mvc.1.0.razor-page", @"/Pages/SingleOrder.cshtml")]
namespace UiS.Dat240.Lab3.Pages
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
#line 1 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\_ViewImports.cshtml"
using UiS.Dat240.Lab3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d6cad010fa989d217205c8e029a8483bbd3b95", @"/Pages/SingleOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca64538433e1439e748588d9b868d5a7117cd42f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SingleOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Shipper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrderPlaceddos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetFullfillment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
  
	ViewData["Title"] = "SingleOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center mt-4\">\r\n\r\n\t<h1 class=\"display-4 mt-5\">Order ");
#nullable restore
#line 9 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                                Write(Model._order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t<div class=\"text-left\">\r\n");
#nullable restore
#line 11 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
         if (Model._order is null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<p>There are no orders published</p>\r\n");
#nullable restore
#line 14 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                				<thead>
					<tr>
						<th scope=""col"">Id</th>
                        <th scope=""col"">Date</th>
						<th scope=""col"">Customer</th>
						<th scope=""col"">Building</th>
                        <th scope=""col"">RoomNumber</th>
                        <th scope=""col"">Notes</th>
                        <th scope=""col"">Status</th>
                        <th scope=""col"">Shipper</th>
                        <th scope=""col"">Submit</th>
					</tr>
				</thead>
				<tbody>
                    <tr>
                        <td>");
#nullable restore
#line 33 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                         if (@Model._order.Customer is not null){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(Model._order.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                            } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Ingen kunde</td>\r\n");
#nullable restore
#line 39 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 40 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Location.Building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Location.RoomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Location.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                         if (Model._offer.Shipper is null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d6cad010fa989d217205c8e029a8483bbd3b959920", async() => {
                WriteLiteral("\r\n                                            <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63d6cad010fa989d217205c8e029a8483bbd3b9510226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63d6cad010fa989d217205c8e029a8483bbd3b9512056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model._order.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63d6cad010fa989d217205c8e029a8483bbd3b9513800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-shipper", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                                                                                                              WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["shipper"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-shipper", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["shipper"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                                              WriteLiteral(Model._order.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                        } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 52 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(Model._offer.Shipper.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</tbody>\r\n            </table>\r\n");
#nullable restore
#line 57 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
         if (Model._order.OrderLines is not null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h1 class=""display-4 mt-5"">Order items</h1>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Item</th>
                        <th>Price</th>
                        <th>Count</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 70 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                     foreach (var orderline in Model._order.OrderLines){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        \r\n                            <td>");
#nullable restore
#line 73 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(orderline.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 74 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(orderline.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(orderline.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                           Write(orderline.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                    </tr>\r\n");
#nullable restore
#line 79 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 82 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
         if (Model._invoice is not null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h1 class=""display-4 mt-5"">Invoice</h1>
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">OrderId</th>
                        <th scope=""col"">Customer</th>
                        <th scope=""col"">Building</th>
                        <th scope=""col"">RoomNumber</th>
                        <th scope=""col"">Notes</th>
                        <th scope=""col"">Total Amount</th>
                        <th scope=""col"">Status</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 100 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 101 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 102 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._order.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 103 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Address.Building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 104 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Address.RoomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 105 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Address.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 106 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 107 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._invoice.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 111 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h1 class=""display-4 mt-5"">Offer</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">OrderId</th>
                    <th scope=""col"">Shipper</th>
                    <th scope=""col"">Total Amount</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 123 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                   Write(Model._offer.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 124 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                     if (Model._offer.Shipper is null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Shipper not set</td>\r\n");
#nullable restore
#line 126 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 127 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                       Write(Model._offer.Shipper.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 128 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 129 "C:\Users\ander\dat240-2021\Lab3\UiS.Dat240.Lab3\Pages\SingleOrder.cshtml"
                   Write(Model._offer.Reimbursement.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\t\t<div>\r\n            </div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3.Pages.SingleOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lab3.Pages.SingleOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lab3.Pages.SingleOrderModel>)PageContext?.ViewData;
        public Lab3.Pages.SingleOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591