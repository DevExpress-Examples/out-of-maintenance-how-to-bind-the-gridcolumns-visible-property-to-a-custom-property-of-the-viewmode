Imports System
Imports System.Windows

Namespace WpfApplication1
    Partial Public Class Window1
        Inherits Window

        Private vm As ViewModel
        Public Sub New()
            InitializeComponent()

            AddHandler Loaded, AddressOf Window1_Loaded
        End Sub

        Private Sub Window1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm = New ViewModel()
            Me.DataContext = vm
          '  gridControl1.ItemsSource = vm.GetData();
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm.ListColumn(3).IsVisible = Not vm.ListColumn(3).IsVisible
        End Sub
    End Class
End Namespace
