using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
using MemoEditSample.Properties;
using System;
using System.Text;
using System.Windows.Forms;

namespace MemoEditSample {
    public class DemoViewModel {
        public static DemoViewModel Create() {
            return ViewModelSource<DemoViewModel>.Create();
        }
        //
        bool isReady;
        protected DemoViewModel() {
            LinesCount = 1000;
            LineLength = 50;
            CustomLinesCount = 100000;
            Text = GetText(LinesCount, LineLength);
            isReady = true;
            WordWrap = true;
            ScrollBars = ScrollBars.Both;
        }
        public RightToLeft RightToLeft {
            get { return this.GetParentViewModel<SettingsViewModel>().UseRTL ? RightToLeft.Yes : RightToLeft.Inherit; }
        }
        public DefaultBoolean UseAdvancedMode {
            get { return this.GetParentViewModel<SettingsViewModel>().UseAdvancedMode ? DefaultBoolean.True : DefaultBoolean.Default; }
        }
        public DefaultBoolean UseDirectXPaint {
            get { return this.GetParentViewModel<SettingsViewModel>().UseDirectX ? DefaultBoolean.True : DefaultBoolean.Default; }
        }
        public string Mode {
            get { return this.GetParentViewModel<SettingsViewModel>().Mode; }
        }
        public virtual ScrollBars ScrollBars {
            get;
            set;
        }
        public virtual string Text {
            get;
            protected set;
        }
        public virtual int LinesCount {
            get;
            set;
        }
        public virtual int LineLength {
            get;
            set;
        }
        public virtual bool WordWrap {
            get;
            set;
        }
        protected void OnLinesCountChanged() {
            UpdateText();
            this.RaisePropertyChanged(x => x.Use1K);
            this.RaisePropertyChanged(x => x.Use10K);
            this.RaisePropertyChanged(x => x.Use50K);
            this.RaisePropertyChanged(x => x.UseCustomLinesCount);
            this.RaisePropertyChanged(x => x.CustomLinesCount);
            this.RaiseCanExecuteChanged(x => x.GenerateCustomLines());
        }
        protected void OnLineLengthChanged() {
            UpdateText();
        }
        public bool Use1K {
            get { return LinesCount == 1000; }
            set { LinesCount = 1000; }
        }
        public bool Use10K {
            get { return LinesCount == 10000; }
            set { LinesCount = 10000; }
        }
        public bool Use50K {
            get { return LinesCount == 50000; }
            set { LinesCount = 50000; }
        }
        public bool UseCustomLinesCount {
            get { return LinesCount == CustomLinesCount; }
            set { LinesCount = CustomLinesCount; }
        }
        public virtual int CustomLinesCount {
            get;
            set;
        }
        protected void OnCustomLinesCountChanged() {
            if(isReady)
                LinesCount = CustomLinesCount;
        }
        public void GenerateCustomLines() {
            UpdateText();
        }
        void UpdateText() {
            if(!isReady)
                return;
            var overlay = this.GetService<ISplashScreenService>();
            try {
                overlay.ShowSplashScreen("#Overlay#");
                Text = GetText(LinesCount, LineLength);
            }
            finally {
                overlay.HideSplashScreen();
            }
        }
        //
        static string GetText(int linesCount, int lineLength = 10) {
            string[] words = Resources.LoremIpsum.Split(' ');
            StringBuilder textBuilder = new StringBuilder();
            var random = new Random();
            StringBuilder lineBuilder = new StringBuilder();
            for(int line = 0; line < linesCount; line++) {
                lineBuilder.Clear();
                for(int word = 0; word < lineLength; word++) {
                    lineBuilder.Append(words[random.Next(words.Length)]);
                    if(word < lineLength - 1)
                        lineBuilder.Append(' ');
                }
                lineBuilder.Append(". ");
                textBuilder.AppendLine(lineBuilder.ToString());
            }
            return textBuilder.ToString();
        }
    }
}