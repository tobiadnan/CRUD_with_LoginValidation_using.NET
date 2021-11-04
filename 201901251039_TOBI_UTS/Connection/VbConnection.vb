Imports System.Data
Imports System.Data.SqlClient

Namespace Connection
    Public Class VbConnection
        Public conn As New SqlConnection("Data Source=TOBYADNAN\SQLEXPRESS;Initial Catalog=dbUtsVb;Integrated Security=True")

        Public Function Open() As SqlConnection
            conn.Open()
            Return conn
        End Function

        Public Sub Close()
            conn.Close()
        End Sub
    End Class
End Namespace

