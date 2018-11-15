<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/FilterNodeExample/MainForm.cs) (VB: [MainForm.vb](./VB/FilterNodeExample/MainForm.vb))
<!-- default file list end -->
# How to use Auto Filter Row values in the TreeList.FilterNode event handler


<p><strong>[Updated by Uriah (DevExpress Support)]</strong><br />This example is obsolete. If you are using the latest version of DevExpress, you can achieve the same result by setting the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeListOptionsFilter_FilterModetopic">TreeList.OptionsFilter.FilterMode</a> property to <strong>Extended</strong> or <strong>Smart</strong>. Refer to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListFilterModeEnumtopic">FilterMode</a> document for details.<br /><br /><strong>[Old content]</strong><br />Auto Filter Row values can be obtained via the TreeListColumn.FilterInfo.AutoFilterRowValue property. This example demonstrates how to hide nodes if a text displayed in node cells does not start with corresponding values in the Auto Filter Row, but displays a node if any of its child nodes satisfies this condition.</p>

<br/>


