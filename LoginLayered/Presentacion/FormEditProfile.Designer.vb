<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditProfile
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditProfile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkEditPass = New System.Windows.Forms.LinkLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtActualPass = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtComfirmPass = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New Presentacion.InventarioDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar_Form1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkEditProfile = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar_Form1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mi Perfil"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LinkEditPass)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtActualPass)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtComfirmPass)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtMail)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(428, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 524)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'LinkEditPass
        '
        Me.LinkEditPass.AutoSize = True
        Me.LinkEditPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkEditPass.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkEditPass.Location = New System.Drawing.Point(129, 259)
        Me.LinkEditPass.Name = "LinkEditPass"
        Me.LinkEditPass.Size = New System.Drawing.Size(29, 13)
        Me.LinkEditPass.TabIndex = 21
        Me.LinkEditPass.TabStop = True
        Me.LinkEditPass.Text = "Edit"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(23, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 45)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(192, 427)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 45)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtActualPass
        '
        Me.txtActualPass.Location = New System.Drawing.Point(23, 370)
        Me.txtActualPass.Name = "txtActualPass"
        Me.txtActualPass.Size = New System.Drawing.Size(314, 20)
        Me.txtActualPass.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(19, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 19)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Actual Clave:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtComfirmPass
        '
        Me.txtComfirmPass.Location = New System.Drawing.Point(23, 321)
        Me.txtComfirmPass.Name = "txtComfirmPass"
        Me.txtComfirmPass.Size = New System.Drawing.Size(314, 20)
        Me.txtComfirmPass.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(19, 302)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 19)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Confirmar Clave:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(23, 275)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(314, 20)
        Me.txtPass.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(19, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 19)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Nueva Clave:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(23, 228)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(314, 20)
        Me.txtMail.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(19, 206)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 19)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Email:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(23, 180)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(314, 20)
        Me.txtLastName.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(19, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Apellido:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(23, 139)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 20)
        Me.txtName.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Primer Nombre:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(23, 98)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(314, 20)
        Me.txtUser.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(19, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 19)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Nombre de Usuario:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Editar Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Presentacion.InventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsuariosTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar_Form1
        '
        Me.btnCerrar_Form1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar_Form1.Image = CType(resources.GetObject("btnCerrar_Form1.Image"), System.Drawing.Image)
        Me.btnCerrar_Form1.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrar_Form1.Name = "btnCerrar_Form1"
        Me.btnCerrar_Form1.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar_Form1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar_Form1.TabIndex = 5
        Me.btnCerrar_Form1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(236, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre de Usuario:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(248, 98)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(47, 16)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "Usuario"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(248, 139)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 16)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "nombre"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(236, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nombre:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(248, 176)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(52, 16)
        Me.lblLastName.TabIndex = 15
        Me.lblLastName.Text = "apellido"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(236, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Apellido:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMail
        '
        Me.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(248, 216)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(47, 16)
        Me.lblMail.TabIndex = 17
        Me.lblMail.Text = "Usuario"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(236, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Email:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(248, 257)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(40, 16)
        Me.lblPosition.TabIndex = 19
        Me.lblPosition.Text = "cargo"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(236, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Cargo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkEditProfile
        '
        Me.LinkEditProfile.AutoSize = True
        Me.LinkEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkEditProfile.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkEditProfile.Location = New System.Drawing.Point(171, 294)
        Me.LinkEditProfile.Name = "LinkEditProfile"
        Me.LinkEditProfile.Size = New System.Drawing.Size(73, 13)
        Me.LinkEditProfile.TabIndex = 20
        Me.LinkEditProfile.TabStop = True
        Me.LinkEditProfile.Text = "Editar Perfil"
        '
        'FormEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.LinkEditProfile)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar_Form1)
        Me.Name = "FormEditProfile"
        Me.Text = "FormEditProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar_Form1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar_Form1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableAdapterManager1 As InventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtActualPass As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtComfirmPass As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LinkEditProfile As LinkLabel
    Friend WithEvents btnSave As Button
    Friend WithEvents LinkEditPass As LinkLabel
    Friend WithEvents btnCancel As Button
End Class
