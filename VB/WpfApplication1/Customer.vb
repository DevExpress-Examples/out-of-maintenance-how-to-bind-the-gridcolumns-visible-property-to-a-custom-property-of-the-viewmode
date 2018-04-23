Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports System.Windows
Imports System.ComponentModel
Imports System.Windows.Controls

Namespace WpfApplication1
	Public Class ContactItem
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateSalary As Double
		Public Property Salary() As Double
			Get
				Return privateSalary
			End Get
			Set(ByVal value As Double)
				privateSalary = value
			End Set
		End Property
		Private privateIsFired As Boolean
		Public Property IsFired() As Boolean
			Get
				Return privateIsFired
			End Get
			Set(ByVal value As Boolean)
				privateIsFired = value
			End Set
		End Property
	End Class

End Namespace
