Namespace MemoEditSample
    Partial Public Class SettingsView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SettingsView))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceRightToLeft = New DevExpress.XtraEditors.CheckEdit()
            Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
            Me.btnRunDemo = New DevExpress.XtraEditors.SimpleButton()
            Me.rgMode = New DevExpress.XtraEditors.RadioGroup()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.ceRightToLeft.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.ceRightToLeft)
            Me.layoutControl1.Controls.Add(Me.lblDescription)
            Me.layoutControl1.Controls.Add(Me.btnRunDemo)
            Me.layoutControl1.Controls.Add(Me.rgMode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1135, 323, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(540, 284)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceRightToLeft
            ' 
            Me.ceRightToLeft.Location = New System.Drawing.Point(60, 205)
            Me.ceRightToLeft.Name = "ceRightToLeft"
            Me.ceRightToLeft.Properties.Caption = "Right to Left"
            Me.ceRightToLeft.Size = New System.Drawing.Size(470, 20)
            Me.ceRightToLeft.StyleController = Me.layoutControl1
            Me.ceRightToLeft.TabIndex = 8
            ' 
            ' lblDescription
            ' 
            Me.lblDescription.Appearance.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.lblDescription.Appearance.Options.UseFont = True
            Me.lblDescription.Appearance.Options.UseTextOptions = True
            Me.lblDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.lblDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lblDescription.Location = New System.Drawing.Point(40, 25)
            Me.lblDescription.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(450, 60)
            Me.lblDescription.StyleController = Me.layoutControl1
            Me.lblDescription.TabIndex = 7
            Me.lblDescription.Text = resources.GetString("lblDescription.Text")
            ' 
            ' btnRunDemo
            ' 
            Me.btnRunDemo.Location = New System.Drawing.Point(430, 250)
            Me.btnRunDemo.Name = "btnRunDemo"
            Me.btnRunDemo.Size = New System.Drawing.Size(98, 22)
            Me.btnRunDemo.StyleController = Me.layoutControl1
            Me.btnRunDemo.TabIndex = 5
            Me.btnRunDemo.Text = "Run the Demo"
            ' 
            ' rgMode
            ' 
            Me.rgMode.EditValue = False
            Me.rgMode.Location = New System.Drawing.Point(60, 101)
            Me.rgMode.Name = "rgMode"
            Me.rgMode.Properties.AllowFocused = False
            Me.rgMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMode.Properties.Appearance.Options.UseBackColor = True
            Me.rgMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMode.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.rgMode.Size = New System.Drawing.Size(470, 89)
            Me.rgMode.StyleController = Me.layoutControl1
            Me.rgMode.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.emptySpaceItem3, Me.layoutControlItem3})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(540, 284)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.rgMode
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 89)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(50, 0, 2, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(520, 91)
            Me.layoutControlItem1.Text = "Mode"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.btnRunDemo
            Me.layoutControlItem2.Location = New System.Drawing.Point(418, 230)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItem2.Size = New System.Drawing.Size(102, 34)
            Me.layoutControlItem2.Text = "RunDemo"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.lblDescription
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(30, 30, 15, 14)
            Me.layoutControlItem4.Size = New System.Drawing.Size(520, 89)
            Me.layoutControlItem4.Text = "Header"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 230)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(418, 34)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceRightToLeft
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 180)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(50, 0, 15, 15)
            Me.layoutControlItem3.Size = New System.Drawing.Size(520, 50)
            Me.layoutControlItem3.Text = "lciRightToLeft"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(MemoEditSample.SettingsViewModel)
            ' 
            ' SettingsView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(540, 284)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.IconOptions.Image = (CType(resources.GetObject("SettingsView.IconOptions.Image"), System.Drawing.Image))
            Me.Name = "SettingsView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Settings"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            Me.layoutControl1.PerformLayout()
            CType(Me.ceRightToLeft.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private rgMode As DevExpress.XtraEditors.RadioGroup
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private btnRunDemo As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private lblDescription As DevExpress.XtraEditors.LabelControl
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private ceRightToLeft As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace