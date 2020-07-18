<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.btnCerrar_Form1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnCerrar_Form1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(280, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FORMULARIO 5"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar_Form1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.btnCerrar_Form1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar_Form1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
