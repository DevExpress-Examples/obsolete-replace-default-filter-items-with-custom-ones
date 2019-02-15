Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace CustomFilterPopupSample
	Partial Public Class CustomFilterPopupForm
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub CustomFilterPopupForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			CustomizePivotGrid(pivotGrid)
			pivotGrid.BestFit()
		End Sub

		Private Sub cbEnableCustomFilterPopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableCustomFilterPopup.CheckedChanged
			If (TryCast(sender, CheckBox)).Checked Then
				productNameFilterRanges.AddEvents()
				dateFilterRanges.AddEvents()
			Else
				productNameFilterRanges.Detach()
				dateFilterRanges.Detach()
			End If
		End Sub
	End Class
End Namespace
