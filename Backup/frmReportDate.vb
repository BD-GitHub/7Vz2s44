Option Strict Off
Option Explicit On
Friend Class frmReportDate
	Inherits System.Windows.Forms.Form
	Private Sub cboExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExit.Click
		Me.Close()
	End Sub
	
	Private Sub cboPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPreview.Click
		Dim Form2 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Form2.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Form2.Show()
	End Sub
	
	Private Sub cboPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrint.Click
		E_Report(CDate(tboDate.Text))
	End Sub
End Class