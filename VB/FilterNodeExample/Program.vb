Imports System
Imports DevExpress.Skins
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports System.Collections.Generic

Namespace FilterNodeExample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SkinName = "Seven"
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace
