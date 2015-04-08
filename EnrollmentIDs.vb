Option Strict On
Option Explicit On
Imports System.Data.SqlClient
Imports System.Configuration
Imports System

Module EnrollmentIDs
    Private SQL As New SQLControl
    ' ## TODO Rework Error Handling
    Function LastEnrollID(ByVal strSentYear As String) As String
        '   RETURNS LAST ENROLLMENT ID USED. IF THERE ARE NONE FOR SUPPLIED FISCAL
        '   YEAR, THE FISCAL YEAR IS RETURNED WITH 7 ZEROS APPENDED TO IT.
        Try
            '   QUERY STORED PROCEDURE ic_EnrollLastIDUsed  @year <-- FISCAL YEAR IS SUPPLIED
            SQL.AddParam("@year", strSentYear)
            SQL.ExecQuery("EXECUTE ic_EnrollLastIDUsed @year")

            ' IF RECORD A RECORD IS FOUND, RETURN THE RECORD
            If SQL.RecordCount = 1 Then


                If IsDBNull(SQL.SQLDS.Tables(0).Rows(0).Item("Max ID")) Then
                    LastEnrollID = strSentYear & "0000000"
                ElseIf CStr(SQL.SQLDS.Tables(0).Rows(0).Item("Max ID")) = "" Then
                    LastEnrollID = strSentYear & "0000000"
                Else
                    LastEnrollID = CStr(SQL.SQLDS.Tables(0).Rows(0).Item("Max ID"))
                End If

                ' RETURN LAST ENROLLMENT ID
                Return LastEnrollID
            Else
                ' REPORT ERRORS
                MsgBox("A single record was not returned " & SQL.Exception)
                LastEnrollID = "Process Error"
                Return LastEnrollID
            End If
        Catch ex As Exception
            ' CAPTURE ERRORS
            MsgBox("Exception error: " & ex.Message.ToString)
            Return ex.Message.ToString
        End Try

    End Function
End Module