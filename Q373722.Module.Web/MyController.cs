using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using System.Threading;
using System.Web;

namespace Q373722.Module.Web {
    public class MyController : ViewController {
        public static string LongOperationStatus = "NotStarted";
        public MyController() {
            SimpleAction action = new SimpleAction(this, "StartLongOperation", PredefinedCategory.Tools);
            action.Execute += new SimpleActionExecuteEventHandler(action_Execute);
        }

        void action_Execute(object sender, SimpleActionExecuteEventArgs e) {
            if(LongOperationStatus != "NotStarted") {
                return;
            }
            ThreadPool.QueueUserWorkItem(new WaitCallback(ExecuteLongOperation));
        }
        public static void ExecuteLongOperation(object obj) {
            for(int i = 0; i <= 100; i++) {
                LongOperationStatus = i.ToString();
                Thread.Sleep(1000);
            }
            LongOperationStatus = "completed";
        }
    }
}
