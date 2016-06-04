using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Marriage_Agency_Women_.Models.IdentityModels;
using Marriage_Agency_Women_.Utils;
using System.IO;

namespace Marriage_Agency_Women_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            String rootPath = Server.MapPath("~");
            string imagesDirectoryPath = rootPath + "/Content/Images/";            

            if (!Directory.Exists(imagesDirectoryPath))
            {
                Directory.CreateDirectory(imagesDirectoryPath);
            }

            string imagesThumbnailsPath = rootPath + "/Content/Images/Thumbnails";
            if (!Directory.Exists(imagesThumbnailsPath))
            {
                Directory.CreateDirectory(imagesThumbnailsPath);
            }

        }

        private void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            ExceptionHandler.LastException = ex;

            Response.Redirect("/Error/Index");
        }
    }
}
