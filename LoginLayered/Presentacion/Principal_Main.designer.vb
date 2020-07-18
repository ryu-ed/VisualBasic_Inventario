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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal_Main))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.Button5_Click = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4_Click = New System.Windows.Forms.Button()
        Me.Button3_Click = New System.Windows.Forms.Button()
        Me.Button2_Click = New System.Windows.Forms.Button()
        Me.Button1_Click = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar_Click = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar_Click = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar_Click = New System.Windows.Forms.PictureBox()
        Me.btnCerrar_Click = New System.Windows.Forms.PictureBox()
        Me.LinkLabelUserProfileEdit = New System.Windows.Forms.LinkLabel()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelContenedor.Size = New System.Drawing.Size(1145, 571)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Controls.Add(Me.lblFecha)
        Me.PanelFormularios.Controls.Add(Me.lblHora)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(279, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(866, 531)
        Me.PanelFormularios.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(133, 262)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(139, 46)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Label1"
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(238, 154)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(276, 91)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Label1"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button5_Click)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.Button4_Click)
        Me.PanelMenu.Controls.Add(Me.Button3_Click)
        Me.PanelMenu.Controls.Add(Me.Button2_Click)
        Me.PanelMenu.Controls.Add(Me.Button1_Click)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(279, 531)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LinkLabelUserProfileEdit)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblCargo)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 105)
        Me.Panel1.TabIndex = 0
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.lblTipo.ForeColor = System.Drawing.Color.Silver
        Me.lblTipo.Location = New System.Drawing.Point(76, 68)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(119, 20)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Tipo de Usuario"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.lblName.ForeColor = System.Drawing.Color.Silver
        Me.lblName.Location = New System.Drawing.Point(76, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nombre"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.lblCargo.ForeColor = System.Drawing.Color.Silver
        Me.lblCargo.Location = New System.Drawing.Point(76, 48)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(56, 20)
        Me.lblCargo.TabIndex = 3
        Me.lblCargo.Text = "Cargo"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox3)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar_Click)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar_Click)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1145, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Menu Principal"
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'Button5_Click
        '
        Me.Button5_Click.FlatAppearance.BorderSize = 0
        Me.Button5_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button5_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button5_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5_Click.Image = CType(resources.GetObject("Button5_Click.Image"), System.Drawing.Image)
        Me.Button5_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5_Click.Location = New System.Drawing.Point(3, 259)
        Me.Button5_Click.Name = "Button5_Click"
        Me.Button5_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button5_Click.TabIndex = 4
        Me.Button5_Click.Text = "Configuracion"
        Me.Button5_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5_Click.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(244, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.Button4_Click.Image = CType(resources.GetObject("Button4_Click.Image"), System.Drawing.Image)
        Me.Button4_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4_Click.Location = New System.Drawing.Point(-3, 488)
        Me.Button4_Click.Name = "Button4_Click"
        Me.Button4_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button4_Click.TabIndex = 3
        Me.Button4_Click.Text = "Log out"
        Me.Button4_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4_Click.UseVisualStyleBackColor = True
        '
        'Button3_Click
        '
        Me.Button3_Click.FlatAppearance.BorderSize = 0
        Me.Button3_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button3_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3_Click.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3_Click.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3_Click.Image = CType(resources.GetObject("Button3_Click.Image"), System.Drawing.Image)
        Me.Button3_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3_Click.Location = New System.Drawing.Point(0, 212)
        Me.Button3_Click.Name = "Button3_Click"
        Me.Button3_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button3_Click.TabIndex = 2
        Me.Button3_Click.Text = "Generar Reportes"
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
        Me.Button2_Click.Image = CType(resources.GetObject("Button2_Click.Image"), System.Drawing.Image)
        Me.Button2_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2_Click.Location = New System.Drawing.Point(0, 166)
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
        Me.Button1_Click.Image = CType(resources.GetObject("Button1_Click.Image"), System.Drawing.Image)
        Me.Button1_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Click.Location = New System.Drawing.Point(0, 120)
        Me.Button1_Click.Name = "Button1_Click"
        Me.Button1_Click.Size = New System.Drawing.Size(250, 40)
        Me.Button1_Click.TabIndex = 0
        Me.Button1_Click.Text = "Usuarios"
        Me.Button1_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1_Click.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'btnRestaurar_Click
        '
        Me.btnRestaurar_Click.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar_Click.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar_Click.Image = CType(resources.GetObject("btnRestaurar_Click.Image"), System.Drawing.Image)
        Me.btnRestaurar_Click.Location = New System.Drawing.Point(1084, 12)
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
        Me.btnMaximizar_Click.Image = CType(resources.GetObject("btnMaximizar_Click.Image"), System.Drawing.Image)
        Me.btnMaximizar_Click.Location = New System.Drawing.Point(1084, 12)
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
        Me.btnMinimizar_Click.Image = CType(resources.GetObject("btnMinimizar_Click.Image"), System.Drawing.Image)
        Me.btnMinimizar_Click.Location = New System.Drawing.Point(1053, 12)
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
        Me.btnCerrar_Click.Image = CType(resources.GetObject("btnCerrar_Click.Image"), System.Drawing.Image)
        Me.btnCerrar_Click.Location = New System.Drawing.Point(1117, 12)
        Me.btnCerrar_Click.Name = "btnCerrar_Click"
        Me.btnCerrar_Click.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar_Click.TabIndex = 0
        Me.btnCerrar_Click.TabStop = False
        '
        'LinkLabelUserProfileEdit
        '
        Me.LinkLabelUserProfileEdit.AutoSize = True
        Me.LinkLabelUserProfileEdit.LinkColor = System.Drawing.Color.SteelBlue
        Me.LinkLabelUserProfileEdit.Location = New System.Drawing.Point(150, 16)
        Me.LinkLabelUserProfileEdit.Name = "LinkLabelUserProfileEdit"
        Me.LinkLabelUserProfileEdit.Size = New System.Drawing.Size(73, 13)
        Me.LinkLabelUserProfileEdit.TabIndex = 2
        Me.LinkLabelUserProfileEdit.TabStop = True
        Me.LinkLabelUserProfileEdit.Text = "Editar Usuario"
        '
        'Principal_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 571)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "Principal_Main"
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents Button5_Click As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabelUserProfileEdit As LinkLabel
End Class
