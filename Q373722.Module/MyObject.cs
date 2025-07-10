using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace Q373722.BusinessObjects {
    [DefaultClassOptions]
    public class MyObject : BaseObject {
        public MyObject(Session session) : base(session) { }
        string name;
        public string Name {
            get {
                return name;
            }
            set {
                SetPropertyValue(nameof(Name), ref name, value);
            }
        }
    }
}
