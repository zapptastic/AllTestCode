Imports Microsoft.VisualBasic
Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlClient

Public Class DBCRUD
    'will pass UserID,Name,Phone,Email,Address,City,Username,Password as Indexes 0,1,2,3,4,5,6,7
    'Dim conn = New SqlConnection(ConnectionStrings("sample").ConnectionString)

    'Handles all non-queries
    Public Sub ExecNonQ(ByVal conn As String, uid As String, ByVal pwd As String, ByVal strqry As String)
        Dim mycon As SqlConnection = New SqlConnection(conn)
        mycon.Open()
        Dim cmd = New SqlCommand(strqry, mycon)
        cmd.ExecuteNonQuery()
        mycon.Close()
        mycon.Dispose()
    End Sub

    Public Function SelectQ(ByVal conn As String, uid As String, ByVal pwd As String, ByVal strqry As String) As SqlDataReader
        Dim mycon As SqlConnection = New SqlConnection(conn)
        mycon.Open()
        Dim cmd = New SqlCommand(strqry, mycon)
        Dim dr = cmd.ExecuteReader()
        'mycon.Close()
        'mycon.Dispose()
        Return dr
    End Function
    'Public Function Insert(ByVal arr() As String) As String

    '    Try
    '        conn.Open()

    '        Dim sql = "INSERT INTO UserMaster"
    '        Dim cmd = New SqlCommand(sql, conn)

    '        cmd.ExecuteNonQuery()
    '        conn.Close()
    '        Return "User created successfully"
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    'End Function
    'Public Function Update(ByVal arr() As String) As String
    '    Try
    '        conn.Open()
    '        Dim sql = "UPDATE UserMaster SET Name='"
    '        Dim cmd = New SqlCommand(sql, conn)
    '        cmd.ExecuteNonQuery()
    '        conn.Close()
    '        Return "User record updated successfully"
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    'End Function
End Class
