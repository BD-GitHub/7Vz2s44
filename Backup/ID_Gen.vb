Option Strict Off
Option Explicit On
Module ID_Gen
	
	Function IdGenerator(ByRef previousId As String) As Object
		
		Dim idLength As Short '// to store the length of the Id
		Dim nextId As String '// new Id to be returned by the function
		Dim counter As Short '// loop variable
		On Error Resume Next
		'// get length of the id passed
		idLength = Len(previousId)
		'// convert to upper case
		previousId = UCase(previousId)
		
		'// if the last character is not 'Z' then all we have to do is to replace it
		'// with the next in order ; if the last char is '9', make it 'A' and we're done
		''// otherwise compute the next char : note the trick to get the next character -all
		'// what we do is to get the ascii value of the last character, add 1 to it and convert
		'// it back to the corresponding character
		
		If Right(previousId, 1) <> "Z" Then
			If Right(previousId, 1) = "9" Then
				nextId = Left(previousId, idLength - 1) & "A"
			Else
				nextId = Left(previousId, idLength - 1) & Chr(Asc(Right(previousId, 1)) + 1)
			End If
			GoTo Done
			
		End If
		
		'// We have now come to the complex part : the last character is a  'Z'.
		'// we have to recursively replace adjoining 'Z's with 0's while incrementing
		'// the leftmost character. The following code accomplishes just that
		
		nextId = previousId
		
		For counter = idLength To 1 Step -1
			
			'// replace 'Z' with '0' and increment it's leftmost char
			If Mid(nextId, counter, 1) = "Z" Then
				Mid(nextId, counter, 1) = "0"
				If Mid(nextId, counter - 1, 1) <> "Z" Then
					If Mid(nextId, counter - 1, 1) = "9" Then
						Mid(nextId, counter - 1, 1) = "A"
					Else
						Mid(nextId, counter - 1, 1) = Chr(Asc(Mid(nextId, counter - 1, 1)) + 1)
					End If
					Exit For
				End If
			End If
		Next 
		
Done: 
		'UPGRADE_WARNING: Couldn't resolve default property of object IdGenerator. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		IdGenerator = nextId
	End Function
End Module