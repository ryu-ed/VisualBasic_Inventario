<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdnombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipousuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioDataSet = New Presentacion.InventarioDataSet()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New Presentacion.InventarioDataSetTableAdapters.UsuariosTableAdapter()
        Me.btnCerrar_Form1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(253, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios del Sistema"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(56, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 162)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdusuarioDataGridViewTextBoxColumn, Me.IdnombresDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn, Me.TipousuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsuariosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(670, 159)
        Me.DataGridView1.TabIndex = 0
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "Id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        '
        'IdnombresDataGridViewTextBoxColumn
        '
        Me.IdnombresDataGridViewTextBoxColumn.DataPropertyName = "Id_nombres"
        Me.IdnombresDataGridViewTextBoxColumn.HeaderText = "Id_nombres"
        Me.IdnombresDataGridViewTextBoxColumn.Name = "IdnombresDataGridViewTextBoxColumn"
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        '
        'TipousuarioDataGridViewTextBoxColumn
        '
        Me.TipousuarioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_usuario"
        Me.TipousuarioDataGridViewTextBoxColumn.HeaderText = "Tipo_usuario"
        Me.TipousuarioDataGridViewTextBoxColumn.Name = "TipousuarioDataGridViewTextBoxColumn"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.InventarioDataSet
        '
        'InventarioDataSet
        '
        Me.InventarioDataSet.DataSetName = "InventarioDataSet"
        Me.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_Add.FlatAppearance.BorderSize = 0
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Add.Location = New System.Drawing.Point(758, 65)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(94, 45)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "Añadir"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Edit.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Edit.Location = New System.Drawing.Point(758, 116)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(94, 45)
        Me.btn_Edit.TabIndex = 7
        Me.btn_Edit.Text = "Editar"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Remove
        '
        Me.btn_Remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Remove.BackColor = System.Drawing.Color.DarkSalmon
        Me.btn_Remove.FlatAppearance.BorderSize = 0
        Me.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Remove.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Remove.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Remove.Location = New System.Drawing.Point(758, 167)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(94, 49)
        Me.btn_Remove.TabIndex = 8
        Me.btn_Remove.Text = "Eliminar"
        Me.btn_Remove.UseVisualStyleBackColor = False
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'btnCerrar_Form1
        '
        Me.btnCerrar_Form1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar_Form1.Image = CType(resources.GetObject("btnCerrar_Form1.Image"), System.Drawing.Image)
        Me.btnCerrar_Form1.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrar_Form1.Name = "btnCerrar_Form1"
        Me.btnCerrar_Form1.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar_Form1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar_Form1.TabIndex = 4
        Me.btnCerrar_Form1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 493)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrar_Form1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar_Form1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar_Form1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Remove As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InventarioDataSet As InventarioDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As InventarioDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdnombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipousuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
