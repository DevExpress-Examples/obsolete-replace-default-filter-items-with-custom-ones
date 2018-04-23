Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace CustomFilterPopupSample
	Partial Public Class CustomFilterPopupForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub CustomFilterPopupForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CustomizePivotGrid(pivotGrid)
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
