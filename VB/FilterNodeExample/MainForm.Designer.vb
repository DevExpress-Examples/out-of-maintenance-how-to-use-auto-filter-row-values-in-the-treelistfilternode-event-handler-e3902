Namespace FilterNodeExample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.TreeList = New DevExpress.XtraTreeList.TreeList()
            Me.ColumnA = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            DirectCast(Me.TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' TreeList
            ' 
            Me.TreeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.ColumnA})
            Me.TreeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeList.Location = New System.Drawing.Point(0, 0)
            Me.TreeList.Name = "TreeList"
            Me.TreeList.BeginUnboundLoad()
            Me.TreeList.AppendNode(New Object() { "A"}, -1)
            Me.TreeList.AppendNode(New Object() { "B"}, 0)
            Me.TreeList.AppendNode(New Object() { "C"}, 0)
            Me.TreeList.AppendNode(New Object() { "D"}, -1)
            Me.TreeList.AppendNode(New Object() { "E"}, 3)
            Me.TreeList.EndUnboundLoad()
            Me.TreeList.OptionsBehavior.EnableFiltering = True
            Me.TreeList.OptionsView.ShowAutoFilterRow = True
            Me.TreeList.Size = New System.Drawing.Size(429, 268)
            Me.TreeList.TabIndex = 0
            ' 
            ' ColumnA
            ' 
            Me.ColumnA.Caption = "Column A"
            Me.ColumnA.FieldName = "Column A"
            Me.ColumnA.MinWidth = 52
            Me.ColumnA.Name = "ColumnA"
            Me.ColumnA.Visible = True
            Me.ColumnA.VisibleIndex = 0
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(429, 268)
            Me.Controls.Add(Me.TreeList)
            Me.Name = "MainForm"
            Me.Text = "DX Sample"
            DirectCast(Me.TreeList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents TreeList As DevExpress.XtraTreeList.TreeList
        Private ColumnA As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace

