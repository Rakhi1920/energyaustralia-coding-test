#pragma checksum "C:\Project\Festival\Festival\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af88772095d5889d370a0092a3d25359fc844dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Project\Festival\Festival\Views\_ViewImports.cshtml"
using Festival;

#line default
#line hidden
#line 2 "C:\Project\Festival\Festival\Views\_ViewImports.cshtml"
using Festival.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af88772095d5889d370a0092a3d25359fc844dbe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca0e10ffff9c7442efb1255b27b469deb66a868", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BandFestivalDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
  

    ViewBag.Title = "List of Festivals";

#line default
#line hidden
            BeginContext(90, 15, true);
            WriteLiteral("\r\n<div>\r\n    \r\n");
            EndContext();
#line 10 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
     foreach (var festival in Model)
    {
        

#line default
#line hidden
#line 12 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
         if (festival.recordLabel != null)
        {

#line default
#line hidden
            BeginContext(205, 81, true);
            WriteLiteral("        <div >\r\n            <ul>  \r\n                <li>\r\n                   <b> ");
            EndContext();
            BeginContext(287, 20, false);
#line 17 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
                  Write(festival.recordLabel);

#line default
#line hidden
            EndContext();
            BeginContext(307, 91, true);
            WriteLiteral("</b>\r\n\r\n                    <ul>\r\n                       <li>\r\n                            ");
            EndContext();
            BeginContext(399, 17, false);
#line 21 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
                       Write(festival.bandName);

#line default
#line hidden
            EndContext();
            BeginContext(416, 102, true);
            WriteLiteral("\r\n                           <ul>\r\n                              <li>\r\n                               ");
            EndContext();
            BeginContext(519, 21, false);
#line 24 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
                          Write(festival.festivalName);

#line default
#line hidden
            EndContext();
            BeginContext(540, 202, true);
            WriteLiteral("\r\n                              </li>\r\n                            </ul>\r\n                       </li>\r\n                    </ul>\r\n                </li>\r\n             </ul>\r\n      </div>\r\n      <br />\r\n");
            EndContext();
#line 33 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#line 33 "C:\Project\Festival\Festival\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(768, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BandFestivalDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591