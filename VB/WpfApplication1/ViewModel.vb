Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.ComponentModel

Namespace WpfApplication1
	Public Class ViewModel
		Inherits DependencyObject

		' Using a DependencyProperty as the backing store for ShowHideIsFiredColumn.  This enables animation, styling, binding, etc...
		Public Shared ReadOnly ShowHideIsFiredColumnProperty As DependencyProperty = DependencyProperty.Register("ShowHideIsFiredColumn", GetType(Boolean), GetType(ViewModel), New UIPropertyMetadata(True))

		Public Property ShowHideIsFiredColumn() As Boolean
			Get
				Return CBool(GetValue(ShowHideIsFiredColumnProperty))
			End Get
			Set(ByVal value As Boolean)
				SetValue(ShowHideIsFiredColumnProperty, value)
			End Set
		End Property

		Private coll As BindingList(Of ContactItem)
		Public Function GetData() As Object
			Return New BindingList(Of ContactItem)() From {New ContactItem() With {.Name = "First sample name", .Salary = 13R, .HairedDate = DateTime.Today, .IsFired = False}, New ContactItem() With {.Name = "Second sample name", .Salary = 13R, .HairedDate = DateTime.Today, .IsFired = False}}
		End Function


	End Class
End Namespace
