namespace MemoEditSample
{
    partial class SettingsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceRightToLeft = new DevExpress.XtraEditors.CheckEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.btnRunDemo = new DevExpress.XtraEditors.SimpleButton();
            this.rgMode = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceRightToLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceRightToLeft);
            this.layoutControl1.Controls.Add(this.lblDescription);
            this.layoutControl1.Controls.Add(this.btnRunDemo);
            this.layoutControl1.Controls.Add(this.rgMode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1135, 323, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(540, 284);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceRightToLeft
            // 
            this.ceRightToLeft.Location = new System.Drawing.Point(60, 205);
            this.ceRightToLeft.Name = "ceRightToLeft";
            this.ceRightToLeft.Properties.Caption = "Right to Left";
            this.ceRightToLeft.Size = new System.Drawing.Size(470, 20);
            this.ceRightToLeft.StyleController = this.layoutControl1;
            this.ceRightToLeft.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Appearance.Options.UseTextOptions = true;
            this.lblDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblDescription.Location = new System.Drawing.Point(40, 25);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(450, 60);
            this.lblDescription.StyleController = this.layoutControl1;
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // btnRunDemo
            // 
            this.btnRunDemo.Location = new System.Drawing.Point(430, 250);
            this.btnRunDemo.Name = "btnRunDemo";
            this.btnRunDemo.Size = new System.Drawing.Size(98, 22);
            this.btnRunDemo.StyleController = this.layoutControl1;
            this.btnRunDemo.TabIndex = 5;
            this.btnRunDemo.Text = "Run the Demo";
            // 
            // rgMode
            // 
            this.rgMode.EditValue = false;
            this.rgMode.Location = new System.Drawing.Point(60, 101);
            this.rgMode.Name = "rgMode";
            this.rgMode.Properties.AllowFocused = false;
            this.rgMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMode.Properties.Appearance.Options.UseBackColor = true;
            this.rgMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMode.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.rgMode.Size = new System.Drawing.Size(470, 89);
            this.rgMode.StyleController = this.layoutControl1;
            this.rgMode.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(540, 284);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgMode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 0, 2, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(520, 91);
            this.layoutControlItem1.Text = "Mode";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRunDemo;
            this.layoutControlItem2.Location = new System.Drawing.Point(418, 230);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(102, 34);
            this.layoutControlItem2.Text = "RunDemo";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lblDescription;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 30, 15, 14);
            this.layoutControlItem4.Size = new System.Drawing.Size(520, 89);
            this.layoutControlItem4.Text = "Header";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 230);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(418, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceRightToLeft;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 0, 15, 15);
            this.layoutControlItem3.Size = new System.Drawing.Size(520, 50);
            this.layoutControlItem3.Text = "lciRightToLeft";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(MemoEditSample.SettingsViewModel);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 284);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("SettingsView.IconOptions.Image")));
            this.Name = "SettingsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.layoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceRightToLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.RadioGroup rgMode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnRunDemo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.CheckEdit ceRightToLeft;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}