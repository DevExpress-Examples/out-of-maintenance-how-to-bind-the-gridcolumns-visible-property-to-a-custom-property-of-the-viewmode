Imports System.ComponentModel
Imports System.Collections.Generic

Namespace WpfApplication1

    Public Class ViewModel

        ' Using a DependencyProperty as the backing store for ShowHideIsFiredColumn.  This enables animation, styling, binding, etc...
        'public static readonly DependencyProperty ShowHideIsFiredColumnProperty =
        '    DependencyProperty.Register("ShowHideIsFiredColumn", typeof(bool), typeof(ViewModel), new UIPropertyMetadata(true));
        'public bool ShowHideIsFiredColumn {
        '    get { return (bool)GetValue(ShowHideIsFiredColumnProperty); }
        '    set { SetValue(ShowHideIsFiredColumnProperty, value); }
        '}
        Public Sub New()
            CreateData()
            CreateColumn()
        End Sub

        Public Property ListItem As BindingList(Of ContactItem)

        Public Property ListColumn As List(Of MyColumn)

        Public Sub CreateData()
            ListItem = New BindingList(Of ContactItem)() From {New ContactItem() With {.Name = "First sample name", .Salary = 13R, .[Date] = Date.Today, .IsFired = False}, New ContactItem() With {.Name = "Second sample name", .Salary = 13R, .[Date] = Date.Today, .IsFired = False}}
        End Sub

        Public Sub CreateColumn()
            ListColumn = New List(Of MyColumn)()
            ListColumn.Add(New MyColumn() With {.FieldName = "Name", .IsVisible = True})
            ListColumn.Add(New MyColumn() With {.FieldName = "Salary", .IsVisible = True})
            ListColumn.Add(New MyColumn() With {.FieldName = "Date", .IsVisible = True})
            ListColumn.Add(New MyColumn() With {.FieldName = "IsFired", .IsVisible = False})
        End Sub
    End Class

    Public Class MyColumn
        Implements INotifyPropertyChanged

        Public Property FieldName As String

        Private _isVisible As Boolean

        Public Property IsVisible As Boolean
            Get
                Return _isVisible
            End Get

            Set(ByVal value As Boolean)
                _isVisible = value
                RaisePropertyChanged("IsVisible")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub RaisePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
