<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cboExit As System.Windows.Forms.Button
	Public WithEvents cboReports As System.Windows.Forms.Button
	Public WithEvents cboAddCases As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboExit = New System.Windows.Forms.Button
		Me.cboReports = New System.Windows.Forms.Button
		Me.cboAddCases = New System.Windows.Forms.Button
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Text = "New Case Processing"
		Me.ClientSize = New System.Drawing.Size(312, 184)
		Me.Location = New System.Drawing.Point(161, 156)
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
		Me.Name = "frmMain"
		Me.cboExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboExit.Text = "Exit"
		Me.cboExit.Size = New System.Drawing.Size(129, 41)
		Me.cboExit.Location = New System.Drawing.Point(168, 120)
		Me.cboExit.TabIndex = 2
		Me.cboExit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboExit.BackColor = System.Drawing.SystemColors.Control
		Me.cboExit.CausesValidation = True
		Me.cboExit.Enabled = True
		Me.cboExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboExit.TabStop = True
		Me.cboExit.Name = "cboExit"
		Me.cboReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboReports.Text = "Print Eligibility Reports"
		Me.cboReports.Size = New System.Drawing.Size(129, 41)
		Me.cboReports.Location = New System.Drawing.Point(168, 64)
		Me.cboReports.TabIndex = 1
		Me.cboReports.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboReports.BackColor = System.Drawing.SystemColors.Control
		Me.cboReports.CausesValidation = True
		Me.cboReports.Enabled = True
		Me.cboReports.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboReports.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboReports.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboReports.TabStop = True
		Me.cboReports.Name = "cboReports"
		Me.cboAddCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cboAddCases.Text = "Add New Cases"
		Me.cboAddCases.Size = New System.Drawing.Size(129, 41)
		Me.cboAddCases.Location = New System.Drawing.Point(168, 8)
		Me.cboAddCases.TabIndex = 0
		Me.cboAddCases.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAddCases.BackColor = System.Drawing.SystemColors.Control
		Me.cboAddCases.CausesValidation = True
		Me.cboAddCases.Enabled = True
		Me.cboAddCases.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cboAddCases.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAddCases.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAddCases.TabStop = True
		Me.cboAddCases.Name = "cboAddCases"
		Me.Controls.Add(cboExit)
		Me.Controls.Add(cboReports)
		Me.Controls.Add(cboAddCases)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class