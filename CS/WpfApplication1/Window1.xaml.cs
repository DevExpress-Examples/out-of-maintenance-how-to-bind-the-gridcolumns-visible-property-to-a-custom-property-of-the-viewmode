using System;
using System.Windows;

namespace WpfApplication1 {
    public partial class Window1 : Window {

        ViewModel vm;
        public Window1() {
            InitializeComponent();

            Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e) {
            vm = new ViewModel();
            this.DataContext = vm;
            gridControl1.ItemsSource = vm.GetData();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            vm.ShowHideIsFiredColumn = !vm.ShowHideIsFiredColumn;
        }
    }
}
