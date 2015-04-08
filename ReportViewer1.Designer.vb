<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportViewer1))
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TssDataSet = New New_Cases.TssDataSet()
        Me.TblNotEligibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNotEligibleTableAdapter = New New_Cases.TssDataSetTableAdapters.tblNotEligibleTableAdapter()
        Me.TableAdapterManager = New New_Cases.TssDataSetTableAdapters.TableAdapterManager()
        Me.TblNotEligibleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblNotEligibleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TblNotEligibleGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MatchOfnDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewOfnDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstrMatchCasenum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Casenum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Address1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.City = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.State = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Zip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.coldtmRunDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colstrDrlicnum = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn3 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn4 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn5 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn6 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn7 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn8 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colstrCnAdress2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn9 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn10 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewColumn11 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.coldtmCnDob = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colstrCnSex = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colstrCnBranch = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colstrCnMuni = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.coldtmCnReturnDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.TssDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNotEligibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNotEligibleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblNotEligibleBindingNavigator.SuspendLayout()
        CType(Me.TblNotEligibleGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer"
        Me.ReportViewer2.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer2.TabIndex = 0
        '
        'TssDataSet
        '
        Me.TssDataSet.DataSetName = "TssDataSet"
        Me.TssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNotEligibleBindingSource
        '
        Me.TblNotEligibleBindingSource.DataMember = "tblNotEligible"
        Me.TblNotEligibleBindingSource.DataSource = Me.TssDataSet
        '
        'TblNotEligibleTableAdapter
        '
        Me.TblNotEligibleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = New_Cases.TssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblNotEligibleBindingNavigator
        '
        Me.TblNotEligibleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblNotEligibleBindingNavigator.BindingSource = Me.TblNotEligibleBindingSource
        Me.TblNotEligibleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblNotEligibleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblNotEligibleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblNotEligibleBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.TblNotEligibleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblNotEligibleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblNotEligibleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblNotEligibleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblNotEligibleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblNotEligibleBindingNavigator.Name = "TblNotEligibleBindingNavigator"
        Me.TblNotEligibleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblNotEligibleBindingNavigator.Size = New System.Drawing.Size(829, 25)
        Me.TblNotEligibleBindingNavigator.TabIndex = 0
        Me.TblNotEligibleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblNotEligibleBindingNavigatorSaveItem
        '
        Me.TblNotEligibleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblNotEligibleBindingNavigatorSaveItem.Enabled = False
        Me.TblNotEligibleBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblNotEligibleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblNotEligibleBindingNavigatorSaveItem.Name = "TblNotEligibleBindingNavigatorSaveItem"
        Me.TblNotEligibleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblNotEligibleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TblNotEligibleGridControl
        '
        Me.TblNotEligibleGridControl.DataSource = Me.TblNotEligibleBindingSource
        Me.TblNotEligibleGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblNotEligibleGridControl.Location = New System.Drawing.Point(0, 25)
        Me.TblNotEligibleGridControl.MainView = Me.GridView1
        Me.TblNotEligibleGridControl.Name = "TblNotEligibleGridControl"
        Me.TblNotEligibleGridControl.Size = New System.Drawing.Size(829, 449)
        Me.TblNotEligibleGridControl.TabIndex = 1
        Me.TblNotEligibleGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MatchOfnDate, Me.NewOfnDate, Me.colstrMatchCasenum, Me.Casenum, Me.FName, Me.MI, Me.LName, Me.Address1, Me.City, Me.State, Me.Zip})
        Me.GridView1.GridControl = Me.TblNotEligibleGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        '
        'MatchOfnDate
        '
        Me.MatchOfnDate.Caption = "MatchOfnDate"
        Me.MatchOfnDate.FieldName = "dtmMatchOfnDate"
        Me.MatchOfnDate.Name = "MatchOfnDate"
        Me.MatchOfnDate.Visible = True
        Me.MatchOfnDate.VisibleIndex = 0
        Me.MatchOfnDate.Width = 117
        '
        'NewOfnDate
        '
        Me.NewOfnDate.Caption = "NewOfnDate"
        Me.NewOfnDate.FieldName = "dtmNewOfnDate"
        Me.NewOfnDate.Name = "NewOfnDate"
        Me.NewOfnDate.Visible = True
        Me.NewOfnDate.VisibleIndex = 1
        Me.NewOfnDate.Width = 109
        '
        'colstrMatchCasenum
        '
        Me.colstrMatchCasenum.Caption = "MatchCase"
        Me.colstrMatchCasenum.FieldName = "strMatchCasenum"
        Me.colstrMatchCasenum.Name = "colstrMatchCasenum"
        Me.colstrMatchCasenum.Visible = True
        Me.colstrMatchCasenum.VisibleIndex = 2
        Me.colstrMatchCasenum.Width = 112
        '
        'Casenum
        '
        Me.Casenum.Caption = "Case"
        Me.Casenum.FieldName = "strNewCasenum"
        Me.Casenum.Name = "Casenum"
        Me.Casenum.Visible = True
        Me.Casenum.VisibleIndex = 3
        Me.Casenum.Width = 104
        '
        'FName
        '
        Me.FName.Caption = "FName"
        Me.FName.FieldName = "strCnFName"
        Me.FName.Name = "FName"
        Me.FName.Visible = True
        Me.FName.VisibleIndex = 4
        Me.FName.Width = 100
        '
        'MI
        '
        Me.MI.Caption = "MI"
        Me.MI.FieldName = "strCnMName"
        Me.MI.Name = "MI"
        Me.MI.Visible = True
        Me.MI.VisibleIndex = 5
        Me.MI.Width = 87
        '
        'LName
        '
        Me.LName.Caption = "LName"
        Me.LName.FieldName = "strCnLName"
        Me.LName.Name = "LName"
        Me.LName.Visible = True
        Me.LName.VisibleIndex = 6
        Me.LName.Width = 140
        '
        'Address1
        '
        Me.Address1.Caption = "Address1"
        Me.Address1.FieldName = "strCnAdress1"
        Me.Address1.Name = "Address1"
        Me.Address1.Visible = True
        Me.Address1.VisibleIndex = 7
        Me.Address1.Width = 167
        '
        'City
        '
        Me.City.Caption = "City"
        Me.City.FieldName = "strCnCity"
        Me.City.Name = "City"
        Me.City.Visible = True
        Me.City.VisibleIndex = 8
        Me.City.Width = 128
        '
        'State
        '
        Me.State.Caption = "State"
        Me.State.FieldName = "strCnState"
        Me.State.Name = "State"
        Me.State.Visible = True
        Me.State.VisibleIndex = 9
        Me.State.Width = 78
        '
        'Zip
        '
        Me.Zip.Caption = "Zip"
        Me.Zip.FieldName = "strCnZip"
        Me.Zip.Name = "Zip"
        Me.Zip.Visible = True
        Me.Zip.VisibleIndex = 10
        Me.Zip.Width = 66
        '
        'LayoutView1
        '
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.coldtmRunDate, Me.LayoutViewColumn1, Me.colstrDrlicnum, Me.LayoutViewColumn2, Me.LayoutViewColumn3, Me.LayoutViewColumn4, Me.LayoutViewColumn5, Me.LayoutViewColumn6, Me.LayoutViewColumn7, Me.LayoutViewColumn8, Me.colstrCnAdress2, Me.LayoutViewColumn9, Me.LayoutViewColumn10, Me.LayoutViewColumn11, Me.coldtmCnDob, Me.colstrCnSex, Me.colstrCnBranch, Me.colstrCnMuni, Me.coldtmCnReturnDate})
        Me.LayoutView1.GridControl = Me.TblNotEligibleGridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'coldtmRunDate
        '
        Me.coldtmRunDate.FieldName = "dtmRunDate"
        Me.coldtmRunDate.LayoutViewField = Nothing
        Me.coldtmRunDate.Name = "coldtmRunDate"
        '
        'LayoutViewColumn1
        '
        Me.LayoutViewColumn1.FieldName = "strNewCasenum"
        Me.LayoutViewColumn1.LayoutViewField = Nothing
        Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
        '
        'colstrDrlicnum
        '
        Me.colstrDrlicnum.FieldName = "strDrlicnum"
        Me.colstrDrlicnum.LayoutViewField = Nothing
        Me.colstrDrlicnum.Name = "colstrDrlicnum"
        '
        'LayoutViewColumn2
        '
        Me.LayoutViewColumn2.FieldName = "dtmNewOfnDate"
        Me.LayoutViewColumn2.LayoutViewField = Nothing
        Me.LayoutViewColumn2.Name = "LayoutViewColumn2"
        '
        'LayoutViewColumn3
        '
        Me.LayoutViewColumn3.FieldName = "strMatchCasenum"
        Me.LayoutViewColumn3.LayoutViewField = Nothing
        Me.LayoutViewColumn3.Name = "LayoutViewColumn3"
        '
        'LayoutViewColumn4
        '
        Me.LayoutViewColumn4.FieldName = "dtmMatchOfnDate"
        Me.LayoutViewColumn4.LayoutViewField = Nothing
        Me.LayoutViewColumn4.Name = "LayoutViewColumn4"
        '
        'LayoutViewColumn5
        '
        Me.LayoutViewColumn5.FieldName = "strCnLName"
        Me.LayoutViewColumn5.LayoutViewField = Nothing
        Me.LayoutViewColumn5.Name = "LayoutViewColumn5"
        '
        'LayoutViewColumn6
        '
        Me.LayoutViewColumn6.FieldName = "strCnFName"
        Me.LayoutViewColumn6.LayoutViewField = Nothing
        Me.LayoutViewColumn6.Name = "LayoutViewColumn6"
        '
        'LayoutViewColumn7
        '
        Me.LayoutViewColumn7.FieldName = "strCnMName"
        Me.LayoutViewColumn7.LayoutViewField = Nothing
        Me.LayoutViewColumn7.Name = "LayoutViewColumn7"
        '
        'LayoutViewColumn8
        '
        Me.LayoutViewColumn8.FieldName = "strCnAdress1"
        Me.LayoutViewColumn8.LayoutViewField = Nothing
        Me.LayoutViewColumn8.Name = "LayoutViewColumn8"
        '
        'colstrCnAdress2
        '
        Me.colstrCnAdress2.FieldName = "strCnAdress2"
        Me.colstrCnAdress2.LayoutViewField = Nothing
        Me.colstrCnAdress2.Name = "colstrCnAdress2"
        '
        'LayoutViewColumn9
        '
        Me.LayoutViewColumn9.FieldName = "strCnCity"
        Me.LayoutViewColumn9.LayoutViewField = Nothing
        Me.LayoutViewColumn9.Name = "LayoutViewColumn9"
        '
        'LayoutViewColumn10
        '
        Me.LayoutViewColumn10.FieldName = "strCnState"
        Me.LayoutViewColumn10.LayoutViewField = Nothing
        Me.LayoutViewColumn10.Name = "LayoutViewColumn10"
        '
        'LayoutViewColumn11
        '
        Me.LayoutViewColumn11.FieldName = "strCnZip"
        Me.LayoutViewColumn11.LayoutViewField = Nothing
        Me.LayoutViewColumn11.Name = "LayoutViewColumn11"
        '
        'coldtmCnDob
        '
        Me.coldtmCnDob.FieldName = "dtmCnDob"
        Me.coldtmCnDob.LayoutViewField = Nothing
        Me.coldtmCnDob.Name = "coldtmCnDob"
        '
        'colstrCnSex
        '
        Me.colstrCnSex.FieldName = "strCnSex"
        Me.colstrCnSex.LayoutViewField = Nothing
        Me.colstrCnSex.Name = "colstrCnSex"
        '
        'colstrCnBranch
        '
        Me.colstrCnBranch.FieldName = "strCnBranch"
        Me.colstrCnBranch.LayoutViewField = Nothing
        Me.colstrCnBranch.Name = "colstrCnBranch"
        '
        'colstrCnMuni
        '
        Me.colstrCnMuni.FieldName = "strCnMuni"
        Me.colstrCnMuni.LayoutViewField = Nothing
        Me.colstrCnMuni.Name = "colstrCnMuni"
        '
        'coldtmCnReturnDate
        '
        Me.coldtmCnReturnDate.FieldName = "dtmCnReturnDate"
        Me.coldtmCnReturnDate.LayoutViewField = Nothing
        Me.coldtmCnReturnDate.Name = "coldtmCnReturnDate"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer"
        Me.ReportViewer3.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer3.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 474)
        Me.Controls.Add(Me.TblNotEligibleGridControl)
        Me.Controls.Add(Me.TblNotEligibleBindingNavigator)
        Me.Name = "ReportViewer1"
        Me.Text = "ReportViewer1"
        CType(Me.TssDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNotEligibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNotEligibleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblNotEligibleBindingNavigator.ResumeLayout(False)
        Me.TblNotEligibleBindingNavigator.PerformLayout()
        CType(Me.TblNotEligibleGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TssDataSet As New_Cases.TssDataSet
    Friend WithEvents TblNotEligibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblNotEligibleTableAdapter As New_Cases.TssDataSetTableAdapters.tblNotEligibleTableAdapter
    Friend WithEvents TableAdapterManager As New_Cases.TssDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblNotEligibleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblNotEligibleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblNotEligibleGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MatchOfnDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewOfnDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrMatchCasenum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Casenum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Address1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents City As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents State As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Zip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents coldtmRunDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colstrDrlicnum As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn3 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn4 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn6 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn7 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn8 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colstrCnAdress2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn9 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn10 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumn11 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents coldtmCnDob As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colstrCnSex As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colstrCnBranch As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colstrCnMuni As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents coldtmCnReturnDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
End Class
