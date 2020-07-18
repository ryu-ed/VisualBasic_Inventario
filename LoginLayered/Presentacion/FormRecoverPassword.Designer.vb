<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecoverPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introducir Usuario o Email"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(31, 55)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(557, 20)
        Me.txtUser.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(513, 81)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Enviar"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(28, 163)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(72, 15)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Resultado"
        '
        'FormRecoverPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 230)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRecoverPassword"
        Me.Text = "FormRecoverPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lblResult As Label


End Class
