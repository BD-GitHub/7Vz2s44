Option Strict Off
Option Explicit On
Friend Class frmReportDate
	Inherits System.Windows.Forms.Form
	Private Sub cboExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExit.Click
        Me.Close()
        Exit Sub

    End Sub
	

	
	Private Sub cboPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrint.Click
        E_Report(CDate(tboDate.Text))
	End Sub



    Private Sub frmReportDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TssDataSet.tblNotEligible' table. You can move, or remove it, as needed.
        Me.TblNotEligibleTableAdapter.Fill(Me.TssDataSet.tblNotEligible)

    End Sub




    Private Sub DataNavigator1_Click(sender As Object, e As EventArgs) Handles DataNavigator1.Click
        'MsgBox("Test Message", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub E_Report(p1 As Date)
        'Throw New NotImplementedException
        ReportViewer1.Show()
    End Sub

End Class