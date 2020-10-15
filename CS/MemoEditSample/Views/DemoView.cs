using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.Services;

namespace MemoEditSample {
    public partial class DemoView : XtraUserControl {
        public DemoView() {
            InitializeComponent();
            icbScrollBars.Properties.Items.AddEnum(typeof(ScrollBars));
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<DemoViewModel>();
            fluent.SetBinding(memoEdit, me => me.RightToLeft, x => x.RightToLeft);
            fluent.SetBinding(memoEdit.Properties, me => me.WordWrap, x => x.WordWrap);
            fluent.SetBinding(memoEdit.Properties, me => me.UseAdvancedMode, x => x.UseAdvancedMode);
            fluent.SetBinding(memoEdit.Properties, me => me.ScrollBars, x => x.ScrollBars);
            fluent.SetBinding(memoEdit.Properties.AdvancedModeOptions, me => me.UseDirectXPaint, x => x.UseDirectXPaint);
            fluent.SetBinding(memoEdit, me => me.EditValue, x => x.Text);

            fluent.SetBinding(ce1K, ce => ce.Checked, x => x.Use1K);
            fluent.SetBinding(ce10K, ce => ce.Checked, x => x.Use10K);
            fluent.SetBinding(ce50K, ce => ce.Checked, x => x.Use50K);

            fluent.SetBinding(icbScrollBars, icb => icb.EditValue, x => x.ScrollBars);
            fluent.SetBinding(ceWordWrap, ce => ce.Checked, x => x.WordWrap);
            fluent.SetBinding(ceLinesCount, ce => ce.Checked, x => x.UseCustomLinesCount);
            fluent.SetBinding(seLinesCount, ce => ce.Enabled, x => x.UseCustomLinesCount);

            fluent.SetBinding(seLinesCount, se => se.EditValue, x => x.CustomLinesCount);
            fluent.SetBinding(seLineLength, se => se.EditValue, x => x.LineLength);

            fluent.SetBinding(bsiMode, bsi => bsi.Caption, x => x.Mode);
        }
    }
}