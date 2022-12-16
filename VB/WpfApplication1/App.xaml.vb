' Developer Express Code Central Example:
' How to bind the GridColumn Visible property to the dependency property of the ViewModel
' 
' In the v9.3 version, GridColumn properties are not inherited from the
' FrameworkElement class. GridColumn property binding can be done only using the
' BindingOperations.SetBinding method via code. In the v10.1 version, we have
' overcome this issue. You can bind any GridColumn property via xaml.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2569
Imports System.Windows

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

    End Class
End Namespace
