<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Button3_Click = New System.Windows.Forms.Button()
        Me.Button2_Click = New System.Windows.Forms.Button()
        Me.Button1_Click = New System.Windows.Forms.Button()
        Me.btnRestaurar_Click = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar_Click = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar_Click = New System.Windows.Forms.PictureBox()
        Me.btnCerrar_Click = New System.Windows.Forms.PictureBox()
        Me.Button4_Click = New System.Windows.Forms.Button()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnRestaurar_Click, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar_Click, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar_Click, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar_Click, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(800, 450)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar_Click)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(800, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button4_Click)
        Me.PanelMenu.Controls.Add(Me.Button3_Click)
        Me.PanelMenu.Controls.Add(Me.Button2_Click)
        Me.PanelMenu.Controls.Add(Me.Button1_Click)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 410)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(550, 410)
        Me.PanelFormularios.TabIndex = 2
        '
        'Button3_Click
        '
        Me.Button3_Click.FlatAppearance.BorderSize = 0
        Me.Button3_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button3_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3_Click.Image = Global.MenuPrincipal.My.Resources.Resources.calendar__1_1
        Me.Button3_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3_Click.Location = New System.Drawing.Point(0, 176)
        Me.Button3_Click.Name = "Button3_Click"
        Me.Button3_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button3_Click.TabIndex = 2
        Me.Button3_Click.Text = "Planificacion"
        Me.Button3_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3_Click.UseVisualStyleBackColor = True
        '
        'Button2_Click
        '
        Me.Button2_Click.FlatAppearance.BorderSize = 0
        Me.Button2_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button2_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button2_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2_Click.Image = Global.MenuPrincipal.My.Resources.Resources.seo1
        Me.Button2_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2_Click.Location = New System.Drawing.Point(0, 130)
        Me.Button2_Click.Name = "Button2_Click"
        Me.Button2_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button2_Click.TabIndex = 1
        Me.Button2_Click.Text = "Productos"
        Me.Button2_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2_Click.UseVisualStyleBackColor = True
        '
        'Button1_Click
        '
        Me.Button1_Click.FlatAppearance.BorderSize = 0
        Me.Button1_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1_Click.Image = Global.MenuPrincipal.My.Resources.Resources.patient__1_1
        Me.Button1_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Click.Location = New System.Drawing.Point(0, 84)
        Me.Button1_Click.Name = "Button1_Click"
        Me.Button1_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button1_Click.TabIndex = 0
        Me.Button1_Click.Text = "Usuarios"
        Me.Button1_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1_Click.UseVisualStyleBackColor = True
        '
        'btnRestaurar_Click
        '
        Me.btnRestaurar_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar_Click.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar_Click.Image = Global.MenuPrincipal.My.Resources.Resources.restore
        Me.btnRestaurar_Click.Location = New System.Drawing.Point(739, 12)
        Me.btnRestaurar_Click.Name = "btnRestaurar_Click"
        Me.btnRestaurar_Click.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestaurar_Click.TabIndex = 3
        Me.btnRestaurar_Click.TabStop = False
        Me.btnRestaurar_Click.Visible = False
        '
        'btnMaximizar_Click
        '
        Me.btnMaximizar_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar_Click.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar_Click.Image = Global.MenuPrincipal.My.Resources.Resources.expand
        Me.btnMaximizar_Click.Location = New System.Drawing.Point(739, 12)
        Me.btnMaximizar_Click.Name = "btnMaximizar_Click"
        Me.btnMaximizar_Click.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar_Click.TabIndex = 2
        Me.btnMaximizar_Click.TabStop = False
        '
        'btnMinimizar_Click
        '
        Me.btnMinimizar_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar_Click.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar_Click.Image = Global.MenuPrincipal.My.Resources.Resources.Minimize_Icon
        Me.btnMinimizar_Click.Location = New System.Drawing.Point(708, 12)
        Me.btnMinimizar_Click.Name = "btnMinimizar_Click"
        Me.btnMinimizar_Click.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar_Click.TabIndex = 1
        Me.btnMinimizar_Click.TabStop = False
        '
        'btnCerrar_Click
        '
        Me.btnCerrar_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar_Click.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar_Click.Image = Global.MenuPrincipal.My.Resources.Resources.Close_Icon
        Me.btnCerrar_Click.Location = New System.Drawing.Point(772, 12)
        Me.btnCerrar_Click.Name = "btnCerrar_Click"
        Me.btnCerrar_Click.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar_Click.TabIndex = 0
        Me.btnCerrar_Click.TabStop = False
        '
        'Button4_Click
        '
        Me.Button4_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4_Click.FlatAppearance.BorderSize = 0
        Me.Button4_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button4_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button4_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4_Click.Image = Global.MenuPrincipal.My.Resources.Resources.logout__1_1
        Me.Button4_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4_Click.Location = New System.Drawing.Point(-3, 367)
        Me.Button4_Click.Name = "Button4_Click"
        Me.Button4_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button4_Click.TabIndex = 3
        Me.Button4_Click.Text = "Log out"
        Me.Button4_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4_Click.UseVisualStyleBackColor = True
        '
        'Principal_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "Principal_Main"
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnRestaurar_Click, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar_Click, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar_Click, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar_Click, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnMaximizar_Click As PictureBox
    Friend WithEvents btnMinimizar_Click As PictureBox
    Friend WithEvents btnCerrar_Click As PictureBox
    Friend WithEvents btnRestaurar_Click As PictureBox
    Friend WithEvents Button3_Click As Button
    Friend WithEvents Button2_Click As Button
    Friend WithEvents Button1_Click As Button
    Friend WithEvents Button4_Click As Button
End Class
