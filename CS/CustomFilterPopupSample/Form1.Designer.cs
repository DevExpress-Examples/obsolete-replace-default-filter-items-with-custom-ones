namespace CustomFilterPopupSample {
    partial class CustomFilterPopupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbEnableCustomFilterPopup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGrid
            // 
            this.pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGrid.Location = new System.Drawing.Point(0, 0);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.Size = new System.Drawing.Size(748, 508);
            this.pivotGrid.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbEnableCustomFilterPopup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pivotGrid);
            this.splitContainer1.Size = new System.Drawing.Size(748, 537);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // cbEnableCustomFilterPopup
            // 
            this.cbEnableCustomFilterPopup.AutoSize = true;
            this.cbEnableCustomFilterPopup.Location = new System.Drawing.Point(12, 6);
            this.cbEnableCustomFilterPopup.Name = "cbEnableCustomFilterPopup";
            this.cbEnableCustomFilterPopup.Size = new System.Drawing.Size(158, 17);
            this.cbEnableCustomFilterPopup.TabIndex = 0;
            this.cbEnableCustomFilterPopup.Text = "Enable Filter Popup Ranges";
            this.cbEnableCustomFilterPopup.UseVisualStyleBackColor = true;
            this.cbEnableCustomFilterPopup.CheckedChanged += new System.EventHandler(this.cbEnableCustomFilterPopup_CheckedChanged);
            // 
            // CustomFilterPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomFilterPopupForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomFilterPopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbEnableCustomFilterPopup;










    }
}

