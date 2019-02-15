using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace CustomFilterPopupSample
{
    public partial class CustomFilterPopupForm : XtraForm {
        public CustomFilterPopupForm() {
            InitializeComponent();
        }
        private void CustomFilterPopupForm_Load(object sender, EventArgs e) {
            CustomizePivotGrid(pivotGrid);
            pivotGrid.BestFit();
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
