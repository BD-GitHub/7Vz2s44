Option Strict Off
Option Explicit On
'Imports System.Data
'Imports System.Data.SqlClient

Module DupCaseCheck
    Private SQL As New SQLControl
    '## TODO Documentation and Error Handling
    '**********************************************************************
    '*  This Function uses xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   *
    '*  The connecition must be define for each site. Parameters Casenum  *
    '*  & SntType are passed to the Stored Procedure: ic_CaseDupCheck     *
    '**********************************************************************

    Function CaseCheck(ByRef Casenum As Object, ByRef SentType As Object) As Short
        On Error GoTo Err_CaseCheck

        SQL.AddParamOp("@iReturn")
        SQL.AddParam("@vchCasenum", Casenum)
        SQL.AddParam("@vchSentType", SentType)

        SQL.ExecNonQuery("EXECUTE ic_CaseDupCheck @vchCasenum, @vchSentType, @iReturn OUTPUT")

        CaseCheck = SQL.iStatus

Exit_CaseCheck:
        Exit Function

Err_CaseCheck:
        Dim strTmp As String
        strTmp = String.Format("{0}{1}VB Error # {2}", strTmp, vbCrLf, Str(Err.Number))
        strTmp = String.Format("{0}{1}   Generated by {2}", strTmp, vbCrLf, Err.Source)
        strTmp = String.Format("{0}{1}   Description  {2}", strTmp, vbCrLf, Err.Description)
        MsgBox(strTmp)
        Resume Exit_CaseCheck

    End Function
End Module