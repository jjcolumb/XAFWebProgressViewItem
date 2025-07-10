using System;
using System.ComponentModel;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace Q373722.Module.Web {
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class Q373722AspNetModule : ModuleBase {
        public Q373722AspNetModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
