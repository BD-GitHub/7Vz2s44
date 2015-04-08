<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmReportDate
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
        'VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    '	If Disposing Then
    '		VB6_RemoveADODataBinding()
    '		If Not components Is Nothing Then
    '			components.Dispose()
    '		End If
    '	End If
    '	MyBase.Dispose(Disposing)
    'End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'Private ADOBind_Adodc1 As VB6.MBindingCollection
	Public WithEvents cboExit As System.Windows.Forms.Button
	Public WithEvents cboPrint As System.Windows.Forms.Button
	Public WithEvents cboPreview As System.Windows.Forms.Button
	Public WithEvents tboDate As System.Windows.Forms.TextBox
    Public WithEvents lblTitle As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboExit = New System.Windows.Forms.Button()
        Me.cboPrint = New System.Windows.Forms.Button()
        Me.cboPreview = New System.Windows.Forms.Button()
        Me.tboDate = New System.Windows.Forms.TextBox()
        Me.TblNotEligibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TssDataSet = New New_Cases.TssDataSet()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.TblNotEligibleTableAdapter = New New_Cases.TssDataSetTableAdapters.tblNotEligibleTableAdapter()
        CType(Me.TblNotEligibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TssDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboExit
        '
        Me.cboExit.BackColor = System.Drawing.SystemColors.Control
        Me.cboExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboExit.Location = New System.Drawing.Point(168, 88)
        Me.cboExit.Name = "cboExit"
        Me.cboExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboExit.Size = New System.Drawing.Size(97, 33)
        Me.cboExit.TabIndex = 4
        Me.cboExit.Text = "Exit"
        Me.cboExit.UseVisualStyleBackColor = False
        '
        'cboPrint
        '
        Me.cboPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cboPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPrint.Location = New System.Drawing.Point(32, 88)
        Me.cboPrint.Name = "cboPrint"
        Me.cboPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPrint.Size = New System.Drawing.Size(97, 33)
        Me.cboPrint.TabIndex = 3
        Me.cboPrint.Text = "Print Report"
        Me.cboPrint.UseVisualStyleBackColor = False
        '
        'cboPreview
        '
        Me.cboPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cboPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPreview.Location = New System.Drawing.Point(16, 136)
        Me.cboPreview.Name = "cboPreview"
        Me.cboPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPreview.Size = New System.Drawing.Size(81, 33)
        Me.cboPreview.TabIndex = 2
        Me.cboPreview.Text = "Print Preview"
        Me.cboPreview.UseVisualStyleBackColor = False
        Me.cboPreview.Visible = False
        '
        'tboDate
        '
        Me.tboDate.AcceptsReturn = True
        Me.tboDate.BackColor = System.Drawing.SystemColors.Window
        Me.tboDate.CausesValidation = False
        Me.tboDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tboDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNotEligibleBindingSource, "dtmRunDate", True))
        Me.tboDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tboDate.Location = New System.Drawing.Point(32, 32)
        Me.tboDate.MaxLength = 0
        Me.tboDate.Name = "tboDate"
        Me.tboDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tboDate.Size = New System.Drawing.Size(129, 20)
        Me.tboDate.TabIndex = 0
        Me.tboDate.Text = "tboDate"
        '
        'TblNotEligibleBindingSource
        '
        Me.TblNotEligibleBindingSource.DataMember = "tblNotEligible"
        Me.TblNotEligibleBindingSource.DataSource = Me.TssDataSet
        '
        'TssDataSet
        '
        Me.TssDataSet.DataSetName = "TssDataSet"
        Me.TssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(32, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(241, 17)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Select Report Run Date Below:"
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Enabled = False
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Enabled = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Enabled = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Enabled = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Enabled = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Enabled = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataNavigator1.CausesValidation = False
        Me.DataNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton()})
        Me.DataNavigator1.DataBindings.Add(New System.Windows.Forms.Binding("DataSource", Me.TblNotEligibleBindingSource, "dtmRunDate", True))
        Me.DataNavigator1.DataMember = Nothing
        Me.DataNavigator1.DataSource = Me.TblNotEligibleBindingSource
        Me.DataNavigator1.Location = New System.Drawing.Point(157, 170)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(180, 24)
        Me.DataNavigator1.TabIndex = 6
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'TblNotEligibleTableAdapter
        '
        Me.TblNotEligibleTableAdapter.ClearBeforeFill = True
        '
        'frmReportDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(341, 206)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.cboExit)
        Me.Controls.Add(Me.cboPrint)
        Me.Controls.Add(Me.cboPreview)
        Me.Controls.Add(Me.tboDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(131, 142)
        Me.Name = "frmReportDate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select Report Record Date"
        CType(Me.TblNotEligibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TssDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
#Region "Upgrade Support"
    'Public Sub VB6_AddADODataBinding()
    '	ADOBind_Adodc1 = New VB6.MBindingCollection()
    '	ADOBind_Adodc1.DataSource = CType(Adodc1, MSDATASRC.DataSource)
    '	ADOBind_Adodc1.Add(tboDate, "Text", "dtmRunDate", Nothing, "tboDate")
    '	ADOBind_Adodc1.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
    '	ADOBind_Adodc1.UpdateControls()
    'End Sub
    'Public Sub VB6_RemoveADODataBinding()
    '	ADOBind_Adodc1.Clear()
    '	ADOBind_Adodc1.Dispose()
    '	ADOBind_Adodc1 = Nothing
    '   End Sub
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents TssDataSet As New_Cases.TssDataSet
    Friend WithEvents TblNotEligibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblNotEligibleTableAdapter As New_Cases.TssDataSetTableAdapters.tblNotEligibleTableAdapter
#End Region
End Class