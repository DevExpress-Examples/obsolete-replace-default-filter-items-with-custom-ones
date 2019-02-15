Namespace CustomFilterPopupSample
	Partial Public Class CustomFilterPopupForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.cbEnableCustomFilterPopup = New System.Windows.Forms.CheckBox()
			DirectCast(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGrid
			' 
			Me.pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGrid.Location = New System.Drawing.Point(0, 0)
			Me.pivotGrid.Name = "pivotGrid"
			Me.pivotGrid.Size = New System.Drawing.Size(748, 508)
			Me.pivotGrid.TabIndex = 0
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.cbEnableCustomFilterPopup)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.pivotGrid)
			Me.splitContainer1.Size = New System.Drawing.Size(748, 537)
			Me.splitContainer1.SplitterDistance = 25
			Me.splitContainer1.TabIndex = 1
			' 
			' cbEnableCustomFilterPopup
			' 
			Me.cbEnableCustomFilterPopup.AutoSize = True
			Me.cbEnableCustomFilterPopup.Location = New System.Drawing.Point(12, 6)
			Me.cbEnableCustomFilterPopup.Name = "cbEnableCustomFilterPopup"
			Me.cbEnableCustomFilterPopup.Size = New System.Drawing.Size(163, 17)
			Me.cbEnableCustomFilterPopup.TabIndex = 0
			Me.cbEnableCustomFilterPopup.Text = "Enable Custom Filter Ranges"
			Me.cbEnableCustomFilterPopup.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.cbEnableCustomFilterPopup.CheckedChanged += new System.EventHandler(this.cbEnableCustomFilterPopup_CheckedChanged);
			' 
			' CustomFilterPopupForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(748, 537)
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "CustomFilterPopupForm"
			Me.Text = "Custom Ranges in Popup Filter"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.CustomFilterPopupForm_Load);
			DirectCast(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents cbEnableCustomFilterPopup As System.Windows.Forms.CheckBox










	End Class
End Namespace

