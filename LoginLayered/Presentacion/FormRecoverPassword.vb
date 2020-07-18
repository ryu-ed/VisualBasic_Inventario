Imports Dominio


Public Class FormRecoverPassword
    Private Sub btnSend_Click(Sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoverPassword(txtUser.Text)
        lblResult.Text = result

    End Sub
End Class