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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Account;
    
    #line 1 "..\..\Views\ListedInSpamDatabase.cshtml"
    using Frapid.i18n;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ListedInSpamDatabase.cshtml")]
    public partial class _Views_ListedInSpamDatabase_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_ListedInSpamDatabase_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\ListedInSpamDatabase.cshtml"
  
    ViewBag.Title = "Sign Up";
    Layout = ViewBag.LayoutPath + ViewBag.Layout;
    ViewBag.Description = "Create your account on our site.";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\ListedInSpamDatabase.cshtml"
 if (CultureManager.IsRtl())
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 232), Tuple.Create("\"", 280)
            
            #line 9 "..\..\Views\ListedInSpamDatabase.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page-rtl.css")
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(" />\r\n");

            
            #line 10 "..\..\Views\ListedInSpamDatabase.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 324), Tuple.Create("\"", 368)
            
            #line 13 "..\..\Views\ListedInSpamDatabase.cshtml"
, Tuple.Create(Tuple.Create("", 331), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page.css")
            
            #line default
            #line hidden
, 331), false)
);

WriteLiteral(" />\r\n");

            
            #line 14 "..\..\Views\ListedInSpamDatabase.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"ui very relaxed tall container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui red huge header\"");

WriteLiteral(">Registration Closed</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n    <div>\r\n        <p>We are sorry but we are not accepting new registra" +
"tion this time.</p>\r\n\r\n        <p>Sorry for the inconvenience. Please check back" +
" again later.</p>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
