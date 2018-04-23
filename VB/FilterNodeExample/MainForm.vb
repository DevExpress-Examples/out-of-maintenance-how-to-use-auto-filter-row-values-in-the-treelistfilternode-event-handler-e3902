Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns

Namespace FilterNodeExample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			TreeList.ExpandAll()
		End Sub

		Private Sub OnFilterNode(ByVal sender As Object, ByVal e As FilterNodeEventArgs) Handles TreeList.FilterNode
			Dim filteredColumns As List(Of TreeListColumn) = e.Node.TreeList.Columns.Cast(Of TreeListColumn)().Where(Function(c) c.FilterInfo.AutoFilterRowValue IsNot Nothing).ToList()
			If filteredColumns.Count = 0 Then
				Return
			End If
			e.Handled = True
			e.Node.Visible = filteredColumns.Any(Function(c) IsNodeMatchFilter(e.Node, c))
		End Sub

		Private Shared Function IsNodeMatchFilter(ByVal node As TreeListNode, ByVal column As TreeListColumn) As Boolean
			Dim filterValue As String = column.FilterInfo.AutoFilterRowValue.ToString()
			If node.GetDisplayText(column).StartsWith(filterValue) Then
				Return True
			End If
			For Each n As TreeListNode In node.Nodes
				If IsNodeMatchFilter(n, column) Then
					Return True
				End If
			Next n
			Return False
		End Function
	End Class
End Namespace
