#pragma checksum "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa70ee769aa23c81f04dc283941e5584821c2a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa70ee769aa23c81f04dc283941e5584821c2a8", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fae27cb430124c3b391ee0437398326c6649493f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MekinaWebsite.Models.CarsList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n\t<div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"card mb-3 shadow-lg p-3 mb-5 bg-white\"  style=\"width:300px; margin-left:15px \">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 316, "\"", 348, 2);
            WriteAttributeValue("", 323, "/cars/details/", 323, 14, true);
#nullable restore
#line 14 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 337, item.CarId, 337, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"itemCard\" style=\"text-decoration:none;\">\r\n\t\t\t\t\t<img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 429, "\"", 449, 1);
#nullable restore
#line 15 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 435, item.CarImage, 435, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Car Image\" style=\"height:200px;width:100%\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<p class=\"card-text\" style=\"font-weight:bold\">");
#nullable restore
#line 17 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                                                 Write(item.CarName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Br</p>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                        Write(item.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</a>\r\n");
#nullable restore
#line 22 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                 if(SignInManager.IsSignedIn(User)){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 772, "\"", 801, 2);
            WriteAttributeValue("", 779, "/cars/book/", 779, 11, true);
#nullable restore
#line 23 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 790, item.CarId, 790, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Book this car</a> \r\n");
#nullable restore
#line 24 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
					
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                 if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
				{
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 948, "\"", 977, 2);
            WriteAttributeValue("", 955, "/cars/edit/", 955, 11, true);
#nullable restore
#line 29 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 966, item.CarId, 966, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary  mt-1\">Update</a>                \r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1043, "\"", 1074, 2);
            WriteAttributeValue("", 1050, "/cars/delete/", 1050, 13, true);
#nullable restore
#line 30 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 1063, item.CarId, 1063, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"margin-top:3px;\">Delete</a>\r\n");
#nullable restore
#line 31 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n");
#nullable restore
#line 33 "C:\Users\Ihs\Desktop\Files\Assignment\Web Design 2\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MekinaWebsite.Models.CarsList>> Html { get; private set; }
    }
}
#pragma warning restore 1591