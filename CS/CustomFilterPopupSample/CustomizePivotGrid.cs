using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using System.IO;
using System.Data;
using System;
namespace CustomFilterPopupSample {
    partial class CustomFilterPopupForm {
        CustomFilterRanges productNameFilterRanges;
        CustomFilterRanges dateFilterRanges;
        void CustomizePivotGrid(PivotGridControl pivotGrid) {
            pivotGrid.DataSource = CreateCustomDataTable();
            const string QuantityFieldName = "Quantity";
            const string ProductNameFieldName = "ProductName";
            const string DateFieldName = "Date";
            PivotGridField fieldQuantity = new PivotGridField(QuantityFieldName, PivotArea.DataArea);
            PivotGridField fieldProductName = new PivotGridField(ProductNameFieldName, PivotArea.RowArea);
            PivotGridField fieldDate = new PivotGridField(DateFieldName, PivotArea.ColumnArea);
            fieldDate.GroupInterval = PivotGroupInterval.Date;
            pivotGrid.Fields.AddRange(new PivotGridField[] {
                fieldProductName,
                fieldQuantity,
                fieldDate
            });
            productNameFilterRanges = new CustomFilterRanges(pivotGrid, fieldProductName);
            dateFilterRanges = new CustomFilterRanges(pivotGrid, fieldDate);
        }
        DataTable CreateCustomDataTable() {
            DataTable customDataTable = new DataTable("Shopping");
            customDataTable.Columns.Add("Quantity", typeof(float));
            customDataTable.Columns.Add("Price", typeof(float));
            customDataTable.Columns.Add("ProductName", typeof(string));
            customDataTable.Columns.Add("Date", typeof(DateTime));
            customDataTable.Rows.Add(5.0, 50.0, null, DateTime.Today.AddYears(-1).AddMonths(-1));
            customDataTable.Rows.Add(10.0, 31.0, null, DateTime.Today.AddYears(-1).AddMonths(-1));
            customDataTable.Rows.Add(3.0, 30.0, null, DateTime.Today.AddYears(-1).AddMonths(-1));
            customDataTable.Rows.Add(3.5, 230.0, "Bananas", DateTime.Today.AddYears(-1).AddMonths(-1));
            customDataTable.Rows.Add(5.0, 50.0, "Apples", DateTime.Today.AddDays(-8));
            customDataTable.Rows.Add(10.0, 31.0, "Peaches", DateTime.Today.AddDays(-8));
            customDataTable.Rows.Add(3.0, 30.0, "Lemons", DateTime.Today.AddDays(-8));
            customDataTable.Rows.Add(3.5, 230.0, "Bananas", DateTime.Today.AddDays(-8));
            customDataTable.Rows.Add(5.0, 52.0, "Apples", DateTime.Today.AddDays(-7));
            customDataTable.Rows.Add(1.0, 33.0, "Peaches", DateTime.Today.AddDays(-7));
            customDataTable.Rows.Add(2.0, 32.0, "Lemons", DateTime.Today.AddDays(-7));
            customDataTable.Rows.Add(2.3, 250.20, "Bananas", DateTime.Today.AddDays(-7));
            customDataTable.Rows.Add(5.0, 50.0, "Apples", DateTime.Today.AddDays(-6));
            customDataTable.Rows.Add(10.0, 31.0, "Peaches", DateTime.Today.AddDays(-6));
            customDataTable.Rows.Add(3.0, 30.0, "Lemons", DateTime.Today.AddDays(-6));
            customDataTable.Rows.Add(3.5, 230.0, "Bananas", DateTime.Today.AddDays(-6));
            customDataTable.Rows.Add(5.0, 52.0, "Apples", DateTime.Today.AddDays(-2));
            customDataTable.Rows.Add(1.0, 33.0, "Peaches", DateTime.Today.AddDays(-2));
            customDataTable.Rows.Add(2.0, 32.0, "Lemons", DateTime.Today.AddDays(-2));
            customDataTable.Rows.Add(2.3, 250.20, "Bananas", DateTime.Today.AddDays(-2));
            customDataTable.Rows.Add(1.0, 55.0, "Apples", DateTime.Today.AddDays(-1));
            customDataTable.Rows.Add(2.0, 38.0, "Peaches", DateTime.Today.AddDays(-1));
            customDataTable.Rows.Add(1.0, 36.0, "Lemons", DateTime.Today.AddDays(-1));
            customDataTable.Rows.Add(2.0, 55.0, "Apples", DateTime.Today);
            customDataTable.Rows.Add(2.0, 39.0, "Peaches", DateTime.Today);
            customDataTable.Rows.Add(1.0, 37.0, "Lemons", DateTime.Today);
            customDataTable.Rows.Add(3.5, 270.30, "Bananas", DateTime.Today);
            customDataTable.Rows.Add(2.0, 55.0, "Apples", DateTime.Today.AddDays(1));
            customDataTable.Rows.Add(3.0, 40.5, "Peaches", DateTime.Today.AddDays(1));
            customDataTable.Rows.Add(4.2, 290.8, "Bananas", DateTime.Today.AddDays(1));
            customDataTable.Rows.Add(10.0, 56.0, "Apples", DateTime.Today.AddMonths(1));
            customDataTable.Rows.Add(1.0, 41.0, "Peaches", DateTime.Today.AddMonths(1));
            customDataTable.Rows.Add(2.0, 39.0, "Lemons", DateTime.Today.AddMonths(1));
            customDataTable.Rows.Add(1.5, 290.30, "Bananas", DateTime.Today.AddMonths(1));
            customDataTable.Rows.Add(10.0, 56.0, "Apples", DateTime.Today.AddMonths(1).AddDays(1));
            customDataTable.Rows.Add(1.0, 41.0, "Peaches", DateTime.Today.AddMonths(1).AddDays(1));
            customDataTable.Rows.Add(2.0, 39.0, "Lemons", DateTime.Today.AddMonths(1).AddDays(1));
            customDataTable.Rows.Add(1.5, 290.30, "Bananas", DateTime.Today.AddMonths(1).AddDays(1));
            customDataTable.Rows.Add(5.0, 57.2, "Apples", DateTime.Today.AddYears(1));
            customDataTable.Rows.Add(3.0, 42.0, "Peaches", DateTime.Today.AddYears(1));
            customDataTable.Rows.Add(1.0, 43.0, "Lemons", DateTime.Today.AddYears(1));
            customDataTable.Rows.Add(1.2, 295.30, "Bananas", DateTime.Today.AddYears(1));
            return customDataTable;
        }
    }
}

