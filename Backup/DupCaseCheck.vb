Option Strict Off
Option Explicit On
Module DupCaseCheck
	
	'**********************************************************************
	'*  This Function uses a Data Environment Connection Called  TRASQL   *
	'*  The connecition must be define for each site. Parameters Casenum  *
	'*  & int1 are passed to the Server Stored Procedure: ic_CaseDupCheck *
	'**********************************************************************
	
    Function CaseCheck(ByRef Casenum As Object, ByRef SentType As Object) As Integer
        On Error GoTo Err_CaseCheck
        Dim de As New DataEnvironment_TssDb
        Dim intCode As Short
        Dim int1 As Integer

        int1 = 0
        de.ic_CaseDupCheck(Casenum, SentType, int1)

        'intCode = de2.Commands.Item(2).Parameters.Item(3).Value
        'Debug.Print "intCode Value: " & intCode
        CaseCheck = int1

Exit_CaseCheck:
        Exit Function

Err_CaseCheck:
        Dim strTmp As String
        strTmp = strTmp & vbCrLf & "VB Error # " & Str(Err.Number)
        strTmp = strTmp & vbCrLf & "   Generated by " & Err.Source
        strTmp = strTmp & vbCrLf & "   Description  " & Err.Description
        MsgBox(strTmp)
        Resume Exit_CaseCheck

    End Function
End Module