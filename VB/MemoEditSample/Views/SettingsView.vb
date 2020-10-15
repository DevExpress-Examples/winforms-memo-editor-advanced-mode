Imports System.Windows.Forms
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraEditors

Namespace MemoEditSample
    Partial Public Class SettingsView
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            rgMode.Properties.AddEnum(Of UserChoice)()
            If Not mvvmContext.IsDesignMode Then
                InitializeBindings()
            End If
            Dim service = WindowedDocumentManagerService.CreateXtraFormService(Me)
            service.DocumentShowMode = WindowedDocumentManagerService.FormShowMode.Dialog
            service.FormStyle = Sub(form)
                CType(form, XtraForm).IconOptions.Assign(Me.IconOptions)
                form.FormBorderStyle = FormBorderStyle.FixedToolWindow
                form.StartPosition = FormStartPosition.CenterScreen
            End Sub
            mvvmContext.RegisterService(service)
        End Sub
        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of SettingsViewModel)()
            fluent.SetBinding(rgMode, Function(rg) rg.EditValue, Function(x) x.UserChoice)
            fluent.SetBinding(ceRightToLeft, Function(ce) ce.Checked, Function(x) x.UseRTL)
            fluent.BindCommand(btnRunDemo, Sub(x) x.RunDemo)
        End Sub
    End Class
End Namespace