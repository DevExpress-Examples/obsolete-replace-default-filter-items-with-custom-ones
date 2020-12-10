<!-- default file list -->
*Files to look at*:

* [CustomizePivotGrid.cs](./CS/CustomFilterPopupSample/CustomizePivotGrid.cs) (VB: [CustomizePivotGrid.vb](./VB/CustomFilterPopupSample/CustomizePivotGrid.vb))
* [Form1.cs](./CS/CustomFilterPopupSample/Form1.cs) (VB: [Form1.vb](./VB/CustomFilterPopupSample/Form1.vb))
* [GroupedFilterPopupItem.cs](./CS/CustomFilterPopupSample/GroupedFilterPopupItem.cs) (VB: [GroupedFilterPopupItem.vb](./VB/CustomFilterPopupSample/GroupedFilterPopupItem.vb))
<!-- default file list end -->
# How to Modify a Filter Popup to Show Custom Filter Items

This example demonstrates how to replace default filter items with custom items in a filter popup. 

You can group individual items in a filter popup based on a criteria and display groups instead of items to save space. Handle the [PivotGridControl.CustomFilterPopupItems](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomFilterPopupItems)  event to substitute default items with group items. To process group items and apply a filter, handle the [PivotGridControl.FieldFilterChanging](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.FieldFilterChanging) event.



**See also:**

* [Filtering](https://docs.devexpress.com/WindowsForms/1811)
