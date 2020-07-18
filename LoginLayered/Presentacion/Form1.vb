Imports Common
Public Class Form1
    Private Sub btnCerrar_Form1_Click(sender As Object, e As EventArgs) Handles btnCerrar_Form1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.InventarioDataSet.Usuarios)
        permisoUsuario()
    End Sub

    Private Sub permisoUsuario()
        If ActiveUser.Tipo_usuario = TipoUsuario.tecnico Then
            'Pueden ver todo menos configuracion
            btn_Remove.Enabled = False
            btn_Add.Enabled = False
            btn_Edit.Enabled = False
        End If
    End Sub
End Class