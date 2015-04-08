Option Strict Off
Option Explicit On
Module Eligibility
	
	'*****************************************************************************
	'*   This function reads each record in tblCourtRecord and checks for a      *
	'*   Drivers License match in tblCaseNumber where the Offense date in        *
	'*   tblCourtRecord is within 1 year of the Offense date of the matching     *
	'*   record in tblCaseNumber. Cases with matches are added to tblNotEligible *
	'*   and the tblCourtRecord record has its completion code changed to "E"    *
	'*****************************************************************************
	
	Function NoPrevious() As Object
		On Error GoTo Err_NoPrevious
        Dim de1 As New DataEnvironment_TssDb
        Dim de2 As New DataEnvironment_TssDb
        Dim de3 As New DataEnvironment_TssDb
		Dim intEC As Short 'Eligibility check return code
		Dim intNEID As Short 'tblNotEligible record ID
		Dim intNotEligible As Short
		Dim rst1 As ADODB.Recordset 'Command CourtRecord: tblCourtRecord
		Dim rst2 As ADODB.Recordset 'SP ic_Eligibility: MSSQL Stored Procedure ic_Eligibility
		Dim rst3 As ADODB.Recordset 'Command NotEligible: tblNotEligible
		Dim strDrlic As String
		Dim dtmCurrent As Date
		Dim dtmOfnDate1 As Date
		Dim dtmOfnDate2 As Date
		Dim dtmCnDob As Date
		Dim dtmCnReturnDate As Date
		
		intNEID = 1
		intNotEligible = 0
		dtmCurrent = Now
		' Returns all records in tblCourtRecord for cases with CM, DT, OV or TR in the case number.
		de1.CourtRecord()
		' Returns all records from tblNotEligible.
		de3.NotEligible()
		rst1 = New ADODB.Recordset
		rst1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rst1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rst1 = de1.rsCourtRecord
		rst3 = New ADODB.Recordset
		rst3.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rst3.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rst3 = de3.rsNotEligible
		FileOpen(1, strEligFile, OpenMode.Append)
		If rst1.RecordCount > 0 Then
			rst1.MoveFirst()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object NoPrevious. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			NoPrevious = "Eligibility: " & strEmptyReturn
			Exit Function
		End If
		Do While Not rst1.EOF
			If rst1.Fields("strCnChrgDispCode").Value = "WTHCD" Then
				strDrlic = RTrim(rst1.Fields("strCnDrlicnum").Value)
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If strDrlic = "" Or IsDbNull(strDrlic) Then
					intEC = 0
				Else
					intEC = 0
					' Drivers License number and Offense date are sent to SP ic_Eligibility.
					' If any matches are found, the return code (intEC) is set to 1.
					de2.ic_EligibilityRC(rst1.Fields("strCnDrlicnum"), rst1.Fields("dtmCnOfnDate"), intEC)
					' When true (inEC = 1), a recordset of relavant fields is returned.
					If intEC = 1 Then
						de2.ic_Eligibility(rst1.Fields("strCnDrlicnum"), rst1.Fields("dtmCnOfnDate"), intEC)
					End If
				End If
				If intEC = 1 Then
					rst2 = New ADODB.Recordset
					rst2.CursorType = ADODB.CursorTypeEnum.adOpenStatic
					rst2.LockType = ADODB.LockTypeEnum.adLockOptimistic
					rst2 = de2.rsic_Eligibility
					intNotEligible = intNotEligible + 1
					rst2.MoveFirst()
					' Not eligible cases along with matching information is added to tblNotEligible.
					Do While Not rst2.EOF
						dtmOfnDate1 = rst1.Fields("dtmCnOfnDate").Value
						dtmOfnDate2 = rst2.Fields("dtmCnOfnDate").Value
						dtmCnDob = rst1.Fields("dtmCnDob").Value
						dtmCnReturnDate = rst1.Fields("dtmCnReturnDate").Value
						rst3.AddNew()
						rst3.Fields("intID").Value = intNEID
						rst3.Fields("dtmRunDate").Value = dtmCurrent
						rst3.Fields("strNewCasenum").Value = rst1.Fields("strCnCasenum").Value
						rst3.Fields("strDrlicnum").Value = rst1.Fields("strCnDrlicnum").Value
						rst3.Fields("dtmNewOfnDate").Value = dtmOfnDate1
						rst3.Fields("strMatchCasenum").Value = rst2.Fields("strCnCasenum").Value
						rst3.Fields("dtmMatchOfnDate").Value = dtmOfnDate2
						rst3.Fields("strCnLName").Value = rst1.Fields("strCnLName").Value
						rst3.Fields("strCnFName").Value = rst1.Fields("strCnFName").Value
						rst3.Fields("strCnMName").Value = rst1.Fields("strCnMName").Value
						rst3.Fields("strCnAdress1").Value = rst1.Fields("strCnAdress1").Value
						rst3.Fields("strCnAdress2").Value = rst1.Fields("strCnAdress2").Value
						rst3.Fields("strCnCity").Value = rst1.Fields("strCnCity").Value
						rst3.Fields("strCnState").Value = rst1.Fields("strCnState").Value
						rst3.Fields("strCnZip").Value = rst1.Fields("strCnZip").Value
						rst3.Fields("dtmCnDob").Value = dtmCnDob
						rst3.Fields("strCnSex").Value = rst1.Fields("strCnSex").Value
						rst3.Fields("strCnMuni").Value = rst1.Fields("strCnMuni").Value
						rst3.Fields("strCnBranch").Value = rst1.Fields("strCnBranch").Value
						rst3.Fields("dtmCnReturnDate").Value = dtmCnReturnDate
						rst3.Update()
						rst2.MoveNext()
						intNEID = intNEID + 1
					Loop 
					rst1.Fields("strCnCmplCode").Value = "E"
					rst1.Update()
					rst2.Close()
					'UPGRADE_NOTE: Object rst2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					rst2 = Nothing
				End If
				If intNotEligible > 150 Then
					Exit Function
				End If
				rst1.MoveNext()
			Else
				rst1.MoveNext()
			End If
		Loop 
		WriteLine(1, dtmCurrent, "Total Not Eligible Cases: ", intNotEligible)
		FileClose(1)
		rst1.Close()
		rst3.Close()
		'UPGRADE_NOTE: Object rst1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst1 = Nothing
		'UPGRADE_NOTE: Object rst2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst2 = Nothing
		'UPGRADE_NOTE: Object rst3 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst3 = Nothing
		'UPGRADE_NOTE: Object de1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de1 = Nothing
		'UPGRADE_NOTE: Object de2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de2 = Nothing
		'UPGRADE_NOTE: Object de3 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de3 = Nothing
		
		'Debug.Print dtmCurrent
		'If intNotEligible > 0 Then
		'E_Report (dtmCurrent)
		'End If
		'UPGRADE_WARNING: Couldn't resolve default property of object NoPrevious. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NoPrevious = "Eligibility: " & strGoodReturn
		
