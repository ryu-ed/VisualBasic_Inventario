Imports Common
Imports Dominio
Public Class FormEditProfile
    Private Sub FormEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserData()
        initializeControlEditPass()
    End Sub


    Private Sub loadUserData()
        'view
        lblUser.Text = ActiveUser.Usuario
        lblName.Text = ActiveUser.Nombre
        lblLastName.Text = ActiveUser.Apellido
        lblMail.Text = ActiveUser.email
        lblPosition.Text = ActiveUser.Cargo

        'Edit
        txtUser.Text = ActiveUser.Usuario
        txtName.Text = ActiveUser.Nombre
        txtLastName.Text = ActiveUser.Apellido
        txtMail.Text = ActiveUser.email
        txtPass.Text = ActiveUser.Clave
        txtComfirmPass = ActiveUser.Clave
    End Sub
    Private Sub initializeControlEditPass()
        LinkEditPass.Text = "Edit"
        txtPass.UseSystemPasswordChar = True
        txtPass.Enabled = False
        'txtComfirmPass.UseSystemPasswordChar = True
        'txtComfirmPass.Enabled = False
        txtActualPass.Text = ""
    End Sub

    Private Sub reset()
        loadUserData()
        initializeControlEditPass()

    End Sub

    Private Sub LinkEditPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditPass.LinkClicked
        If LinkEditPass.Text = "Edit" Then
            LinkEditPass.Text = "Cancel"
            txtPass.Enabled = True
            txtPass.Text = ""
            txtComfirmPass.Enabled = True
            txtComfirmPass.Text = ""
        ElseIf LinkEditPass.Text = "Cancel" Then

            reset()

        End If
    End Sub

    Private Sub LinkEditProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditProfile.LinkClicked
        Panel1.Visible = True
        loadUserData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPass.Text = txtComfirmPass.Text Then
            If txtActualPass.Text = ActiveUser.Clave Then
                Dim userModel As New UserModel(id_usuario:=ActiveUser.Id_usuario,
                                                    usuario:=txtUser.Text, clave:=txtPass.Text,
                                                    nombre:=txtName.Text, apellido:=txtLastName.Text,
                                                             cargo:=Nothing, email:=txtMail.Text)
                Dim result = userModel.editUserProfile()
                MessageBox.Show(result)
                reset()
                Panel1.Visible = False
            Else
                MessageBox.Show("Clave Actual Incorrecta")
            End If
        Else
                MessageBox.Show("Las Claves no Coinciden")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel1.Visible = False
        reset()
    End Sub
End Class