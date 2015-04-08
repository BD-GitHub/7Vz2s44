Public Class ReportViewer1

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TssDataSet.tblNotEligible' table. You can move, or remove it, as needed.
        Me.TblNotEligibleTableAdapter.Fill(Me.TssDataSet.tblNotEligible)

    End Sub
End Class