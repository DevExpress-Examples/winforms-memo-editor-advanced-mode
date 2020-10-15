Imports System
Imports System.Windows.Forms

Namespace MemoEditSample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New SettingsView())
        End Sub
    End Class
End Namespace