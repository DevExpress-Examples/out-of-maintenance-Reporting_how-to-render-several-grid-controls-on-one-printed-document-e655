Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace CompoundPrinting
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			productsTableAdapter.Fill(nwindDataSet.Products)
			categoriesTableAdapter.Fill(nwindDataSet.Categories)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			compositeLink.ShowPreview()
		End Sub
	End Class
End Namespace