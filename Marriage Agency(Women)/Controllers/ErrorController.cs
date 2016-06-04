using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Utils;

namespace Marriage_Agency_Women_.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public string Index()
        {
            ExceptionHandler exHandler = new ExceptionHandler();
            return exHandler.GetLastExceptionInfo();
        }
    }
}