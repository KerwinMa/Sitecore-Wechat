﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;


namespace Wechat
{
    public class MvcApplication : Sitecore.Web.Application
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //public void FormsAuthentication_OnAuthenticate(object sender, FormsAuthenticationEventArgs args)
        //{
        //    var frameworkVersion = GetFrameworkVersion();
        //    if (!string.IsNullOrEmpty(frameworkVersion) && frameworkVersion.StartsWith("v4.", StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        args.User = Sitecore.Context.User;
        //    }
        //}

        //private string GetFrameworkVersion()
        //{
        //    try
        //    {
        //        return System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Sitecore.Diagnostics.Log.Error("Cannot get framework version", ex, this);
        //        return string.Empty;
        //    }
        //}
    }
}
