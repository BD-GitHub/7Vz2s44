<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmReportDate
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Private ADOBind_Adodc1 As VB6.MBindingCollection
	Public WithEvents cboExit As System.Windows.Forms.Button
	Public WithEvents cboPrint As System.Windows.Forms.Button
	Public WithEvents cboPreview As System.Windows.Forms.Button
	Public WithEvents tboDate As System.Windows.Forms.TextBox
	Public WithEvents Adodc1 As VB6.ADODC
	Public WithEvents lblTitle As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReportDate))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboExit = New System.Windows.Forms.Button
		Me.cboPrint = New System.Windows.Forms.Button
		Me.cboPreview = New System.Windows.Forms.Button
		Me.tboDate = New System.Windows.Forms.TextBox
		Me.Adodc1 = New VB6.ADODC
		Me.lblTitle = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Text = "Select Report Record Date"
		Me.ClientSize = New System.Drawing.Size(341, 206)
		Me.Location = New System.Drawing.Point(131, 142)
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmReportDate"
		Me.cboExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboExit.Text = "Exit"
		Me.cboExit.Size = New System.Drawing.Size(97, 33)
		Me.cboExit.Location = New System.Drawing.Point(168, 88)
		Me.cboExit.TabIndex = 4
		Me.cboExit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboExit.BackColor = System.Drawing.SystemColors.Control
		Me.cboExit.CausesValidation = True
		Me.cboExit.Enabled = True
		Me.cboExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboExit.TabStop = True
		Me.cboExit.Name = "cboExit"
		Me.cboPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboPrint.Text = "Print Report"
		Me.cboPrint.Size = New System.Drawing.Size(97, 33)
		Me.cboPrint.Location = New System.Drawing.Point(32, 88)
		Me.cboPrint.TabIndex = 3
		Me.cboPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cboPrint.CausesValidation = True
		Me.cboPrint.Enabled = True
		Me.cboPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPrint.TabStop = True
		Me.cboPrint.Name = "cboPrint"
		Me.cboPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboPreview.Text = "Print Preview"
		Me.cboPreview.Size = New System.Drawing.Size(81, 33)
		Me.cboPreview.Location = New System.Drawing.Point(16, 136)
		Me.cboPreview.TabIndex = 2
		Me.cboPreview.Visible = False
		Me.cboPreview.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPreview.BackColor = System.Drawing.SystemColors.Control
		Me.cboPreview.CausesValidation = True
		Me.cboPreview.Enabled = True
		Me.cboPreview.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboPreview.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPreview.TabStop = True
		Me.cboPreview.Name = "cboPreview"
		Me.tboDate.AutoSize = False
		Me.tboDate.Size = New System.Drawing.Size(129, 25)
		Me.tboDate.Location = New System.Drawing.Point(32, 32)
		Me.tboDate.TabIndex = 0
		Me.tboDate.Text = "tboDate"
		Me.tboDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tboDate.AcceptsReturn = True
		Me.tboDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.tboDate.BackColor = System.Drawing.SystemColors.Window
		Me.tboDate.CausesValidation = True
		Me.tboDate.Enabled = True
		Me.tboDate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.tboDate.HideSelection = True
		Me.tboDate.ReadOnly = False
		Me.tboDate.Maxlength = 0
		Me.tboDate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.tboDate.MultiLine = False
		Me.tboDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.tboDate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.tboDate.TabStop = True
		Me.tboDate.Visible = True
		Me.tboDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.tboDate.Name = "tboDate"
		Me.Adodc1.Size = New System.Drawing.Size(81, 25)
		Me.Adodc1.Location = New System.Drawing.Point(188, 32)
		Me.Adodc1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 30
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdText
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
        'Me.Adodc1.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
        'Me.Adodc1.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText
        'Me.Adodc1.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.Adodc1.Enabled = True
		Me.Adodc1.UserName = ""
		Me.Adodc1.RecordSource = "SELECT dtmRunDate, Count(dtmRunDate)as 'Total'" & Chr(13) & Chr(10) & "FROM NotEligible" & Chr(13) & Chr(10) & "Group By dtmRunDate" & Chr(13) & Chr(10) & "Order By dtmRunDate DESC"
		Me.Adodc1.Text = "Adodc1"
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;Data Source=TssQry;Initial Catalog=Tss"
		Me.Adodc1.Name = "Adodc1"
		Me.lblTitle.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.lblTitle.Text = "Select Report Run Date Below:"
		Me.lblTitle.Size = New System.Drawing.Size(241, 17)
		Me.lblTitle.Location = New System.Drawing.Point(32, 8)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.Enabled = True
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me.Controls.Add(cboExit)
		Me.Controls.Add(cboPrint)
		Me.Controls.Add(cboPreview)
		Me.Controls.Add(tboDate)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(lblTitle)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		ADOBind_Adodc1 = New VB6.MBindingCollection()
		ADOBind_Adodc1.DataSource = CType(Adodc1, MSDATASRC.DataSource)
		ADOBind_Adodc1.Add(tboDate, "Text", "dtmRunDate", Nothing, "tboDate")
		ADOBind_Adodc1.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_Adodc1.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_Adodc1.Clear()
		ADOBind_Adodc1.Dispose()
		ADOBind_Adodc1 = Nothing
	End Sub
#End Region 
End Class