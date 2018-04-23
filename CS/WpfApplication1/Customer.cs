using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;

namespace WpfApplication1 {
    public class ContactItem {
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsFired { get; set; }
    }

}
