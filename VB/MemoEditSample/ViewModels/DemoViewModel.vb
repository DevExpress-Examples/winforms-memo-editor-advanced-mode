Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Utils
Imports System
Imports System.Text
Imports System.Windows.Forms

Namespace MemoEditSample
    Public Class DemoViewModel
        Public Shared Function Create() As DemoViewModel
            Return ViewModelSource(Of DemoViewModel).Create()
        End Function
        '
        Private isReady As Boolean
        Protected Sub New()
            LinesCount = 1000
            LineLength = 50
            CustomLinesCount = 100000
            Text = GetText(LinesCount, LineLength)
            isReady = True
            WordWrap = True
            ScrollBars = ScrollBars.Both
        End Sub
        Public ReadOnly Property RightToLeft() As RightToLeft
            Get
                Return If(Me.GetParentViewModel(Of SettingsViewModel)().UseRTL, RightToLeft.Yes, RightToLeft.Inherit)
            End Get
        End Property
        Public ReadOnly Property UseAdvancedMode() As DefaultBoolean
            Get
                Return If(Me.GetParentViewModel(Of SettingsViewModel)().UseAdvancedMode, DefaultBoolean.True, DefaultBoolean.Default)
            End Get
        End Property
        Public ReadOnly Property UseDirectXPaint() As DefaultBoolean
            Get
                Return If(Me.GetParentViewModel(Of SettingsViewModel)().UseDirectX, DefaultBoolean.True, DefaultBoolean.Default)
            End Get
        End Property
        Public ReadOnly Property Mode() As String
            Get
                Return Me.GetParentViewModel(Of SettingsViewModel)().Mode
            End Get
        End Property
        Public Overridable Property ScrollBars() As ScrollBars
        Public Overridable Property Text() As String
        Public Overridable Property LinesCount() As Integer
        Public Overridable Property LineLength() As Integer
        Public Overridable Property WordWrap() As Boolean
        Protected Sub OnLinesCountChanged()
            UpdateText()
            Me.RaisePropertyChanged(Function(x) x.Use1K)
            Me.RaisePropertyChanged(Function(x) x.Use10K)
            Me.RaisePropertyChanged(Function(x) x.Use50K)
            Me.RaisePropertyChanged(Function(x) x.UseCustomLinesCount)
            Me.RaisePropertyChanged(Function(x) x.CustomLinesCount)
            Me.RaiseCanExecuteChanged(Sub(x) x.GenerateCustomLines())
        End Sub
        Protected Sub OnLineLengthChanged()
            UpdateText()
        End Sub
        Public Property Use1K() As Boolean
            Get
                Return LinesCount = 1000
            End Get
            Set(ByVal value As Boolean)
                LinesCount = 1000
            End Set
        End Property
        Public Property Use10K() As Boolean
            Get
                Return LinesCount = 10000
            End Get
            Set(ByVal value As Boolean)
                LinesCount = 10000
            End Set
        End Property
        Public Property Use50K() As Boolean
            Get
                Return LinesCount = 50000
            End Get
            Set(ByVal value As Boolean)
                LinesCount = 50000
            End Set
        End Property
        Public Property UseCustomLinesCount() As Boolean
            Get
                Return LinesCount = CustomLinesCount
            End Get
            Set(ByVal value As Boolean)
                LinesCount = CustomLinesCount
            End Set
        End Property
        Public Overridable Property CustomLinesCount() As Integer
        Protected Sub OnCustomLinesCountChanged()
            If isReady Then
                LinesCount = CustomLinesCount
            End If
        End Sub
        Public Sub GenerateCustomLines()
            UpdateText()
        End Sub
        Private Sub UpdateText()
            If Not isReady Then
                Return
            End If
            Dim overlay = Me.GetService(Of ISplashScreenService)()
            Try
                overlay.ShowSplashScreen("#Overlay#")
                Text = GetText(LinesCount, LineLength)
            Finally
                overlay.HideSplashScreen()
            End Try
        End Sub
        '
        Private Shared Function GetText(ByVal linesCount As Integer, Optional ByVal lineLength As Integer = 10) As String
            Dim words() As String = My.Resources.LoremIpsum.Split(" "c)
            Dim textBuilder As New StringBuilder()
            Dim random = New Random()
            Dim lineBuilder As New StringBuilder()
            For line As Integer = 0 To linesCount - 1
                lineBuilder.Clear()
                For word As Integer = 0 To lineLength - 1
                    lineBuilder.Append(words(random.Next(words.Length)))
                    If word < lineLength - 1 Then
                        lineBuilder.Append(" "c)
                    End If
                Next word
                lineBuilder.Append(". ")
                textBuilder.AppendLine(lineBuilder.ToString())
            Next line
            Return textBuilder.ToString()
        End Function
    End Class
End Namespace