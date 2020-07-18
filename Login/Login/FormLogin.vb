Imports System.Runtime.InteropServices

Public Class FormLogin
#Region "Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



#End Region
#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'txtUsername
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPassword
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)
    End Sub
#End Region
End Class
