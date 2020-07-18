Imports System.Data.SqlClient
Imports System.Data
Imports Common
Public Class UserDao
    Inherits ConnectionToSql

    Public Sub editProfile(id, user, pass, name, lastName, mail)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Usuarios set Usuario=@user, Clave=@pass, Nombre=@name, Apellido=@lastName, email=@mail INNER JOIN Nombres ON Usuarios.Id_usuario = Nombres.Id_nombres where Id_Usuario=@id "
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@mail", mail)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function requestUserPassword(requestingUser As String) As String
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM Usuarios INNER JOIN Nombres ON Usuarios.Id_usuario = Nombres.Id_nombres where Usuario=@user or email=@mail"
                command.Parameters.AddWithValue("@user", requestingUser)
                command.Parameters.AddWithValue("@mail", requestingUser)
                command.CommandType = CommandType.Text

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() = True Then
                    'Return "Se logro la conexion"
                    Dim userName = reader.GetString(8) & ", " & reader.GetString(9)
                    Dim userMail = reader.GetString(6)
                    Dim userPassword = reader.GetString(3)

                    Dim mailSupport As New SystemSupportMail()

                    mailSupport.sendMail(subject:="SYSTEM: Proceso de recueracion de clave",
                    body:="Hola " & userName & vbNewLine & "Haz solicitado recuperar tu clave." &
                    vbNewLine & "Tu clave es: " & userPassword & vbNewLine &
                    "Cambie la clave una vez ingrese al sistema.", receiverMail:=New List(Of String) From {userMail})
                    Return "Hola " & userName & vbNewLine & "Solicitaste recuperar tu clave." & vbNewLine &
                    "Por favor revisa tu correo: " & userMail & vbNewLine &
                    "Cambia la clave una vez ingreses al sistema."
                Else
                    Return "Lo siento, al parecer no tiene una cuenta de usuario o email en sistema"


                End If
            End Using
        End Using
    End Function


    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM Usuarios INNER JOIN Nombres ON Usuarios.Id_usuario = Nombres.Id_nombres where Usuario=@user and Clave=@pass"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.Id_usuario = reader.GetValue(0)
                        ActiveUser.Nombre = reader.GetString(8)
                        ActiveUser.Apellido = reader.GetString(9)
                        ActiveUser.Cargo = reader.GetString(10)
                        ActiveUser.Tipo_usuario = reader.GetString(5)
                        ActiveUser.email = reader.GetString(6)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function existsUser(id As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM Usuarios INNER JOIN Nombres ON Usuarios.Id_usuario = Nombres.Id_nombres where Id_usuario=@user"
                command.Parameters.AddWithValue("@user", Id_usuario)

                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then

                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Sub anyMethod3()
        If ActiveUser.Tipo_usuario = TipoUsuario.tecnico Then
            'Codes
        End If
        If ActiveUser.Tipo_usuario = TipoUsuario.administrador Then
            'Codes
        End If
        If ActiveUser.Tipo_usuario = TipoUsuario.root Then
            'Codes
        End If
        If ActiveUser.Tipo_usuario = TipoUsuario.otros Then
            'Codes
        End If
    End Sub
End Class
