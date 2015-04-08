Option Strict Off
Option Explicit On
Friend Class frmMain
	Inherits System.Windows.Forms.Form
	
	Private Sub cboAddCases_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAddCases.Click
		Main_Renamed()
	End Sub
	
	Private Sub cboExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExit.Click
		Me.Close()
	End Sub
	
	Private Sub cboReports_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboReports.Click
		frmReportDate.Show()
	End Sub
End Class