Public Class DataDisplay
    Private SQL As New SQLControl

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DataDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iFlag As Short
        'Dim bFlag As Boolean
        Dim strEnrollID As String

        Debug.Print("Debug Message")
        'bFlag = DateCheck.DateCheck("20150401")
        ' strEnrollID = IdGenerator("2015000000Z")
        iFlag = DupCaseCheck.CaseCheck("14TR00002959", "DFDR")
        MsgBox("iFlag: " & iFlag)
        'MsgBox("LastEnroll ID: " & strEnrollID)

        'iFlag = CShort(FiscalYear())
        'MsgBox("Dup Flag: " + CStr(iFlag))
        'iFlag = InsertUpdates("14TR00091873", #4/25/2015#, #3/9/2015#, "E", "DFDR", 0)
        'iFlag = ApplyUpdates()
        ''GetYear()
        'ClearCourtRecord()
    End Sub

    Private Sub GetYear()
        ' QUERY Year TABLE
        SQL.ExecQuery("SELECT strYear FROM tblFiscalYear")

        ' IF RECORDS ARE FOUND, ADD THEM TO COMBOBOX
        If SQL.RecordCount > 0 Then
            For Each r As DataRow In SQL.SQLDS.Tables(0).Rows
                cboFiscalYear.Items.Add(r("strYear"))
            Next

            ' SET THE COMBOBOX TO FIRST RECORD
            cboFiscalYear.SelectedIndex = 0

        ElseIf SQL.Exception <> "" Then
            ' REPORT ERRORS
            MsgBox(SQL.Exception)
        End If

        'MsgBox(SQL.SQLDS.ToString)
    End Sub

    Private Sub GetAccounts(Year As String)
        ' ADD A SEARCH PARAMETER
        SQL.AddParam("@strYear", Year)

        ' RUN QUERY
        SQL.ExecQuery("SELECT strCashAccount, strRecAccount, strRevAccount FROM tblFiscalYear WHERE strYear = @strYear ")

        ' IF YEAR IS FOUND, SEND ACCOUNTS TO TEXTBOXES
        If SQL.RecordCount > 0 Then
            txtCashAcct.Text = SQL.SQLDS.Tables(0).Rows(0).Item("strCashAccount")
            txtRecAcct.Text = SQL.SQLDS.Tables(0).Rows(0).Item("strRecAccount")
            txtRevAcct.Text = SQL.SQLDS.Tables(0).Rows(0).Item("strRevAccount")
        End If


    End Sub


    Private Sub cboFiscalYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiscalYear.SelectedIndexChanged
        GetAccounts(cboFiscalYear.Text)
    End Sub
End Class