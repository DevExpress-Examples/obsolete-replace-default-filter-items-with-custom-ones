using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CustomFilterPopupSample {
    public partial class CustomFilterPopupForm : Form {
        public CustomFilterPopupForm() {
            InitializeComponent();
        }
        private void CustomFilterPopupForm_Load(object sender, EventArgs e) {
            CustomizePivotGrid(pivotGrid);
        }

        private void cbEnableCustomFilterPopup_CheckedChanged(object sender, EventArgs e) {
            if ((sender as CheckBox).Checked) {
                productNameFilterRanges.AddEvents();
                dateFilterRanges.AddEvents();
            } else {
                productNameFilterRanges.Detach();
                dateFilterRanges.Detach();
            }
        }
    }
}
