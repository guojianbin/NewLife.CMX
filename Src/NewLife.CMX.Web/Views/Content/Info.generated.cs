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
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Info.cshtml")]
    public partial class _Views_Content_Info_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IInfo>
    {
        public _Views_Content_Info_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Content\Info.cshtml"
  
    var inf = Model;
    this.PushTitle(inf.Category.Name);
    this.PushTitle(inf.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Content\Info.cshtml"
   Write(Html.Partial("_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Content\Info.cshtml"
       Write(inf.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h2>\r\n        <h3");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n            <em");

WriteLiteral(" class=\"e e1\"");

WriteLiteral(">来源：");

            
            #line 16 "..\..\Views\Content\Info.cshtml"
                           Write(inf.CreateUserName);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <em");

WriteLiteral(" class=\"e e2\"");

WriteLiteral(">发布时间：");

            
            #line 17 "..\..\Views\Content\Info.cshtml"
                             Write(inf.CreateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <em");

WriteLiteral(" class=\"e e3\"");

WriteLiteral(">浏览：");

            
            #line 18 "..\..\Views\Content\Info.cshtml"
                           Write(inf.Views.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n        </h3>\r\n        <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <div>\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Content\Info.cshtml"
           Write(Html.Raw(inf.ContentText));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
