Option Strict Off
Option Explicit On
Module EnrollFix
	
	Sub FixCases()
        Dim de1 As New DataEnvironment_TssDb
		Dim rst As ADODB.Recordset
		Dim strStartEnrollID As String
		Dim strFYear As String
		Dim strNewID As Object
		
		strFYear = "2001"
		'UPGRADE_WARNING: Couldn't resolve default property of object LastEnrollID(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strStartEnrollID = LastEnrollID(strFYear)
		rst = New ADODB.Recordset
		rst.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rst.LockType = ADODB.LockTypeEnum.adLockOptimistic
		de1.EnrollFix()
		rst = de1.rsEnrollFix
		
		
		
		With rst
			If Not rst.EOF Or Not rst.BOF Then
				.MoveFirst()
				Do 
					'UPGRADE_WARNING: Couldn't resolve default property of object IdGenerator(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object strNewID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					strNewID = IdGenerator(strStartEnrollID)
					If Not rst.EOF Or Not rst.BOF Then
						'rst.AddNew
						'UPGRADE_WARNING: Couldn't resolve default property of object strNewID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						rst.Fields("strEnID").Value = strNewID
						rst.Update()
						'UPGRADE_WARNING: Couldn't resolve default property of object strNewID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						strStartEnrollID = strNewID
					End If
					.MoveNext()
				Loop Until rst.EOF
			End If
			.Close()
		End With
		Debug.Print("Finished")
	End Sub
End Module