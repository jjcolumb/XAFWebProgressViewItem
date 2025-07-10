using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Editors;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Web.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Web;

namespace Q373722.Module.Web {
    public interface IModelProgressViewItem : IModelViewItem {
    }

    [ViewItemAttribute(typeof(IModelProgressViewItem))]
    public class ProgresViewItem : ViewItem {
        public ProgresViewItem(IModelProgressViewItem info, Type classType)
            : base(classType, info.Id) {
        }
        protected override object CreateControlCore() {
            ASPxLabel lbl = new ASPxLabel();
            lbl.ClientInstanceName = "myprogresscontrol";
            lbl.Text = MyController.LongOperationStatus;
            lbl.ClientSideEvents.Init =
@"function(s,e) { 
                                if(window.timer) { 
                                    window.clearInterval(window.timer);
                                }
                                var controlToUpdate = s;
                                window.timer = window.setInterval(function(){
                                Q373722.Web.WebService1.GetLongOperationStatus(function(result) { 
                                    if (controlToUpdate){
                                        controlToUpdate.SetText(result);
                                    }
                                });
                            },1000
                            ); 
                        }";
            return lbl;
            //            ASPxProgressBar bar = new ASPxProgressBar();
            //            bar.ClientInstanceName = "myprogresscontrol";
            //            bar.Width = Unit.Percentage(100);
            //            bar.ClientSideEvents.Init =
            //@"function() {  
            //                var script = 'Q373722.Web.WebService1.GetLongOperationStatus(function(result) {myprogresscontrol.SetPosition(result);} )';  
            //                window.setInterval(script, 1000);  
            //            }";
            //            return bar;
        }
    }
}
