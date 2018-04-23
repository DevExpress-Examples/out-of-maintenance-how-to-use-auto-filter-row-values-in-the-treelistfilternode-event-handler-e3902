namespace FilterNodeExample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TreeList = new DevExpress.XtraTreeList.TreeList();
            this.ColumnA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeList
            // 
            this.TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColumnA});
            this.TreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeList.Location = new System.Drawing.Point(0, 0);
            this.TreeList.Name = "TreeList";
            this.TreeList.BeginUnboundLoad();
            this.TreeList.AppendNode(new object[] {
            "A"}, -1);
            this.TreeList.AppendNode(new object[] {
            "B"}, 0);
            this.TreeList.AppendNode(new object[] {
            "C"}, 0);
            this.TreeList.AppendNode(new object[] {
            "D"}, -1);
            this.TreeList.AppendNode(new object[] {
            "E"}, 3);
            this.TreeList.EndUnboundLoad();
            this.TreeList.OptionsBehavior.EnableFiltering = true;
            this.TreeList.OptionsView.ShowAutoFilterRow = true;
            this.TreeList.Size = new System.Drawing.Size(429, 268);
            this.TreeList.TabIndex = 0;
            this.TreeList.FilterNode += new DevExpress.XtraTreeList.FilterNodeEventHandler(this.OnFilterNode);
            // 
            // ColumnA
            // 
            this.ColumnA.Caption = "Column A";
            this.ColumnA.FieldName = "Column A";
            this.ColumnA.MinWidth = 52;
            this.ColumnA.Name = "ColumnA";
            this.ColumnA.Visible = true;
            this.ColumnA.VisibleIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 268);
            this.Controls.Add(this.TreeList);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColumnA;
    }
}

