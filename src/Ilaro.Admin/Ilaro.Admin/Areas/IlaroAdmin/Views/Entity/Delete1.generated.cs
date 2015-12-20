﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Entity/Delete.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Entity_Delete_cshtml : System.Web.Mvc.WebViewPage<EntityDeleteModel>
    {

#line 57 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
public System.Web.WebPages.HelperResult DisplayRecordHierarchy(RecordHierarchy record)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 58 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 60 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
WriteTo(__razor_helper_writer, record.Entity.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": ");


#line 60 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(record.DisplayName, "Edit", new { entityName = record.Entity.Name, key = record.JoinedKeyValue }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 61 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
        

#line default
#line hidden

#line 61 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
         if (record.SubRecordsHierarchies.Any())
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul>\r\n");


#line 64 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                

#line default
#line hidden

#line 64 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                 foreach (var subRecord in record.SubRecordsHierarchies)
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    ");


#line 66 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
WriteTo(__razor_helper_writer, DisplayRecordHierarchy(subRecord));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 67 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 69 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 71 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"


#line default
#line hidden
});

#line 71 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
}
#line default
#line hidden

        public _Areas_IlaroAdmin_Views_Entity_Delete_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
  
    Layout = "~/Areas/IlaroAdmin/Views/Shared/_Layout.cshtml";
    ViewBag.Title = string.Format(IlaroAdminResources.Delete_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 10 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
       Write(Html.ActionLink(IlaroAdminResources.Index_Title, "Index", "Group", new { area = "IlaroAdmin" }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Group, "Details", "Group", new { area = "IlaroAdmin", groupName = Model.Entity.Verbose.Group }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Plural, "Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 13 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                      Write(string.Format(IlaroAdminResources.Delete_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 17 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
Write(Model.Entity.Verbose.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 19 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
 using (Html.BeginForm("Delete", "Entity", new { area = "IlaroAdmin" }, FormMethod.Post, new { @class = "form-horizontal" }))
{
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                             
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
Write(Html.Hidden("EntityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                 
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
Write(Html.Hidden("Key", Model.Entity.JoinedKeyValue));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                    


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
       Write(IlaroAdminResources.DeleteText);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 31 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"

    for (int i = 0; i < Model.PropertiesDeleteOptions.Count; i++)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1393), Tuple.Create("\"", 1462)
            
            #line 35 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 1399), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => Model.PropertiesDeleteOptions[i].DeleteOption)
            
            #line default
            #line hidden
, 1399), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 35 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                                                                                   Write(Model.PropertiesDeleteOptions[i].PropertyName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
           Write(Html.HiddenFor(m => Model.PropertiesDeleteOptions[i].PropertyName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
           Write(Html.DropDownListFor(m => Model.PropertiesDeleteOptions[i].DeleteOption, Model.PropertiesDeleteOptions[i].DeleteOption.GetSelectList(), new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 41 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
    }


            
            #line default
            #line hidden
WriteLiteral("    <h4>If all foreign entities are to be cascade delete, all of the following it" +
"ems will be deleted:</h4>\r\n");

WriteLiteral("    <ul");

WriteLiteral(" class=\"list-delete\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
   Write(DisplayRecordHierarchy(Model.RecordHierarchy));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n");

            
            #line 47 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                     Write(IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2291), Tuple.Create("\"", 2317)
            
            #line 51 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 2298), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit")
            
            #line default
            #line hidden
, 2298), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 51 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                                                                      Write(IlaroAdminResources.Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2429), Tuple.Create("\"", 2503)
            
            #line 52 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 2436), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Entities", new { area = "IlaroAdmin" }, null)
            
            #line default
            #line hidden
, 2436), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
                                                                                                          Write(IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n");

            
            #line 55 "..\..\Areas\IlaroAdmin\Views\Entity\Delete.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
