#pragma checksum "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e00ea922957de1e2e8331665ab3623a9727c09b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_OneItemOrder), @"mvc.1.0.view", @"/Views/Shared/OneItemOrder.cshtml")]
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
#line 1 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using PShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using PShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using PShop.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using PShop.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using PShop.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using IdentityModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
using PShop.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e00ea922957de1e2e8331665ab3623a9727c09b", @"/Views/Shared/OneItemOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7fa48a7c91ea5c8a8511ceb9191bff4d6d9e6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_OneItemOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 7 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
  
	var shopcart = ViewBag.SCart as List<Item>;
	var wishlist = ViewBag.Wlist as List<Item>;
	var sale = Model.Sale * 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card \" style=\"background-color: #ffffff\">\n\t\n\n\n\t<div class=\"row card-body\">\n\t\t<div class=\"col-sm-2 text-center\">\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e00ea922957de1e2e8331665ab3623a9727c09b6096", async() => {
                WriteLiteral("<img class=\"img-thumbnail\" style=\"border-color:white;\"");
                BeginWriteAttribute("src", " src=\"", 513, "\"", 559, 1);
#nullable restore
#line 19 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
WriteAttributeValue("", 519, Html.DisplayFor(modelItem => Model.Img), 519, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
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
            WriteLiteral("\n\t\t</div>\n\t\t<div class=\"col-sm-6 \">\n\t\t\t<h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e00ea922957de1e2e8331665ab3623a9727c09b8973", async() => {
#nullable restore
#line 22 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                                                                                                     Write(Html.DisplayFor(modelItem => Model.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\n");
#nullable restore
#line 23 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
             if (Model.ScoreCount > 0)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                 if (Model.AvgScore >= 7)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\" text-center rating\" style=\"background-color:#4cff00\">\n\t\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                   Write(Model.AvgScore.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</div>\n");
#nullable restore
#line 30 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
				}
				else if (Model.AvgScore >= 5)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"text-center rating\" style=\"background-color:#ffd800\">\n\t\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                   Write(Model.AvgScore.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</div>\n");
#nullable restore
#line 36 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"text-center rating\" style=\"background-color:#ff0000\">\n\t\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                   Write(Model.AvgScore.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</div>\n");
#nullable restore
#line 42 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                 
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t\t<div class=\"col-sm-4\">\n\n");
#nullable restore
#line 47 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
             if (Model.Sale == 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<h4 class=\"text\">");
#nullable restore
#line 49 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                            Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 50 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p>\n\t\t\t\t\t<a style=\"font-size:16px ;color:#4cff00; background-color:#1e6500\">&nbsp-");
#nullable restore
#line 54 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                                                                                        Write(sale);

#line default
#line hidden
#nullable disable
            WriteLiteral("%&nbsp</a>&nbsp\n\t\t\t\t\t<s>");
#nullable restore
#line 55 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</s>\n\t\t\t\t</p>\n\t\t\t\t<h4 class=\"text\">");
#nullable restore
#line 57 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"
                            Write(Model.SalePrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 58 "C:\Users\FireG\Documents\GitHub\Site\PShop\Views\Shared\OneItemOrder.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t</div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public StoreContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
