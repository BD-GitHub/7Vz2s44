Option Strict Off
Option Explicit On
Module CaseImport
	Public Const dupflag As Short = 5
	Public Const newcharge As Short = 6
	
	'*************************************************************************
	'*  This Function uses a Data Environment Connection Called  TRASQL      *
	'*  The connecition must be define for each site. This function does     *
	'*  the following:                                                       *
	'*  1. Clears the SQL table tblCourtRecord in the database TSS .         *
	'*  2. Gets fiscal year from SQL Stored Procedure.                       *
	'*  3. Gets last entered Enrollment ID, for fiscal year supplied,        *
	'*     from SQL table tblEnrollment via a SQL Stored Procedure.          *
	'*  4. Inputs daily court record file, validates date fields, checks     *
	'*     for duplicate case numbers in SQL table tblCaseNumber, generates  *
	'*     new Enrollment ID for each case, sets Completion code to "I" for  *
	'*     each record and adds all non-duplicate records to SQL table       *
	'*     tblCourtRecord in database TSS                                    *
	'*************************************************************************
	
    Function NewCases() As String
        On Error GoTo Err_NewCases
        Dim int1 As Short = 0
        Dim int2 As Short
        Dim intDC As Short 'Duplicate check return code
        Dim de1 As New DataEnvironment_TssDb
        Dim de2 As New DataEnvironment_TssDb
        Dim rst As ADODB.Recordset
        Dim ID As String
        Dim IDS1 As String
        Dim IDS2 As String
        Dim intTtlCount As Short = 0
        Dim intAddCount As Short = 0
        Dim intUpdCount As Short = 0
        Dim intDupCount As Short = 0
        Dim intNewChgCount As Short
        Dim fld09, fld07, fld05, fld03, fld01, fld02, fld04, fld06, fld08, fld10 As String
        Dim fld19, fld17, fld15, fld13, fld11, fld12, fld14, fld16, fld18, fld20 As String
        Dim fld27, fld25, fld23, fld21, fld22, fld24, fld26, fld28 As String
        Dim strCentury As String
        Dim strDay As String
        Dim strMonth As String
        Dim strEligFile As String = ""
        Dim strNewID As String
        Dim strStartEnrollID As String
        Dim strFYear As String = FiscalYear()
        Const strTable As String = "tblCourtRecord"
        Dim strTmp As String
        Dim strYear As String
        Dim dtmDobDate, dtmOfnDate, dtmRtnDate As Date
        'Dim varDobDate As Object
        'Dim varOfnDate As Object
        'Dim varRtnDate As Object
        strStartEnrollID = LastEnrollID(strFYear)
        de1.ic_ClearCourtRecord(int1) 'Clears tblCourtRecord
        de2.CourtRecord()
        rst = New ADODB.Recordset
        rst.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rst.LockType = ADODB.LockTypeEnum.adLockOptimistic
        rst = de2.rsCourtRecord

        FileOpen(1, strCaseFile, OpenMode.Input)
        ' FileOpen(2, String.Format("{0}{1}.dups", strDupsFileLoc, VB6.Format(Now, "mmddyyyy")), OpenMode.Output)
        FileOpen(2, String.Format("{0}{1}.dups", strDupsFileLoc, String.Format(Now, "mmddyyyy")), OpenMode.Output)
        Do While Not EOF(1) ' Loop until end of file.
            ID = LineInput(1)
            IDS1 = Mid(ID, 1, 154)
            fld01 = Mid(IDS1, 1, 20) '*Last name
            fld02 = Mid(IDS1, 21, 14) '*First name
            fld03 = Mid(IDS1, 35, 1) '*Initial
            fld04 = Mid(IDS1, 36, 25) '*Address1
            fld05 = Mid(IDS1, 61, 25) '*Address2
            fld06 = Mid(IDS1, 86, 20) '*City
            fld07 = Mid(IDS1, 106, 2) '*State
            fld08 = Mid(IDS1, 108, 5) '*Zip
            fld09 = Mid(IDS1, 113, 6) '*Zip extended
            fld10 = Mid(IDS1, 119, 8) '*Date of birth
            fld11 = Mid(IDS1, 127, 1) '*Sex
            fld12 = Mid(IDS1, 128, 25) '*Drivers License number
            fld13 = Mid(IDS1, 153, 2) '*Drivers License state

            IDS2 = Mid(ID, 155, 71)
            fld14 = Mid(IDS2, 1, 12) '*Casenumber (155)
            fld15 = Mid(IDS2, 13, 2) '*Branch
            fld16 = Mid(IDS2, 15, 4) '*Municipality
            fld17 = Mid(IDS2, 19, 8) '*Offense Date
            fld18 = Mid(IDS2, 27, 8) '*Return Date
            fld19 = Mid(IDS2, 35, 5) '*Charge Disposition Code
            fld20 = Mid(IDS2, 40, 4) '*Sentence Type
            fld21 = Mid(IDS2, 44, 2) '*Course Length
            'fld22 = Mid(IDS2, 46, 8)  'Completion Date - This field is always blank.
            'fld23 = Mid(IDS2, 54, 1)  'Completion Code - This field is always blank.
            fld24 = Mid(IDS2, 55, 1) 'Court Tape Indicator - This field is always blank for new cases and contains an "E" for updated cases.
            fld25 = Mid(IDS2, 56, 4) '*Party Sequence Number
            fld26 = Mid(IDS2, 60, 4) '*Charge Sequence Number
            fld27 = Mid(IDS2, 64, 4) '*Charge Disposition Number
            fld28 = Mid(IDS2, 68, 4) '*Sentence Sequence Number

            '/** Variable Processing  **/
            If Not IsNumeric(fld09) Then
                fld09 = ""
            End If
            strYear = ""
            strMonth = ""
            strDay = ""
            strCentury = ""
            fld12 = Replace(fld12, "-", "")
            If DateCheck.DateCheck(fld10) Then
                dtmDobDate = fld10
            Else
                dtmDobDate = "01/01/1900"
            End If
            If DateCheck.DateCheck(fld17) Then
                dtmOfnDate = fld17
            Else
                dtmOfnDate = "01/01/1900"
            End If
            If DateCheck.DateCheck(fld18) Then
                dtmRtnDate = fld18
            Else
                dtmRtnDate = "01/01/1900"
            End If

            If fld24 = "E" Then 'Process update only records.
                de2.ic_InsertUpdates(fld14, dtmRtnDate, g_dtmRunDate, fld24, fld20, int2)
                intUpdCount = intUpdCount + 1
            Else
                'Process non-update records.
                intDC = CaseCheck(fld14, fld20) 'Checks for duplicate cases with matching Sentence Types in tblCaseNumber and tblCaseDetail
                If dupflag = intDC Then
                    intDupCount = intDupCount + 1
                    PrintLine(2, ID)
                End If
            End If
            If fld24 <> "E" Then
                If dupflag <> intDC And newcharge <> intDC Then 'Adds only new cases. Updates and duplicate cases are filtered out.

                    strNewID = IdGenerator(strStartEnrollID) 'Creates a new Enrollment ID for non-duplicate cases.
                    rst.AddNew()
                    rst.Fields("strEnID").Value = strNewID
                    rst.Fields("strCnCasenum").Value = fld14
                    rst.Fields("strCnDrlicnum").Value = fld12
                    rst.Fields("strCnDrstate").Value = fld13
                    rst.Fields("strCnLName").Value = fld01
                    rst.Fields("strCnFName").Value = fld02
                    rst.Fields("strCnMName").Value = fld03
                    rst.Fields("strCnAdress1").Value = fld04
                    rst.Fields("strCnAdress2").Value = fld05
                    rst.Fields("strCnCity").Value = fld06
                    rst.Fields("strCnState").Value = fld07
                    rst.Fields("strCnZip").Value = fld08
                    rst.Fields("strCnZip4").Value = fld09
                    rst.Fields("dtmCnDob").Value = dtmDobDate
                    rst.Fields("strCnSex").Value = fld11
                    rst.Fields("dtmCnOfnDate").Value = dtmOfnDate
                    rst.Fields("dtmCnReturnDate").Value = dtmRtnDate
                    rst.Fields("strCnSntType").Value = fld20
                    rst.Fields("strCnMuni").Value = fld16
                    rst.Fields("strCnCrsLength").Value = fld21
                    rst.Fields("strCnBranch").Value = fld15
                    rst.Fields("strCnCmplCode").Value = "I"
                    rst.Fields("strCnTapeCode").Value = fld24
                    rst.Fields("strCnSntSeqNum").Value = fld28
                    rst.Fields("strCnPrtySeqNum").Value = fld25
                    rst.Fields("strCnChgSeqNum").Value = fld26
                    rst.Fields("strCnChrgDispNum").Value = fld27
                    rst.Fields("strCnChrgDispCode").Value = fld19
                    rst.Fields("bitNewCase").Value = 1
                    rst.Update()
                    strStartEnrollID = strNewID
                    intAddCount = intAddCount + 1
                ElseIf newcharge = intDC Then
                    rst.AddNew()
                    rst.Fields("strCnCasenum").Value = fld14
                    rst.Fields("dtmCnOfnDate").Value = dtmOfnDate
                    rst.Fields("dtmCnReturnDate").Value = dtmRtnDate
                    rst.Fields("strCnSntType").Value = fld20
                    rst.Fields("strCnMuni").Value = fld16
                    rst.Fields("strCnCrsLength").Value = fld21
                    rst.Fields("strCnBranch").Value = fld15
                    rst.Fields("strCnCmplCode").Value = "I"
                    rst.Fields("strCnTapeCode").Value = fld24
                    rst.Fields("strCnSntSeqNum").Value = fld28
                    rst.Fields("strCnPrtySeqNum").Value = fld25
                    rst.Fields("strCnChgSeqNum").Value = fld26
                    rst.Fields("strCnChrgDispNum").Value = fld27
                    rst.Fields("strCnChrgDispCode").Value = fld19
                    rst.Fields("bitNewCase").Value = 0
                    rst.Update()
                    intNewChgCount = intNewChgCount + 1
                End If
            End If
            intTtlCount = intTtlCount + 1
        Loop

        FileClose(1) ' Close file.
        FileClose(2)
        'UPGRADE_NOTE: Object rst may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rst = Nothing
        'UPGRADE_NOTE: Object de1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        de1 = Nothing
        'UPGRADE_NOTE: Object de2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        de2 = Nothing

        NewCases = String.Format("Total Cases = {0} Cases Added = {1} Cases Update = {2} Duplicate Cases = {3} New Charges Added: {4}", intTtlCount, intAddCount, intUpdCount, intDupCount, intNewChgCount)

Exit_NewCases:
        Exit Function

Err_NewCases:
        strTmp = String.Format("{0}{1}VB Error # {2}", strTmp, vbCrLf, Str(Err.Number))
        strTmp = String.Format("{0}{1}   Generated by {2}", strTmp, vbCrLf, Err.Source)
        strTmp = String.Format("{0}{1}   Description  {2}", strTmp, vbCrLf, Err.Description)
        MsgBox(strTmp)
        On Error GoTo 0
        FileClose(1) ' Close file.
        FileClose(2)
        rst = Nothing
        NewCases = "New_Case: " & strBadReturn
        Resume Exit_NewCases

    End Function
	
	Sub ApplyUpdates()
        'Dim int1 As Short
        Dim de1 As New DataEnvironment_TssDb
		
		de1.ic_ApplyUpdates()
		Debug.Print("Updates Applied Return Code")

        de1 = Nothing
		
	End Sub
End Module