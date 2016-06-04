using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Marriage_Agency_Women_.Utils
{
    public class ExceptionHandler
    {
        private static Exception lastException;

        private StringBuilder result = new StringBuilder();
                

        public static Exception LastException
        {
            get { return lastException; }
            set { lastException = value; }
        }


        public string GetLastExceptionInfo()
        {
            if (LastException == null)
            {
                return "last exception is null";
            }

            result.Append("<h1>Error Page</h1>");
            result.Append("<p>1: outer Exception => n: inner Exception</p>");

            result.Append("<ol>");
            AddExceptionInfo(LastException);
            result.Append("</ol>");

            return result.ToString();
        }

        private void AddExceptionInfo(Exception ex)
        {
            if (ex.Message != null)
            {
                result.Append("<li><ul>");
                result.AppendFormat("<li>Message: {0}</li>", ex.Message);
                result.AppendFormat("<li>Source: {0}</li>", ex.Source);
                result.AppendFormat("<li>TargetSite: {0}</li>", ex.TargetSite);
                result.AppendFormat("<li>StackTrace:<br />{0}</li>", ex.StackTrace);
                result.Append("</li></ul>");

            }
            if (ex.InnerException != null)
            {
                AddExceptionInfo(ex.InnerException);
            }
        }
    }
}