#pragma checksum "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc43c601fd14d83ebe5eaca3c7fcecbd72eba21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Search), @"mvc.1.0.view", @"/Views/Cars/Search.cshtml")]
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
#line 1 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using MekinaWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using MekinaWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc43c601fd14d83ebe5eaca3c7fcecbd72eba21", @"/Views/Cars/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fae27cb430124c3b391ee0437398326c6649493f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"position:relative\">\r\n    <div class=\"container text-black\">\r\n        <div class=\"row\">\r\n                        <div class=\"card-body\">\r\n");
#nullable restore
#line 9 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
                             foreach (var cars in ViewBag.filteredCars)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bc43c601fd14d83ebe5eaca3c7fcecbd72eba214496", async() => {
                WriteLiteral(@"
                                    <div class=""row jumbotron border"" style=""margin-top:16px;"">
                                        <div class=""col-4"">
                                            <img class=""rounded-3 float-end"" style=""height:300px; width:300px;""");
                BeginWriteAttribute("src", " src=\"", 667, "\"", 687, 1);
#nullable restore
#line 14 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
WriteAttributeValue("", 673, cars.CarImage, 673, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""col-8"">
                                            <div>
                                                <h4 class=""display-6 mb-4 text-black"" style=""text-decoration:none;"">Name: ");
#nullable restore
#line 18 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
                                                                                                                     Write(cars.CarName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                            </div>\r\n                                            <div >\r\n                                                <h4 class=\"display-6 mb-4 text-black\" style=\"text-decoration:none;\">Year: ");
#nullable restore
#line 21 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
                                                                                                                     Write(cars.CarYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                            </div>\r\n                                            <div>\r\n                                                <h4 class=\"display-6 mb-4 text-black\" style=\"text-decoration:none;\">Transmission: ");
#nullable restore
#line 24 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
                                                                                                                             Write(cars.Transmission);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                            </div>\r\n                                        </div>\r\n                                        <hr />\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 338, "~/cars/details/", 338, 15, true);
#nullable restore
#line 11 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
AddHtmlAttributeValue("", 353, cars.CarId, 353, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
