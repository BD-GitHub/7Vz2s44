<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataDisplay
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
        Me.cboFiscalYear = New System.Windows.Forms.ComboBox()
        Me.txtCashAcct = New System.Windows.Forms.TextBox()
        Me.lblFY = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecAcct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRevAcct = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboFiscalYear
        '
        Me.cboFiscalYear.FormattingEnabled = True
        Me.cboFiscalYear.Location = New System.Drawing.Point(42, 57)
        Me.cboFiscalYear.Name = "cboFiscalYear"
        Me.cboFiscalYear.Size = New System.Drawing.Size(194, 21)
        Me.cboFiscalYear.TabIndex = 0
        '
        'txtCashAcct
        '
        Me.txtCashAcct.Location = New System.Drawing.Point(266, 57)
        Me.txtCashAcct.Name = "txtCashAcct"
        Me.txtCashAcct.Size = New System.Drawing.Size(167, 20)
        Me.txtCashAcct.TabIndex = 1
        '
        'lblFY
        '
        Me.lblFY.AutoSize = True
        Me.lblFY.Location = New System.Drawing.Point(42, 38)
        Me.lblFY.Name = "lblFY"
        Me.lblFY.Size = New System.Drawing.Size(59, 13)
        Me.lblFY.TabIndex = 2
        Me.lblFY.Text = "Fiscal Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cash Account"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(26, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " Rec Account"
        '
        'txtRecAcct
        '
        Me.txtRecAcct.Location = New System.Drawing.Point(266, 109)
        Me.txtRecAcct.Name = "txtRecAcct"
        Me.txtRecAcct.Size = New System.Drawing.Size(167, 20)
        Me.txtRecAcct.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " Rev Account"
        '
        'txtRevAcct
        '
        Me.txtRevAcct.Location = New System.Drawing.Point(266, 161)
        Me.txtRevAcct.Name = "txtRevAcct"
        Me.txtRevAcct.Size = New System.Drawing.Size(167, 20)
        Me.txtRevAcct.TabIndex = 7
        '
        'DataDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 293)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRevAcct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecAcct)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFY)
        Me.Controls.Add(Me.txtCashAcct)
        Me.Controls.Add(Me.cboFiscalYear)
        Me.Name = "DataDisplay"
        Me.Text = "DataDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFiscalYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtCashAcct As System.Windows.Forms.TextBox
    Friend WithEvents lblFY As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecAcct As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRevAcct As System.Windows.Forms.TextBox
End Class
