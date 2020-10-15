Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraEditors
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm
Imports System.Windows.Forms

Namespace MemoEditSample

    Public Enum UserChoice
        <Display(Name := "Standard Mode")>
        StandardMode
        <Display(Name := "Advanced Mode (DirectX)")>
        AdvancedViaDirectX
        <Display(Name := "Advanced Mode (Gdi)")>
        AdvancedViaGdi
    End Enum
    '
    Public Class SettingsViewModel
        Public ReadOnly Property Title() As String
            Get
                Return "MemoEdit Demo"
            End Get
        End Property
        Public ReadOnly Property Mode() As String
            Get
                Return EnumDisplayTextHelper.GetDisplayText(UserChoice)
            End Get
        End Property
        Private privateUseAdvancedMode As Boolean
        Public Overridable Property UseAdvancedMode() As Boolean
            Get
                Return privateUseAdvancedMode
            End Get
            Protected Set(ByVal value As Boolean)
                privateUseAdvancedMode = value
            End Set
        End Property
        Private privateUseDirectX As Boolean
        Public Overridable Property UseDirectX() As Boolean
            Get
                Return privateUseDirectX
            End Get
            Protected Set(ByVal value As Boolean)
                privateUseDirectX = value
            End Set
        End Property
        Public Overridable Property UserChoice() As UserChoice
        Public Overridable Property UseRTL() As Boolean
        Protected Sub OnUserChoiceChanged()
            Select Case UserChoice
                Case UserChoice.StandardMode
                    UseDirectX = False
                    UseAdvancedMode = UseDirectX
                Case UserChoice.AdvancedViaDirectX
                    UseDirectX = True
                    UseAdvancedMode = UseDirectX
                Case UserChoice.AdvancedViaGdi
                    UseAdvancedMode = True
                    UseDirectX = False
            End Select
        End Sub
        Protected ReadOnly Property DocumentManagerService() As IDocumentManagerService
            Get
                Return Me.GetService(Of IDocumentManagerService)()
            End Get
        End Property
        Public Sub RunDemo()
            Dim currentWindow = Me.GetRequiredService(Of ICurrentWindowService)()
            currentWindow.Hide()
            Try

                Dim demoViewModel_Renamed = MemoEditSample.DemoViewModel.Create()
                demoViewModel_Renamed.SetParentViewModel(Me)
                Dim document = DocumentManagerService.CreateDocument(nameof(DemoView), demoViewModel_Renamed)
                document.Title = Title
                document.Show()
            Finally
                currentWindow.Show()
            End Try
        End Sub
        Private Sub UpdateCommands()
            Me.RaiseCanExecuteChanged(Sub(x) x.RunDemo())
        End Sub
    End Class
End Namespace