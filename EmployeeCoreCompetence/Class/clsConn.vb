Imports System.Data.SqlClient

Public Class clsConn


    Private conn As SqlConnection


    Public Function OpenConnection() As SqlConnection
        conn = New SqlConnection(m_strConn)
        conn.Open()
        Return conn
    End Function

    Public Sub CloseConnection()
        conn.Close()
        conn.Dispose()
    End Sub
End Class
