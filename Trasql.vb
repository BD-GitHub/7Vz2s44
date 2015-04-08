Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Module DataEnvironment_TssDb_Module
    Friend TssDb As DataEnvironment_TssDb = New DataEnvironment_TssDb()
End Module

Friend Class DataEnvironment_TssDb
    Inherits VB6.BaseDataEnvironment
    Public WithEvents TssDb1 As ADODB.Connection
    Public WithEvents rsCaseProcess As ADODB.Recordset
    Private m_CaseProcess As ADODB.Command
    Public WithEvents rsChild1 As ADODB.Recordset
    Private m_Child1 As ADODB.Command
    Public WithEvents rsic_EnrollLastIDUsed As ADODB.Recordset
    Private m_ic_EnrollLastIDUsed As ADODB.Command
    Public WithEvents rsCourtRecord As ADODB.Recordset
    Private m_CourtRecord As ADODB.Command
    Private m_ic_ClearCourtRecord As ADODB.Command
    Private m_ic_EligibilityA As ADODB.Command
    Public WithEvents rsic_Eligibility As ADODB.Recordset
    Private m_ic_Eligibility As ADODB.Command
    Private m_ic_EligibilityRC As ADODB.Command
    Public WithEvents rsNotEligible As ADODB.Recordset
    Private m_NotEligible As ADODB.Command
    Private m_ic_InsertCases As ADODB.Command
    Public WithEvents rsEnrollFix As ADODB.Recordset
    Private m_EnrollFix As ADODB.Command
    Private m_ic_ApplyUpdates As ADODB.Command
    Private m_ic_CaseDupCheck As ADODB.Command
    Private m_ic_InsertUpdates As ADODB.Command
    Public Sub New()
        MyBase.New()
        Dim par As ADODB.Parameter


        TssDb1 = New ADODB.Connection()
        TssDb1.ConnectionString = "PROVIDER=MSDataShape;DATA PROVIDER=MSDASQL.1;Persist Security Info=False;Data Source=Tss_Qry;Initial Catalog=Tss;"
        m_Connections.Add(TssDb1, "TssDb1")
        m_CaseProcess = New ADODB.Command()
        rsCaseProcess = New ADODB.Recordset()
        m_CaseProcess.Name = "CaseProcess"
        m_CaseProcess.CommandText = " SHAPE {SELECT * FROM tblCaseNumber Where strCnCasenum = '99TR00052634'}  AS CaseProcess APPEND ({SELECT * FROM tblEnrollment}  AS Child1 RELATE 'strCnCasenum' TO 'strCnCasenum') AS Child1"
        m_CaseProcess.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsCaseProcess.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsCaseProcess.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsCaseProcess.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsCaseProcess.Source = m_CaseProcess
        m_Commands.Add(m_CaseProcess, "CaseProcess")
        m_Recordsets.Add(rsCaseProcess, "CaseProcess")
        '--------------------------------------------------
        m_Child1 = New ADODB.Command()
        rsChild1 = New ADODB.Recordset()
        m_Child1.Name = "Child1"
        m_Child1.CommandText = "SELECT * FROM tblEnrollment"
        m_Child1.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsChild1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsChild1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsChild1.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsChild1.Source = m_Child1
        m_Commands.Add(m_Child1, "Child1")
        m_Recordsets.Add(rsChild1, "Child1")
        '--------------------------------------------------
        m_ic_EnrollLastIDUsed = New ADODB.Command()
        rsic_EnrollLastIDUsed = New ADODB.Recordset()
        m_ic_EnrollLastIDUsed.Name = "ic_EnrollLastIDUsed"
        m_ic_EnrollLastIDUsed.CommandText = "dbo.ic_EnrollLastIDUsed"
        par = m_ic_EnrollLastIDUsed.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_EnrollLastIDUsed.Parameters.Append(par)
        par = m_ic_EnrollLastIDUsed.CreateParameter
        par.Name = "year"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 4
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EnrollLastIDUsed.Parameters.Append(par)
        m_ic_EnrollLastIDUsed.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        rsic_EnrollLastIDUsed.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsic_EnrollLastIDUsed.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsic_EnrollLastIDUsed.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsic_EnrollLastIDUsed.Source = m_ic_EnrollLastIDUsed
        m_Commands.Add(m_ic_EnrollLastIDUsed, "ic_EnrollLastIDUsed")
        m_Recordsets.Add(rsic_EnrollLastIDUsed, "ic_EnrollLastIDUsed")
        '--------------------------------------------------
        m_CourtRecord = New ADODB.Command()
        rsCourtRecord = New ADODB.Recordset()
        m_CourtRecord.Name = "CourtRecord"
        m_CourtRecord.CommandText = "SELECT * FROM tblCourtRecord WHERE RIGHT(LEFT(strCnCasenum, 4), 2) = 'CM' OR RIGHT(LEFT(strCnCasenum, 4), 2) = 'DT' OR RIGHT(LEFT(strCnCasenum, 4), 2) = 'TR' OR RIGHT(LEFT(strCnCasenum, 4), 2) = 'OV'"
        m_CourtRecord.CommandType = ADODB.CommandTypeEnum.adCmdText
        rsCourtRecord.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsCourtRecord.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsCourtRecord.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsCourtRecord.Source = m_CourtRecord
        m_Commands.Add(m_CourtRecord, "CourtRecord")
        m_Recordsets.Add(rsCourtRecord, "CourtRecord")
        m_ic_ClearCourtRecord = New ADODB.Command()
        m_ic_ClearCourtRecord.Name = "ic_ClearCourtRecord"
        m_ic_ClearCourtRecord.CommandText = "dbo.ic_ClearCourtRecord"
        par = m_ic_ClearCourtRecord.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_ClearCourtRecord.Parameters.Append(par)
        par = m_ic_ClearCourtRecord.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_ClearCourtRecord.Parameters.Append(par)
        m_ic_ClearCourtRecord.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_ClearCourtRecord, "ic_ClearCourtRecord")
        m_NonRSReturningCommands.Add(m_ic_ClearCourtRecord, "ic_ClearCourtRecord")
        '-------------------------------------------------------
        m_ic_EligibilityA = New ADODB.Command()
        m_ic_EligibilityA.Name = "ic_EligibilityA"
        m_ic_EligibilityA.CommandText = "dbo.ic_EligibilityA"
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "vchDrlicnum"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 25
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "dtmOfnDate"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "dtmOfnDate2"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "vchLName"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 25
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "vchFName"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 24
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "vchCity"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 20
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "vchState"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 2
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        par = m_ic_EligibilityA.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityA.Parameters.Append(par)
        m_ic_EligibilityA.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_EligibilityA, "ic_EligibilityA")
        m_NonRSReturningCommands.Add(m_ic_EligibilityA, "ic_EligibilityA")
        m_ic_Eligibility = New ADODB.Command()
        rsic_Eligibility = New ADODB.Recordset()
        m_ic_Eligibility.Name = "ic_Eligibility"
        m_ic_Eligibility.CommandText = "dbo.ic_Eligibility"
        par = m_ic_Eligibility.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_Eligibility.Parameters.Append(par)
        par = m_ic_Eligibility.CreateParameter
        par.Name = "vchDrlicnum"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 25
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_Eligibility.Parameters.Append(par)
        par = m_ic_Eligibility.CreateParameter
        par.Name = "dtmOfnDate"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_Eligibility.Parameters.Append(par)
        par = m_ic_Eligibility.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        par.Value = "0"
        m_ic_Eligibility.Parameters.Append(par)
        m_ic_Eligibility.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        rsic_Eligibility.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsic_Eligibility.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsic_Eligibility.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rsic_Eligibility.Source = m_ic_Eligibility
        m_Commands.Add(m_ic_Eligibility, "ic_Eligibility")
        m_Recordsets.Add(rsic_Eligibility, "ic_Eligibility")
        m_ic_EligibilityRC = New ADODB.Command()
        m_ic_EligibilityRC.Name = "ic_EligibilityRC"
        m_ic_EligibilityRC.CommandText = "dbo.ic_Eligibility"
        par = m_ic_EligibilityRC.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_EligibilityRC.Parameters.Append(par)
        par = m_ic_EligibilityRC.CreateParameter
        par.Name = "vchDrlicnum"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 25
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityRC.Parameters.Append(par)
        par = m_ic_EligibilityRC.CreateParameter
        par.Name = "dtmOfnDate"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityRC.Parameters.Append(par)
        par = m_ic_EligibilityRC.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_EligibilityRC.Parameters.Append(par)
        m_ic_EligibilityRC.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_EligibilityRC, "ic_EligibilityRC")
        m_NonRSReturningCommands.Add(m_ic_EligibilityRC, "ic_EligibilityRC")
        '--------------------------------------------------------
        m_NotEligible = New ADODB.Command()
        rsNotEligible = New ADODB.Recordset()
        m_NotEligible.Name = "NotEligible"
        m_NotEligible.CommandText = "dbo.tblNotEligible"
        m_NotEligible.CommandType = ADODB.CommandTypeEnum.adCmdTable
        rsNotEligible.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsNotEligible.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsNotEligible.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsNotEligible.Source = m_NotEligible
        m_Commands.Add(m_NotEligible, "NotEligible")
        m_Recordsets.Add(rsNotEligible, "NotEligible")
        '-------------------------------------------------------
        m_ic_InsertCases = New ADODB.Command()
        m_ic_InsertCases.Name = "ic_InsertCases"
        m_ic_InsertCases.CommandText = "dbo.ic_InsertCases"
        par = m_ic_InsertCases.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_InsertCases.Parameters.Append(par)
        par = m_ic_InsertCases.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertCases.Parameters.Append(par)
        m_ic_InsertCases.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_InsertCases, "ic_InsertCases")
        m_NonRSReturningCommands.Add(m_ic_InsertCases, "ic_InsertCases")
        '---------------------------------------------------------
        m_EnrollFix = New ADODB.Command()
        rsEnrollFix = New ADODB.Recordset()
        m_EnrollFix.Name = "EnrollFix"
        m_EnrollFix.CommandText = "dbo.tblEnrollmentFix"
        m_EnrollFix.CommandType = ADODB.CommandTypeEnum.adCmdTable
        rsEnrollFix.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rsEnrollFix.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsEnrollFix.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rsEnrollFix.Source = m_EnrollFix
        m_Commands.Add(m_EnrollFix, "EnrollFix")
        m_Recordsets.Add(rsEnrollFix, "EnrollFix")
        '---------------------------------------------------------
        m_ic_ApplyUpdates = New ADODB.Command()
        m_ic_ApplyUpdates.Name = "ic_ApplyUpdates"
        m_ic_ApplyUpdates.CommandText = "dbo.ic_ApplyUpdates"
        par = m_ic_ApplyUpdates.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_ApplyUpdates.Parameters.Append(par)
        m_ic_ApplyUpdates.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_ApplyUpdates, "ic_ApplyUpdates")
        m_NonRSReturningCommands.Add(m_ic_ApplyUpdates, "ic_ApplyUpdates")
        '---------------------------------------------------------
        m_ic_CaseDupCheck = New ADODB.Command()
        m_ic_CaseDupCheck.Name = "ic_CaseDupCheck"
        m_ic_CaseDupCheck.CommandText = "dbo.ic_CaseDupCheck"
        par = m_ic_CaseDupCheck.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_CaseDupCheck.Parameters.Append(par)
        par = m_ic_CaseDupCheck.CreateParameter
        par.Name = "vchCasenum"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 16
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_CaseDupCheck.Parameters.Append(par)
        par = m_ic_CaseDupCheck.CreateParameter
        par.Name = "vchSentType"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 4
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_CaseDupCheck.Parameters.Append(par)
        par = m_ic_CaseDupCheck.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_CaseDupCheck.Parameters.Append(par)
        m_ic_CaseDupCheck.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_CaseDupCheck, "ic_CaseDupCheck")
        m_NonRSReturningCommands.Add(m_ic_CaseDupCheck, "ic_CaseDupCheck")
        '---------------------------------------------------------

        m_ic_InsertUpdates = New ADODB.Command()
        m_ic_InsertUpdates.Name = "ic_InsertUpdates"
        m_ic_InsertUpdates.CommandText = "dbo.ic_InsertUpdates"
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "RETURN_VALUE"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamReturnValue
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "vchCasenum"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 16
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "dtmReturnDate"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "dtmRunDate"
        par.Type = ADODB.DataTypeEnum.adNumeric
        par.Size = 0
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "vchTapeCode"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 1
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "vchSntType"
        par.Type = ADODB.DataTypeEnum.adVarChar
        par.Size = 4
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        par = m_ic_InsertUpdates.CreateParameter
        par.Name = "iReturn"
        par.Type = ADODB.DataTypeEnum.adInteger
        par.Size = 0
        par.Precision = 10
        par.Direction = ADODB.ParameterDirectionEnum.adParamInput
        m_ic_InsertUpdates.Parameters.Append(par)
        m_ic_InsertUpdates.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        m_Commands.Add(m_ic_InsertUpdates, "ic_InsertUpdates")
        m_NonRSReturningCommands.Add(m_ic_InsertUpdates, "ic_InsertUpdates")
    End Sub
    Public Sub CaseProcess()
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsCaseProcess.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsCaseProcess.Close()
        End If
        m_CaseProcess.ActiveConnection = TssDb1
        rsCaseProcess.Open()
    End Sub
    Public Sub Child1()
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsChild1.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsChild1.Close()
        End If
        m_Child1.ActiveConnection = TssDb1
        rsChild1.Open()
    End Sub
    Public Sub ic_EnrollLastIDUsed(ByVal year As String)
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsic_EnrollLastIDUsed.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsic_EnrollLastIDUsed.Close()
        End If
        m_ic_EnrollLastIDUsed.ActiveConnection = TssDb1
        m_ic_EnrollLastIDUsed.Parameters.Item("year").Value = year
        rsic_EnrollLastIDUsed.Open()
    End Sub
    Public Sub CourtRecord()
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsCourtRecord.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsCourtRecord.Close()
        End If
        m_CourtRecord.ActiveConnection = TssDb1
        rsCourtRecord.Open()
    End Sub
    Public Function ic_ClearCourtRecord(ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_ClearCourtRecord.ActiveConnection = TssDb1
        m_ic_ClearCourtRecord.Parameters.Item("iReturn").Value = iReturn
        m_ic_ClearCourtRecord.Execute()
        Return CType(m_ic_ClearCourtRecord.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Function ic_EligibilityA(ByVal vchDrlicnum As String, ByVal dtmOfnDate As Integer, ByVal dtmOfnDate2 As Integer, ByVal vchLName As String, ByVal vchFName As String, ByVal vchCity As String, ByVal vchState As String, ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_EligibilityA.ActiveConnection = TssDb1
        m_ic_EligibilityA.Parameters.Item("vchDrlicnum").Value = vchDrlicnum
        m_ic_EligibilityA.Parameters.Item("dtmOfnDate").Value = dtmOfnDate
        m_ic_EligibilityA.Parameters.Item("dtmOfnDate2").Value = dtmOfnDate2
        m_ic_EligibilityA.Parameters.Item("vchLName").Value = vchLName
        m_ic_EligibilityA.Parameters.Item("vchFName").Value = vchFName
        m_ic_EligibilityA.Parameters.Item("vchCity").Value = vchCity
        m_ic_EligibilityA.Parameters.Item("vchState").Value = vchState
        m_ic_EligibilityA.Parameters.Item("iReturn").Value = iReturn
        m_ic_EligibilityA.Execute()
        Return CType(m_ic_EligibilityA.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Sub ic_Eligibility(ByVal vchDrlicnum As String, ByVal dtmOfnDate As Integer, ByVal iReturn As Integer)
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsic_Eligibility.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsic_Eligibility.Close()
        End If
        m_ic_Eligibility.ActiveConnection = TssDb1
        m_ic_Eligibility.Parameters.Item("vchDrlicnum").Value = vchDrlicnum
        m_ic_Eligibility.Parameters.Item("dtmOfnDate").Value = dtmOfnDate
        m_ic_Eligibility.Parameters.Item("iReturn").Value = iReturn
        rsic_Eligibility.Open()
    End Sub
    Public Function ic_EligibilityRC(ByVal vchDrlicnum As String, ByVal dtmOfnDate As Integer, ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_EligibilityRC.ActiveConnection = TssDb1
        m_ic_EligibilityRC.Parameters.Item("vchDrlicnum").Value = vchDrlicnum
        m_ic_EligibilityRC.Parameters.Item("dtmOfnDate").Value = dtmOfnDate
        m_ic_EligibilityRC.Parameters.Item("iReturn").Value = iReturn
        m_ic_EligibilityRC.Execute()
        Return CType(m_ic_EligibilityRC.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Sub NotEligible()
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsNotEligible.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsNotEligible.Close()
        End If
        m_NotEligible.ActiveConnection = TssDb1
        rsNotEligible.Open()
    End Sub
    Public Function ic_InsertCases(ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_InsertCases.ActiveConnection = TssDb1
        m_ic_InsertCases.Parameters.Item("iReturn").Value = iReturn
        m_ic_InsertCases.Execute()
        Return CType(m_ic_InsertCases.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Sub EnrollFix()
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        If rsEnrollFix.State = ADODB.ObjectStateEnum.adStateOpen Then
            rsEnrollFix.Close()
        End If
        m_EnrollFix.ActiveConnection = TssDb1
        rsEnrollFix.Open()
    End Sub
    Public Function ic_ApplyUpdates() As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_ApplyUpdates.ActiveConnection = TssDb1
        m_ic_ApplyUpdates.Execute()
        Return CType(m_ic_ApplyUpdates.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Function ic_CaseDupCheck(ByVal vchCasenum As String, ByVal vchSentType As String, ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_CaseDupCheck.ActiveConnection = TssDb1
        m_ic_CaseDupCheck.Parameters.Item("vchCasenum").Value = vchCasenum
        m_ic_CaseDupCheck.Parameters.Item("vchSentType").Value = vchSentType
        m_ic_CaseDupCheck.Parameters.Item("iReturn").Value = iReturn
        m_ic_CaseDupCheck.Execute()
        Return CType(m_ic_CaseDupCheck.Parameters("RETURN_VALUE").Value, Integer)
    End Function
    Public Function ic_InsertUpdates(ByVal vchCasenum As String, ByVal dtmReturnDate As Date, ByVal dtmRunDate As Date, ByVal vchTapeCode As String, ByVal vchSntType As String, ByVal iReturn As Integer) As Integer
        If TssDb1.State = ADODB.ObjectStateEnum.adStateClosed Then
            TssDb1.Open()
        End If
        m_ic_InsertUpdates.ActiveConnection = TssDb1
        m_ic_InsertUpdates.Parameters.Item("vchCasenum").Value = vchCasenum
        m_ic_InsertUpdates.Parameters.Item("dtmReturnDate").Value = dtmReturnDate
        m_ic_InsertUpdates.Parameters.Item("dtmRunDate").Value = dtmRunDate
        m_ic_InsertUpdates.Parameters.Item("vchTapeCode").Value = vchTapeCode
        m_ic_InsertUpdates.Parameters.Item("vchSntType").Value = vchSntType
        m_ic_InsertUpdates.Parameters.Item("iReturn").Value = iReturn
        m_ic_InsertUpdates.Execute()
        Return CType(m_ic_InsertUpdates.Parameters("RETURN_VALUE").Value, Integer)
    End Function
End Class