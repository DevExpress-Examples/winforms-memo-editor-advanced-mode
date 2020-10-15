Namespace MemoEditSample
    Partial Public Class DemoView
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
            Me.spOptions = New DevExpress.XtraEditors.SidePanel()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbScrollBars = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
            Me.skinPaletteDropDownButtonItem1 = New DevExpress.XtraBars.SkinPaletteDropDownButtonItem()
            Me.bsiMode = New DevExpress.XtraBars.BarStaticItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.seLineLength = New DevExpress.XtraEditors.SpinEdit()
            Me.seLinesCount = New DevExpress.XtraEditors.SpinEdit()
            Me.ceLinesCount = New DevExpress.XtraEditors.CheckEdit()
            Me.ce50K = New DevExpress.XtraEditors.CheckEdit()
            Me.ce10K = New DevExpress.XtraEditors.CheckEdit()
            Me.ce1K = New DevExpress.XtraEditors.CheckEdit()
            Me.ceWordWrap = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.scrollBars = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.memoEdit = New DevExpress.XtraEditors.MemoEdit()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.spOptions.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seLineLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seLinesCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceLinesCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ce50K.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ce10K.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ce1K.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scrollBars, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType(Me.memoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spOptions
            ' 
            Me.spOptions.Controls.Add(Me.layoutControl1)
            Me.spOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptions.Location = New System.Drawing.Point(575, 0)
            Me.spOptions.Name = "spOptions"
            Me.spOptions.Size = New System.Drawing.Size(250, 447)
            Me.spOptions.TabIndex = 0
            Me.spOptions.Text = "sidePanel1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.icbScrollBars)
            Me.layoutControl1.Controls.Add(Me.seLineLength)
            Me.layoutControl1.Controls.Add(Me.seLinesCount)
            Me.layoutControl1.Controls.Add(Me.ceLinesCount)
            Me.layoutControl1.Controls.Add(Me.ce50K)
            Me.layoutControl1.Controls.Add(Me.ce10K)
            Me.layoutControl1.Controls.Add(Me.ce1K)
            Me.layoutControl1.Controls.Add(Me.ceWordWrap)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(1, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1157, 552, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(249, 447)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbScrollBars
            ' 
            Me.icbScrollBars.Location = New System.Drawing.Point(78, 38)
            Me.icbScrollBars.MenuManager = Me.barManager1
            Me.icbScrollBars.Name = "icbScrollBars"
            Me.icbScrollBars.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbScrollBars.Size = New System.Drawing.Size(159, 20)
            Me.icbScrollBars.StyleController = Me.layoutControl1
            Me.icbScrollBars.TabIndex = 14
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.skinDropDownButtonItem1, Me.skinPaletteDropDownButtonItem1, Me.bsiMode})
            Me.barManager1.MaxItemId = 7
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemHyperLinkEdit1})
            Me.barManager1.StatusBar = Me.bar1
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Custom 3"
            Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.skinDropDownButtonItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.skinPaletteDropDownButtonItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bsiMode)
            })
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Custom 3"
            ' 
            ' skinDropDownButtonItem1
            ' 
            Me.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.skinDropDownButtonItem1.Id = 3
            Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
            Me.skinDropDownButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' skinPaletteDropDownButtonItem1
            ' 
            Me.skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.skinPaletteDropDownButtonItem1.Id = 4
            Me.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1"
            Me.skinPaletteDropDownButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' bsiMode
            ' 
            Me.bsiMode.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bsiMode.Id = 5
            Me.bsiMode.Name = "bsiMode"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(825, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 447)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(825, 26)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 447)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(825, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 447)
            ' 
            ' repositoryItemHyperLinkEdit1
            ' 
            Me.repositoryItemHyperLinkEdit1.AutoHeight = False
            Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
            ' 
            ' seLineLength
            ' 
            Me.seLineLength.EditValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.seLineLength.Location = New System.Drawing.Point(12, 274)
            Me.seLineLength.Name = "seLineLength"
            Me.seLineLength.Properties.AutoHeight = False
            Me.seLineLength.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seLineLength.Size = New System.Drawing.Size(225, 20)
            Me.seLineLength.StyleController = Me.layoutControl1
            Me.seLineLength.TabIndex = 12
            ' 
            ' seLinesCount
            ' 
            Me.seLinesCount.EditValue = New Decimal(New Integer() { 100000, 0, 0, 0})
            Me.seLinesCount.Location = New System.Drawing.Point(153, 204)
            Me.seLinesCount.Name = "seLinesCount"
            Me.seLinesCount.Properties.AutoHeight = False
            Me.seLinesCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seLinesCount.Size = New System.Drawing.Size(84, 20)
            Me.seLinesCount.StyleController = Me.layoutControl1
            Me.seLinesCount.TabIndex = 10
            ' 
            ' ceLinesCount
            ' 
            Me.ceLinesCount.Location = New System.Drawing.Point(12, 204)
            Me.ceLinesCount.Name = "ceLinesCount"
            Me.ceLinesCount.Properties.Caption = "Enter sentences count"
            Me.ceLinesCount.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceLinesCount.Properties.RadioGroupIndex = 0
            Me.ceLinesCount.Size = New System.Drawing.Size(137, 20)
            Me.ceLinesCount.StyleController = Me.layoutControl1
            Me.ceLinesCount.TabIndex = 9
            Me.ceLinesCount.TabStop = False
            ' 
            ' ce50K
            ' 
            Me.ce50K.Location = New System.Drawing.Point(12, 180)
            Me.ce50K.Name = "ce50K"
            Me.ce50K.Properties.Caption = "50K"
            Me.ce50K.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ce50K.Properties.RadioGroupIndex = 0
            Me.ce50K.Size = New System.Drawing.Size(225, 20)
            Me.ce50K.StyleController = Me.layoutControl1
            Me.ce50K.TabIndex = 7
            Me.ce50K.TabStop = False
            ' 
            ' ce10K
            ' 
            Me.ce10K.Location = New System.Drawing.Point(12, 156)
            Me.ce10K.Name = "ce10K"
            Me.ce10K.Properties.Caption = "10K"
            Me.ce10K.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ce10K.Properties.RadioGroupIndex = 0
            Me.ce10K.Size = New System.Drawing.Size(225, 20)
            Me.ce10K.StyleController = Me.layoutControl1
            Me.ce10K.TabIndex = 6
            Me.ce10K.TabStop = False
            ' 
            ' ce1K
            ' 
            Me.ce1K.EditValue = True
            Me.ce1K.Location = New System.Drawing.Point(12, 132)
            Me.ce1K.Name = "ce1K"
            Me.ce1K.Properties.Caption = "1K"
            Me.ce1K.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ce1K.Properties.RadioGroupIndex = 0
            Me.ce1K.Size = New System.Drawing.Size(225, 20)
            Me.ce1K.StyleController = Me.layoutControl1
            Me.ce1K.TabIndex = 5
            ' 
            ' ceWordWrap
            ' 
            Me.ceWordWrap.Location = New System.Drawing.Point(78, 62)
            Me.ceWordWrap.Name = "ceWordWrap"
            Me.ceWordWrap.Properties.Caption = ""
            Me.ceWordWrap.Size = New System.Drawing.Size(159, 20)
            Me.ceWordWrap.StyleController = Me.layoutControl1
            Me.ceWordWrap.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(249, 447)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 306)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 141)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem6, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 94)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 142)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Sentences Count"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ce50K
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ce1K
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ce10K
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceLinesCount
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(141, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seLinesCount
            Me.layoutControlItem5.Location = New System.Drawing.Point(141, 72)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(88, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.scrollBars})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 94)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Layout"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceWordWrap
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 24)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(90, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.Text = "Word Wrap:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' scrollBars
            ' 
            Me.scrollBars.Control = Me.icbScrollBars
            Me.scrollBars.Location = New System.Drawing.Point(0, 0)
            Me.scrollBars.MaxSize = New System.Drawing.Size(0, 24)
            Me.scrollBars.MinSize = New System.Drawing.Size(120, 24)
            Me.scrollBars.Name = "scrollBars"
            Me.scrollBars.Size = New System.Drawing.Size(229, 24)
            Me.scrollBars.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.scrollBars.Text = "Scroll Bars:"
            Me.scrollBars.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem8})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 236)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 70)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Words Count"
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.seLineLength
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 24)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(54, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.memoEdit)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel2.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Padding = New System.Windows.Forms.Padding(20)
            Me.sidePanel2.Size = New System.Drawing.Size(575, 447)
            Me.sidePanel2.TabIndex = 1
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' memoEdit
            ' 
            Me.memoEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit.Location = New System.Drawing.Point(20, 20)
            Me.memoEdit.Name = "memoEdit"
            Me.memoEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.memoEdit.Properties.Appearance.Options.UseFont = True
            Me.memoEdit.Size = New System.Drawing.Size(535, 407)
            Me.memoEdit.TabIndex = 0
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(MemoEditSample.DemoViewModel)
            ' 
            ' DemoView
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel2)
            Me.Controls.Add(Me.spOptions)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "DemoView"
            Me.Size = New System.Drawing.Size(825, 473)
            Me.spOptions.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seLineLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seLinesCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceLinesCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ce50K.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ce10K.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ce1K.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scrollBars, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType(Me.memoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private spOptions As DevExpress.XtraEditors.SidePanel
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private ce10K As DevExpress.XtraEditors.CheckEdit
        Private ce1K As DevExpress.XtraEditors.CheckEdit
        Private ceWordWrap As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private ce50K As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private ceLinesCount As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private seLinesCount As DevExpress.XtraEditors.SpinEdit
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private sidePanel2 As DevExpress.XtraEditors.SidePanel
        Private memoEdit As DevExpress.XtraEditors.MemoEdit
        Private seLineLength As DevExpress.XtraEditors.SpinEdit
        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private icbScrollBars As DevExpress.XtraEditors.ImageComboBoxEdit
        Private scrollBars As DevExpress.XtraLayout.LayoutControlItem
        Private bar1 As DevExpress.XtraBars.Bar
        Private skinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
        Private skinPaletteDropDownButtonItem1 As DevExpress.XtraBars.SkinPaletteDropDownButtonItem
        Private bsiMode As DevExpress.XtraBars.BarStaticItem
        Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    End Class
End Namespace

