using System;
using System.Web;

namespace HttpModules
{
    public class CustomModule : IHttpModule
    {
        private DateTime RequestStartAt { get; set; }
        public void Dispose()
        {
           
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += OnBeginEachRequest;
            context.EndRequest += OnEndEachRequest;
        }

        private void OnEndEachRequest(object sender, EventArgs e)
        {
            HttpApplication httpApp = sender as HttpApplication;
            httpApp.Response.Write("Request End :" + DateTime.Now);
        }

        private void OnBeginEachRequest(object sender, EventArgs e)
        {
            HttpApplication httpApp = sender as HttpApplication;
            httpApp.Response.Write("Browser : "+ httpApp.Request.Browser.Type +"</br>");
            httpApp.Response.Write("Request Start :" + DateTime.Now);
            RequestStartAt = DateTime.Now;
        }
    }
}
