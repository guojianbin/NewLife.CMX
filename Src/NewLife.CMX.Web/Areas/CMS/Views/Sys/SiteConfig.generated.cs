﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Sys/SiteConfig.cshtml")]
    public partial class _Areas_CMS_Views_Sys_SiteConfig_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.SiteConfig>
    {
        public _Areas_CMS_Views_Sys_SiteConfig_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
  
    Layout = "~/Views/Shared/_Ace_Layout.cshtml";
    ViewBag.Title = "网站配置";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
         using (Html.BeginForm())
        {
            
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
                                     
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
       Write(Html.EditorForModel());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
                                  

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"clearfix form-actions\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral("></label>\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-save\"");

WriteLiteral("></i><strong>保存</strong></button>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-sm\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n            </div>\r\n");

            
            #line 19 "..\..\Areas\CMS\Views\Sys\SiteConfig.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    ");

WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
