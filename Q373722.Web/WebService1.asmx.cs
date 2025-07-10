using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Q373722.Module.Web;

namespace Q373722.Web {
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService {

        [WebMethod]
        public string GetLongOperationStatus() {
            return MyController.LongOperationStatus;
        }
    }
}
