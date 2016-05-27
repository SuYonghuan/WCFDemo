using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.ServiceModel;
using System.ServiceModel.Activation;
using WCFClass;
namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.ServiceModel.Activation.WebServiceHostFactory WSHF =
      new System.ServiceModel.Activation.WebServiceHostFactory();

            System.ServiceModel.Activation.ServiceRoute ss =
              new System.ServiceModel.Activation.ServiceRoute(
              "wcfservice", WSHF, typeof(WCFClass.GasPriceService));
            System.Web.Routing.RouteTable.Routes.Add(ss);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}