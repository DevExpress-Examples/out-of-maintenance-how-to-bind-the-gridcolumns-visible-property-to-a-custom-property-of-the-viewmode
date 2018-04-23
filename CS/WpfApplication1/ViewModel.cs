using System;
using System.Windows;
using System.ComponentModel;

namespace WpfApplication1 {
    public class ViewModel : DependencyObject {

        // Using a DependencyProperty as the backing store for ShowHideIsFiredColumn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowHideIsFiredColumnProperty =
            DependencyProperty.Register("ShowHideIsFiredColumn", typeof(bool), typeof(ViewModel), new UIPropertyMetadata(true));

        public bool ShowHideIsFiredColumn {
            get { return (bool)GetValue(ShowHideIsFiredColumnProperty); }
            set { SetValue(ShowHideIsFiredColumnProperty, value); }
        }

        BindingList<ContactItem> coll;
        public object GetData() {
            return new BindingList<ContactItem>(){
                new ContactItem() { Name = "First sample name", Salary = 13d, Date = DateTime.Today, IsFired = false },
                new ContactItem() { Name = "Second sample name", Salary = 13d, Date = DateTime.Today, IsFired = false }
            };
        }


    }
}