Exit_NoPrevious: 
		Exit Function
		
Err_NoPrevious: 
		Dim strTmp As String
		strTmp = strTmp & vbCrLf & "VB Error # " & Str(Err.Number)
		strTmp = strTmp & vbCrLf & "   Generated by " & Err.Source
		strTmp = strTmp & vbCrLf & "   Description  " & Err.Description
		MsgBox(strTmp)
		On Error GoTo 0
		'UPGRADE_NOTE: Object rst1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst1 = Nothing
		'UPGRADE_NOTE: Object rst2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst2 = Nothing
		'UPGRADE_NOTE: Object rst3 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst3 = Nothing
		'UPGRADE_NOTE: Object de1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de1 = Nothing
		'UPGRADE_NOTE: Object de2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de2 = Nothing
		'UPGRADE_NOTE: Object de3 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		de3 = Nothing
		
		FileClose(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object NoPrevious. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NoPrevious = "Eligibility: " & strBadReturn
		Resume Exit_NoPrevious
		
	End Function
	
	Sub E_Report(ByVal dtmCurrent As Date)
		Dim Prompt As Boolean
		Dim strSQL As String
		'UPGRADE_ISSUE: TRAF0004_2 object was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		Dim Report As New TRAF0004_2
		Dim rs As New ADOR.Recordset
		
		Prompt = False
		strSQL = "Select * From NotEligible where dtmRunDate = "
		strSQL = strSQL & "'" & dtmCurrent & "'"
		'Debug.Print dtmCurrent
		rs.Open(strSQL, connect)
		'UPGRADE_WARNING: Couldn't resolve default property of object Report.Database. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Report.Database.SetDataSource(rs)
		'UPGRADE_WARNING: Couldn't resolve default property of object Report.PaperOrientation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Report.PaperOrientation = 2 ' crLandscape
		'UPGRADE_WARNING: Couldn't resolve default property of object Report.PrintOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Report.PrintOut(Prompt)
		
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		
	End Sub
End Module