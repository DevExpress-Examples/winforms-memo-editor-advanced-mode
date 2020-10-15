Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils.MVVM.Services

Namespace MemoEditSample
    Partial Public Class DemoView
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            icbScrollBars.Properties.Items.AddEnum(GetType(ScrollBars))
            If Not mvvmContext.IsDesignMode Then
                InitializeBindings()
            End If
        End Sub
        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of DemoViewModel)()
            fluent.SetBinding(memoEdit, Function([me]) [me].RightToLeft, Function(x) x.RightToLeft)
            fluent.SetBinding(memoEdit.Properties, Function([me]) [me].WordWrap, Function(x) x.WordWrap)
            fluent.SetBinding(memoEdit.Properties, Function([me]) [me].UseAdvancedMode, Function(x) x.UseAdvancedMode)
            fluent.SetBinding(memoEdit.Properties, Function([me]) [me].ScrollBars, Function(x) x.ScrollBars)
            fluent.SetBinding(memoEdit.Properties.AdvancedModeOptions, Function([me]) [me].UseDirectXPaint, Function(x) x.UseDirectXPaint)
            fluent.SetBinding(memoEdit, Function([me]) [me].EditValue, Function(x) x.Text)

            fluent.SetBinding(ce1K, Function(ce) ce.Checked, Function(x) x.Use1K)
            fluent.SetBinding(ce10K, Function(ce) ce.Checked, Function(x) x.Use10K)
            fluent.SetBinding(ce50K, Function(ce) ce.Checked, Function(x) x.Use50K)

            fluent.SetBinding(icbScrollBars, Function(icb) icb.EditValue, Function(x) x.ScrollBars)
            fluent.SetBinding(ceWordWrap, Function(ce) ce.Checked, Function(x) x.WordWrap)
            fluent.SetBinding(ceLinesCount, Function(ce) ce.Checked, Function(x) x.UseCustomLinesCount)
            fluent.SetBinding(seLinesCount, Function(ce) ce.Enabled, Function(x) x.UseCustomLinesCount)

            fluent.SetBinding(seLinesCount, Function(se) se.EditValue, Function(x) x.CustomLinesCount)
            fluent.SetBinding(seLineLength, Function(se) se.EditValue, Function(x) x.LineLength)

            fluent.SetBinding(bsiMode, Function(bsi) bsi.Caption, Function(x) x.Mode)
        End Sub
    End Class
End Namespace