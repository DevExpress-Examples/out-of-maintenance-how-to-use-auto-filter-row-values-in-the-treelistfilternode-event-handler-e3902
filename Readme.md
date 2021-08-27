<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638332/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3902)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/FilterNodeExample/MainForm.cs) (VB: [MainForm.vb](./VB/FilterNodeExample/MainForm.vb))
* [Program.cs](./CS/FilterNodeExample/Program.cs) (VB: [Program.vb](./VB/FilterNodeExample/Program.vb))
<!-- default file list end -->
# How to use Auto Filter Row values in the TreeList.FilterNode event handler


<p><strong>[Updated by Uriah (DevExpress Support)]</strong><br />This example is obsolete. If you are using the latest version of DevExpress, you can achieve the same result by setting the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeListOptionsFilter_FilterModetopic">TreeList.OptionsFilter.FilterMode</a> property to <strong>Extended</strong> or <strong>Smart</strong>. Refer to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListFilterModeEnumtopic">FilterMode</a> document for details.<br /><br /><strong>[Old content]</strong><br />Auto Filter Row values can be obtained via the TreeListColumn.FilterInfo.AutoFilterRowValue property. This example demonstrates how to hide nodes if a text displayed in node cells does not start with corresponding values in the Auto Filter Row, but displays a node if any of its child nodes satisfies this condition.</p>

<br/>


