<!-- default file list -->
*Files to look at*:

* [CustomizePivotGrid.cs](./CS/CustomFilterPopupSample/CustomizePivotGrid.cs) (VB: [CustomizePivotGrid.vb](./VB/CustomFilterPopupSample/CustomizePivotGrid.vb))
* [Form1.cs](./CS/CustomFilterPopupSample/Form1.cs) (VB: [Form1.vb](./VB/CustomFilterPopupSample/Form1.vb))
* [GroupedFilterPopupItem.cs](./CS/CustomFilterPopupSample/GroupedFilterPopupItem.cs) (VB: [GroupedFilterPopupItem.vb](./VB/CustomFilterPopupSample/GroupedFilterPopupItem.vb))
<!-- default file list end -->
# How to replace default filter items with custom ones


<p>In some situation it can be helpful to replace default items with custom ones. E.g. if you have too many items they can be convenient for grouping them based upon certain criteria and displaying group items in a filter popup. It is possible to handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomFilterPopupItemstopic">CustomFilterPopupItems </a> event to remove default items and add group items instead. To apply a filter based upon the selected by end-users, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_FieldFilterChangingtopic">PivotGridControl.FieldFilterChanging</a> event.</p>

<br/>


