<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleBar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.btnMinimize)
        Me.TitleBar.Controls.Add(Me.btnClose)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(473, 40)
        Me.TitleBar.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(411, 11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(445, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 637)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 15)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(59, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UserName"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(63, 287)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(350, 20)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(63, 353)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(350, 20)
        Me.txtPass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(59, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.CheckBox1.Location = New System.Drawing.Point(63, 392)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 21)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Remember me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(63, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.LinkColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(157, 604)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(140, 20)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.TabStop = True
        Me.lblEmail.Text = "Forgot password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(130, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(473, 652)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Login"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEmail As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
