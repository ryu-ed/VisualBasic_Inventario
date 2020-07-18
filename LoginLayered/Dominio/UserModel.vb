Imports DataAccess
Imports Common
Public Class UserModel
    Dim userDao As New UserDao()

    'Atributos
    Private Id_usuario
    Private Usuario
    Private Clave
    Private Nombre
    Private Apellido
    Private Cargo
    Private email

    Public Property Id_usuario1 As Object
        Get
            Return Id_usuario
        End Get
        Set(value As Object)
            Id_usuario = value
        End Set
    End Property

    Public Property Usuario1 As Object
        Get
            Return Usuario
        End Get
        Set(value As Object)
            Usuario = value
        End Set
    End Property

    Public Property Clave1 As Object
        Get
            Return Clave
        End Get
        Set(value As Object)
            Clave = value
        End Set
    End Property

    Public Property Nombre1 As Object
        Get
            Return Nombre
        End Get
        Set(value As Object)
            Nombre = value
        End Set
    End Property

    Public Property Apellido1 As Object
        Get
            Return Apellido
        End Get
        Set(value As Object)
            Apellido = value
        End Set
    End Property

    Public Property Cargo1 As Object
        Get
            Return Cargo
        End Get
        Set(value As Object)
            Cargo = value
        End Set
    End Property

    Public Property Email1 As Object
        Get
            Return email
        End Get
        Set(value As Object)
            email = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_usuario As Object, usuario As Object, clave As Object, nombre As Object, apellido As Object, cargo As Object, email As Object)
        Me.Id_usuario1 = id_usuario
        Me.Usuario1 = usuario
        Me.Clave1 = clave
        Me.Nombre1 = nombre
        Me.Apellido1 = apellido
        Me.Cargo1 = cargo
        Me.Email1 = email
    End Sub

    Public Function editUserProfile() As String
        Try
            userDao.editProfile(Id_usuario, Usuario, Clave, Nombre, Apellido, email)
            Login(Usuario, Clave)
            Return "Tu perfil se ha actualizado exitosamente!!"


        Catch ex As Exception
            Return "El nombre de usuario esta registrado"
        End Try
    End Function


    Public Function recoverPassword(requestingUser As String) As String
        Return userDao.requestUserPassword(requestingUser)
    End Function

    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function
    Public Function anyMethod(id As Integer) As Boolean
        If ActiveUser.Id_usuario >= 1 Then
            If userDao.existsUser(ActiveUser.Id_usuario) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Sub anyMethod2()
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
