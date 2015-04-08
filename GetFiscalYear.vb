Option Strict On
Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System

Module GetFiscalYear
    Private SQL As New SQLControl

    Function FiscalYear() As String
        Try
            ' QUERY STORED PROCEDURE GetFiscalYear
            SQL.ExecQuery("EXECUTE GetFiscalYear ")

            ' IF RECORD A RECORD IS FOUND, RETURN THE RECORD
            If SQL.RecordCount = 1 Then

                Return CStr(SQL.SQLDS.Tables(0).Rows(0).Item("strYear"))
            Else
                ' REPORT ERRORS
                MsgBox("A single record was not returned " & SQL.Exception)
                Return "-1"
            End If
        Catch ex As Exception
            ' CAPTURE ERRORS
            MsgBox("Exception error: " & ex.Message.ToString)
            Return ex.Message.ToString
        End Try
  


    End Function


End Module