﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Ilaro.Admin.Models.Paging;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Shared/DisplayTemplates/ImagePartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_DisplayTemplates_ImagePartial_cshtml_ : System.Web.Mvc.WebViewPage<CellValue>
    {
        public _Areas_IlaroAdmin_Views_Shared_DisplayTemplates_ImagePartial_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\IlaroAdmin\Views\Shared\DisplayTemplates\ImagePartial.cshtml"
  
    if (Model.Raw == null)
    {
        return;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<a");

WriteAttribute("href", Tuple.Create(" href=\"", 88), Tuple.Create("\"", 122)
            
            #line 9 "..\..\Areas\IlaroAdmin\Views\Shared\DisplayTemplates\ImagePartial.cshtml"
, Tuple.Create(Tuple.Create("", 95), Tuple.Create<System.Object, System.Int32>(Url.GetImageBigPath(Model)
            
            #line default
            #line hidden
, 95), false)
);

WriteLiteral(" class=\"open-modal\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 147), Tuple.Create("\"", 180)
            
            #line 9 "..\..\Areas\IlaroAdmin\Views\Shared\DisplayTemplates\ImagePartial.cshtml"
, Tuple.Create(Tuple.Create("", 153), Tuple.Create<System.Object, System.Int32>(Url.GetImageMinPath(Model)
            
            #line default
            #line hidden
, 153), false)
);

WriteLiteral(" class=\"img-polaroid\"");

WriteAttribute("alt", Tuple.Create(" alt=\"", 202), Tuple.Create("\"", 223)
            
            #line 9 "..\..\Areas\IlaroAdmin\Views\Shared\DisplayTemplates\ImagePartial.cshtml"
                                           , Tuple.Create(Tuple.Create("", 208), Tuple.Create<System.Object, System.Int32>(Model.AsString
            
            #line default
            #line hidden
, 208), false)
);

WriteLiteral(" /></a>\r\n");

        }
    }
}
#pragma warning restore 1591
