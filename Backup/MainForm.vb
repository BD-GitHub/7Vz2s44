Option Strict Off
Option Explicit On
Module MainForm
	Public Const strGoodReturn As String = "Good"
	Public Const strBadReturn As String = "Problem"
	Public Const strEmptyReturn As String = "Empty tblCourtRecord"
	Public Const strCaseFile As String = "K:\daily\case.dly"
	Public Const strEligFile As String = "K:\reports\not_elig.txt"
	Public Const strReportsLoc As String = "K:\reports\"
	Public Const strDupsFileLoc As String = "K:\output\"
	Public g_dtmRunDate As Date
	
	'UPGRADE_NOTE: Main was upgraded to Main_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Sub Main_Renamed()
		On Error GoTo Err_Main
		Dim Casenum As String
		Dim c As Short
		Dim x As String
		
		
		g_dtmRunDate = Now
		
		FileOpen(3, strReportsLoc & "SessionInfo.txt", OpenMode.Append)
		PrintLine(3, g_dtmRunDate)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object NewCases. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = NewCases
		PrintLine(3, Space(5) & "NewCases " & x)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object NoPrevious. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = NoPrevious
		PrintLine(3, Space(5) & "NoPrevious " & x)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object AddCases. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = AddCases
		PrintLine(3, Space(5) & "AddCases " & x)
		
		Call ApplyUpdates()
		FileClose(3)
		MsgBox("Add New Cases Process Complete")
		
Exit_Main: 
		Exit Sub
		
Err_Main: 
		Dim strTmp As String
		strTmp = strTmp & vbCrLf & "VB Error # " & Str(Err.Number)
		strTmp = strTmp & vbCrLf & "   Generated by " & Err.Source
		strTmp = strTmp & vbCrLf & "   Description  " & Err.Description
		MsgBox(strTmp)
		FileClose()
		Resume Exit_Main
		
	End Sub
End Module