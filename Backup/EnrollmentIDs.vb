Option Strict Off
Option Explicit On
Module EnrollmentIDs
	
    Function LastEnrollID(ByVal strSentYear As String) As String
        On Error GoTo Err_LastEnrollID
        Dim de As New DataEnvironment_TssDb
        Dim rsEnrollID As New ADODB.Recordset
        Dim intCode As Short
        Dim int1 As Integer

        int1 = 0
        de.ic_EnrollLastIDUsed(strSentYear)
        rsEnrollID = de.rsic_EnrollLastIDUsed
        If Not rsEnrollID.EOF Or Not rsEnrollID.BOF Then
            LastEnrollID = rsEnrollID.Fields.Item("Max ID").Value
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rsEnrollID.Fields.Item("Max ID").Value) Then
                LastEnrollID = strSentYear & "0000000"
            End If
        End If
        rsEnrollID.Close()
        rsEnrollID = Nothing
        de = Nothing

Exit_LastEnrollID:
        Exit Function

Err_LastEnrollID:
        Dim strTmp As String
        strTmp = strTmp & vbCrLf & "VB Error # " & Str(Err.Number)
        strTmp = strTmp & vbCrLf & "   Generated by " & Err.Source
        strTmp = strTmp & vbCrLf & "   Description  " & Err.Description
        MsgBox(strTmp)
        'UPGRADE_WARNING: Couldn't resolve default property of object LastEnrollID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        LastEnrollID = "0"
        rsEnrollID.Close()
        Resume Exit_LastEnrollID

    End Function
End Module