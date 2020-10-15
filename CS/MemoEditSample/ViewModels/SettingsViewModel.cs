namespace MemoEditSample {
    using System.Windows.Forms;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.XtraEditors;
    using System.ComponentModel.DataAnnotations;

    public enum UserChoice {
        [Display(Name = "Standard Mode")]
        StandardMode,
        [Display(Name = "Advanced Mode (DirectX)")]
        AdvancedViaDirectX,
        [Display(Name = "Advanced Mode (Gdi)")]
        AdvancedViaGdi
    }
    //
    public class SettingsViewModel {
        public string Title {
            get { return "MemoEdit Demo"; }
        }
        public string Mode {
            get { return EnumDisplayTextHelper.GetDisplayText(UserChoice); }
        }
        public virtual bool UseAdvancedMode {
            get;
            protected set;
        }
        public virtual bool UseDirectX {
            get;
            protected set;
        }
        public virtual UserChoice UserChoice {
            get;
            set;
        }
        public virtual bool UseRTL {
            get;
            set;
        }
        protected void OnUserChoiceChanged() {
            switch(UserChoice) {
                case UserChoice.StandardMode:
                    UseAdvancedMode = UseDirectX = false;
                    break;
                case UserChoice.AdvancedViaDirectX:
                    UseAdvancedMode = UseDirectX = true;
                    break;
                case UserChoice.AdvancedViaGdi:
                    UseAdvancedMode = true;
                    UseDirectX = false;
                    break;
            }
        }
        protected IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>(); }
        }
        public void RunDemo() {
            var currentWindow = this.GetRequiredService<ICurrentWindowService>();
            currentWindow.Hide();
            try {
                var demoViewModel = DemoViewModel.Create();
                demoViewModel.SetParentViewModel(this);
                var document = DocumentManagerService.CreateDocument(nameof(DemoView), demoViewModel);
                document.Title = Title;
                document.Show();
            }
            finally {
                currentWindow.Show();
            }
        }
        void UpdateCommands() {
            this.RaiseCanExecuteChanged(x => x.RunDemo());
        }
    }
}