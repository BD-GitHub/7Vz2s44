Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class SQLControl
    Implements IDisposable

    'Public Const connect As String = "Data Source=NEXUS;Initial Catalog=Tss;Integrated Security=True"
    'Public SQLTssCon As New SqlConnection With {.ConnectionString = GetConnectionStringByName("TssConnect1")}

    ' SQL CONNECTION
    'Private SQLCon As New SqlConnection(connect)
    Private SQLCon As New SqlConnection With {.ConnectionString = GetConnectionStringByName("TssConnect1")}
    Private SQLCmd As SqlCommand

    ' SQL DATA
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String
    Public iStatus As Integer

    Public Sub ExecQuery(Query As String)
        Try
            SQLCon.Open()

            ' CREATE SQL COMMAND
            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD PARAMETERS INTO SQL COMMAND
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))

            ' CLEAR PARAMETER LIST
            Params.Clear()

            ' EXECUTE COMMAND AND FILL DATASET
            SQLDS = New DataSet
            SQLDA = New SqlDataAdapter(SQLCmd)
            RecordCount = SQLDA.Fill(SQLDS)

            SQLCon.Close()
        Catch ex As Exception
            ' CAPTURE ERRORS
            Exception = ex.Message
        End Try

        ' MAKE SURE THE CONNECTION IS CLOSED
        If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
    End Sub

    Public Sub ExecNonQuery(Query As String)
        Try
            SQLCon.Open()

            ' CREATE SQL COMMAND
            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD PARAMETERS INTO SQL COMMAND
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))

            ' CLEAR PARAMETER LIST
            Params.Clear()

            ' EXECUTE COMMAND
            RecordCount = SQLCmd.ExecuteNonQuery()

            iStatus = CShort(SQLCmd.Parameters.Item(0).Value)
            MsgBox("iReturn: " & iStatus)


            SQLCon.Close()
        Catch ex As Exception
            ' CAPTURE ERRORS
            Exception = ex.Message
        End Try

        ' MAKE SURE THE CONNECTION IS CLOSED
        If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
    End Sub

    Public Sub ExecuteReader(Query As String)
        Try
            SQLCon.Open()

            ' CREATE SQL COMMAND
            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD PARAMETERS INTO SQL COMMAND
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))

            ' CLEAR PARAMETER LIST
            Params.Clear()

            ' EXECUTE COMMAND AND FILL DATASET
            'SQLDS = New DataSet
            'SQLDA = New SqlDataAdapter(SQLCmd)
            'RecordCount = SQLDA.Fill(SQLDS)

 
            Dim reader As SqlDataReader = SQLCmd.ExecuteReader()
                While reader.Read()
                'Console.WriteLine("{0} - {1}", reader.GetString(0), reader.GetString(1))
                MsgBox(String.Format("Values: {0} {1}", reader.GetString(1), reader.GetString(1)))
                End While
                reader.Close()


            'Console.WriteLine("{0} - {1}", _
            MsgBox("iReturn: " & SQLCmd.Parameters("@iReturn").Value.ToString())


            SQLCon.Close()
            Catch ex As Exception
                ' CAPTURE ERRORS
                Exception = ex.Message
            End Try

        ' MAKE SURE THE CONNECTION IS CLOSED
        If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Sub AddParamOp(Name As String)
        Dim RetValue As New SqlParameter(Name, SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        Params.Add(RetValue)
    End Sub

    ' Retrives a connection string by name.
    ' Returns Nothing if the name is not found.
    Private Shared Function GetConnectionStringByName(ByVal name As String) As String

        ' Assume failure
        Dim returnValue As String = Nothing

        ' Look for the name in the connectionStrings section.
        Dim settings As ConnectionStringSettings = _
            ConfigurationManager.ConnectionStrings(name)

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            returnValue = settings.ConnectionString
        End If

        Return returnValue

    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
