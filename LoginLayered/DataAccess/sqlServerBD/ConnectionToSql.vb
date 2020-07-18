Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()
        connectionString = "Server=DESKTOP-KCVBBKH\SQLEXPRESS;DataBase=Inventario; integrated security = true"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
