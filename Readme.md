<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582419/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3638)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomizePivotGrid.cs](./CS/CustomFilterPopupSample/CustomizePivotGrid.cs) (VB: [CustomizePivotGrid.vb](./VB/CustomFilterPopupSample/CustomizePivotGrid.vb))
* [Form1.cs](./CS/CustomFilterPopupSample/Form1.cs) (VB: [Form1.vb](./VB/CustomFilterPopupSample/Form1.vb))
* [GroupedFilterPopupItem.cs](./CS/CustomFilterPopupSample/GroupedFilterPopupItem.cs) (VB: [GroupedFilterPopupItem.vb](./VB/CustomFilterPopupSample/GroupedFilterPopupItem.vb))
<!-- default file list end -->
# How to Modify a Filter Popup to Show Custom Filter Items

This example demonstrate how to replace default filter items with custom items in a filter popup. 

You can group individual items in a filter popup based on a criteria and display groups instead of items to save space. Handle the [PivotGridControl.CustomFilterPopupItems](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomFilterPopupItems)  event to substitute default items with group items. To process group items and apply a filter, handle the [PivotGridControl.FieldFilterChanging](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.FieldFilterChanging) event.

![screenshot](https://github.com/DevExpress-Examples/how-to-replace-default-filter-items-with-custom-ones-e3638/blob/13.1.4%2B/images/screenshot.png)


**See also:**

* [Filtering](https://docs.devexpress.com/WindowsForms/1811)
