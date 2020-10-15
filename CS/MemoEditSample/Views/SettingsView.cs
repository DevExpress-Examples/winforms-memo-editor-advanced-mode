using System.Windows.Forms;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace MemoEditSample {
    public partial class SettingsView : XtraForm {
        public SettingsView() {
            InitializeComponent();
            rgMode.Properties.AddEnum<UserChoice>();
            if(!mvvmContext.IsDesignMode) 
                InitializeBindings();
            var service = WindowedDocumentManagerService.CreateXtraFormService(this);
            service.DocumentShowMode = WindowedDocumentManagerService.FormShowMode.Dialog;
            service.FormStyle = (form) => {
                ((XtraForm)form).IconOptions.Assign(this.IconOptions);
                form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                form.StartPosition = FormStartPosition.CenterScreen;
            };
            mvvmContext.RegisterService(service);
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<SettingsViewModel>();
            fluent.SetBinding(rgMode, rg => rg.EditValue, x => x.UserChoice);
            fluent.SetBinding(ceRightToLeft, ce => ce.Checked, x => x.UseRTL);
            fluent.BindCommand(btnRunDemo, x => x.RunDemo);
        }
    }
}