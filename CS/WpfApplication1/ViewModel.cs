using System;
using System.Windows;
using System.ComponentModel;
using System.Windows.Documents;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApplication1 {
    public class ViewModel  {

        // Using a DependencyProperty as the backing store for ShowHideIsFiredColumn.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ShowHideIsFiredColumnProperty =
        //    DependencyProperty.Register("ShowHideIsFiredColumn", typeof(bool), typeof(ViewModel), new UIPropertyMetadata(true));

        //public bool ShowHideIsFiredColumn {
        //    get { return (bool)GetValue(ShowHideIsFiredColumnProperty); }
        //    set { SetValue(ShowHideIsFiredColumnProperty, value); }
        //}
        public ViewModel() {
            CreateData();
            CreateColumn();
        }
        
        public BindingList<ContactItem> ListItem { get; set; }
        public List<MyColumn> ListColumn { get; set; }

        public void CreateData() {
            ListItem = new BindingList<ContactItem>(){
                new ContactItem() { Name = "First sample name", Salary = 13d, Date = DateTime.Today, IsFired = false },
                new ContactItem() { Name = "Second sample name", Salary = 13d, Date = DateTime.Today, IsFired = false }
            };
        }
        public void CreateColumn() {
            ListColumn = new List<MyColumn>();
            ListColumn.Add(new MyColumn() { FieldName = "Name", IsVisible = true });
            ListColumn.Add(new MyColumn() { FieldName = "Salary", IsVisible = true });
            ListColumn.Add(new MyColumn() { FieldName = "Date", IsVisible = true });
            ListColumn.Add(new MyColumn() { FieldName = "IsFired", IsVisible = false });

        }
      
    }

    public class MyColumn:INotifyPropertyChanged {

        public string FieldName { get; set; }
        bool _isVisible;

        public bool IsVisible {
            get { return _isVisible; }
            set { _isVisible = value;
            RaisePropertyChanged("IsVisible");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
