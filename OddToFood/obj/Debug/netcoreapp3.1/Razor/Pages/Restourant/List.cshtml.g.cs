#pragma checksum "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba129637a2b7347cf58d4a55bfd4f7ff3d923671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OddToFood.Pages.Restourant.Pages_Restourant_List), @"mvc.1.0.razor-page", @"/Pages/Restourant/List.cshtml")]
namespace OddToFood.Pages.Restourant
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
#line 1 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\_ViewImports.cshtml"
using OddToFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba129637a2b7347cf58d4a55bfd4f7ff3d923671", @"/Pages/Restourant/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d299b5f684ad9b7160b50a13172f9776365377f2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restourant_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
  
    Model.Name = Model.Name + " iyidir.";

    var temp = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Restourant List</h1>\r\n\r\n\r\n\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <div>\r\n                <table class=\"table\">\r\n");
#nullable restore
#line 20 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                     foreach (var restaurant in Model.Restaurants)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                           Write(restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                           Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                           Write(restaurant.KitchenType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <div>\r\n                <table class=\"table\">\r\n");
#nullable restore
#line 34 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                     foreach (var customer in Model.Customers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                           Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 46 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
         foreach (var button in Model.Buttons)
        {
            if (button.Name.Contains("cel"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-danger\">");
#nullable restore
#line 50 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                                                        Write(button.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 51 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
            }
            else if (button.Name == "Sign")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-success\">");
#nullable restore
#line 54 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                                                         Write(button.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 55 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
            }
            else if (button.Name == "Skip")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-primary\">");
#nullable restore
#line 58 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
                                                         Write(button.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 59 "C:\Users\L\source\repos\OddToFood.Web\OddToFood\Pages\Restourant\List.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OddToFood.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OddToFood.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OddToFood.Pages.ListModel>)PageContext?.ViewData;
        public OddToFood.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
