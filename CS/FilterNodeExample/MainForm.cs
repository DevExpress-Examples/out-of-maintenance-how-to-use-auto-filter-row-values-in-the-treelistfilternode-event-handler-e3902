using System;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;

namespace FilterNodeExample {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
            TreeList.ExpandAll();
        }

        private void OnFilterNode(object sender, FilterNodeEventArgs e) {
            List<TreeListColumn> filteredColumns = e.Node.TreeList.Columns.Cast<TreeListColumn>(
                ).Where(c => c.FilterInfo.AutoFilterRowValue != null).ToList();
            if (filteredColumns.Count == 0) return;
            e.Handled = true;
            e.Node.Visible = filteredColumns.Any(c => IsNodeMatchFilter(e.Node, c));
        }

        static bool IsNodeMatchFilter(TreeListNode node, TreeListColumn column) {
            string filterValue = column.FilterInfo.AutoFilterRowValue.ToString();
            if (node.GetDisplayText(column).StartsWith(filterValue)) return true;
            foreach (TreeListNode n in node.Nodes)
                if (IsNodeMatchFilter(n, column)) return true;
            return false;
        }
    }
}
