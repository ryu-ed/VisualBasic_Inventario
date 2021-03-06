﻿Imports System.Runtime.InteropServices
Imports Common
Imports Dominio


Public Class Principal_Main
#Region "Fomulario Diseño"


    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
#End Region
#Region "Arrastar Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region
#Region "Botones Panel"
    Private Sub btnCerrar_Click_Click(sender As Object, e As EventArgs) Handles btnCerrar_Click.Click
        Application.Exit()
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnRestaurar_Click_Click(sender As Object, e As EventArgs) Handles btnRestaurar_Click.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar_Click.Visible = True
        btnRestaurar_Click.Visible = False
    End Sub

    Private Sub btnMinimizar_Click_Click(sender As Object, e As EventArgs) Handles btnMinimizar_Click.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btnMaximizar_Click_Click(sender As Object, e As EventArgs) Handles btnMaximizar_Click.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar_Click.Visible = False
        btnRestaurar_Click.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub




#End Region
#Region "Hora en el menu principal"
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub PanelFormularios_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormularios.Paint
        HoraFecha.Enabled = True
    End Sub
#End Region
    Private Sub Principal_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        security()
        loadUser()
        permisosUsuario()
    End Sub

    Private Sub loadUser()
        lblName.Text = ActiveUser.Nombre + "  " + ActiveUser.Apellido
        lblCargo.Text = ActiveUser.Cargo
        lblTipo.Text = ActiveUser.Tipo_usuario
    End Sub

    Private Sub security()
        Dim user As New UserModel()

        If user.anyMethod(ActiveUser.Id_usuario) = False Then
            'Codes
            MessageBox.Show("Error")
            Me.Close()
        End If
    End Sub
#Region "Abrir Form"
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario

            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
#End Region
#Region "Botones del menu principal"
    Private Sub Button1_Click_Click(sender As Object, e As EventArgs) Handles Button1_Click.Click
        AbrirFormEnPanel(Of Form1)()
        Button1_Click.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Button2_Click_Click(sender As Object, e As EventArgs) Handles Button2_Click.Click
        AbrirFormEnPanel(Of Form2)()
        Button2_Click.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    Private Sub Button3_Click_Click(sender As Object, e As EventArgs) Handles Button3_Click.Click
        AbrirFormEnPanel(Of Form3)()
        Button3_Click.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    Private Sub Button4_Click_Click(sender As Object, e As EventArgs) Handles Button4_Click.Click
        If MessageBox.Show("Estas seguro de cerrar sesion?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click_Click(sender As Object, e As EventArgs) Handles Button5_Click.Click
        AbrirFormEnPanel(Of Form5)()
        Button5_Click.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub LinkLabelUserProfileEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelUserProfileEdit.LinkClicked
        AbrirFormEnPanel(Of FormEditProfile)()
    End Sub
#End Region

#Region "Metodo Para cerrar Forms"
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("Form1") Is Nothing) Then
            Button1_Click.BackColor = Color.FromArgb(4, 41, 68)

        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            Button2_Click.BackColor = Color.FromArgb(4, 41, 68)

        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            Button3_Click.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form4") Is Nothing) Then
            Button5_Click.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form5") Is Nothing) Then
            Button5_Click.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub
#End Region

    Private Sub permisosUsuario()

        If ActiveUser.Tipo_usuario = TipoUsuario.otros Then
            'Otros como profesores y demas solo podran ver el boton de lista de equipos
            Button1_Click.Enabled = False
            Button3_Click.Enabled = False
            Button5_Click.Enabled = False
        End If


        If ActiveUser.Tipo_usuario = TipoUsuario.tecnico Then
            'Pueden ver todo menos configuracion
            Button5_Click.Enabled = False
        End If
    End Sub

End Class
