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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.TBSaldo = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBFoto = New System.Windows.Forms.TextBox()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.DTPFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LFechaNacimiento = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBAvatar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Practico5.My.Resources.Resources.FondoNedroDeFormulario
        Me.Panel1.Controls.Add(Me.RBMujer)
        Me.Panel1.Controls.Add(Me.RBHombre)
        Me.Panel1.Controls.Add(Me.TBSaldo)
        Me.Panel1.Controls.Add(Me.TBApellido)
        Me.Panel1.Controls.Add(Me.TBNombre)
        Me.Panel1.Controls.Add(Me.TBFoto)
        Me.Panel1.Controls.Add(Me.BFoto)
        Me.Panel1.Controls.Add(Me.DTPFechaNacimiento)
        Me.Panel1.Controls.Add(Me.LSaldo)
        Me.Panel1.Controls.Add(Me.LSexo)
        Me.Panel1.Controls.Add(Me.LFechaNacimiento)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Font = New System.Drawing.Font("Papyrus", 16.0!)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(43, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 338)
        Me.Panel1.TabIndex = 0
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.BackColor = System.Drawing.Color.Transparent
        Me.RBMujer.Font = New System.Drawing.Font("Papyrus", 10.0!)
        Me.RBMujer.Location = New System.Drawing.Point(269, 150)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(76, 31)
        Me.RBMujer.TabIndex = 16
        Me.RBMujer.TabStop = True
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = False
        '
        'RBHombre
        '
        Me.RBHombre.AutoSize = True
        Me.RBHombre.BackColor = System.Drawing.Color.Transparent
        Me.RBHombre.Checked = True
        Me.RBHombre.Font = New System.Drawing.Font("Papyrus", 10.0!)
        Me.RBHombre.Location = New System.Drawing.Point(150, 150)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(95, 31)
        Me.RBHombre.TabIndex = 15
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = False
        '
        'TBSaldo
        '
        Me.TBSaldo.Location = New System.Drawing.Point(150, 187)
        Me.TBSaldo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSaldo.Multiline = True
        Me.TBSaldo.Name = "TBSaldo"
        Me.TBSaldo.Size = New System.Drawing.Size(400, 28)
        Me.TBSaldo.TabIndex = 14
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(150, 73)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBApellido.Multiline = True
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(400, 28)
        Me.TBApellido.TabIndex = 12
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(150, 30)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBNombre.Multiline = True
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(400, 28)
        Me.TBNombre.TabIndex = 11
        '
        'TBFoto
        '
        Me.TBFoto.Location = New System.Drawing.Point(150, 233)
        Me.TBFoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBFoto.Multiline = True
        Me.TBFoto.Name = "TBFoto"
        Me.TBFoto.Size = New System.Drawing.Size(400, 34)
        Me.TBFoto.TabIndex = 10
        '
        'BFoto
        '
        Me.BFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BFoto.ForeColor = System.Drawing.Color.Black
        Me.BFoto.Location = New System.Drawing.Point(28, 236)
        Me.BFoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(100, 28)
        Me.BFoto.TabIndex = 9
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'DTPFechaNacimiento
        '
        Me.DTPFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimiento.Location = New System.Drawing.Point(269, 110)
        Me.DTPFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        Me.DTPFechaNacimiento.Size = New System.Drawing.Size(110, 26)
        Me.DTPFechaNacimiento.TabIndex = 8
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.BackColor = System.Drawing.Color.Transparent
        Me.LSaldo.ForeColor = System.Drawing.Color.White
        Me.LSaldo.Location = New System.Drawing.Point(20, 182)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(100, 42)
        Me.LSaldo.TabIndex = 7
        Me.LSaldo.Text = "Saldo:"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.BackColor = System.Drawing.Color.Transparent
        Me.LSexo.ForeColor = System.Drawing.Color.White
        Me.LSexo.Location = New System.Drawing.Point(20, 142)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(91, 42)
        Me.LSexo.TabIndex = 6
        Me.LSexo.Text = "Sexo:"
        '
        'LFechaNacimiento
        '
        Me.LFechaNacimiento.AutoSize = True
        Me.LFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LFechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.LFechaNacimiento.Location = New System.Drawing.Point(20, 103)
        Me.LFechaNacimiento.Name = "LFechaNacimiento"
        Me.LFechaNacimiento.Size = New System.Drawing.Size(241, 42)
        Me.LFechaNacimiento.TabIndex = 5
        Me.LFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.Transparent
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(20, 62)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(127, 42)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'BAgregar
        '
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BAgregar.ForeColor = System.Drawing.Color.Black
        Me.BAgregar.Image = Global.Practico5.My.Resources.Resources.Agregar__2_
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(233, 287)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(124, 40)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(20, 22)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(121, 42)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre:"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DGVDatos
        '
        Me.DGVDatos.AllowUserToAddRows = False
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.FechaNacimiento, Me.Sexo, Me.Eliminar, Me.Saldo, Me.Foto, Me.Ruta})
        Me.DGVDatos.Location = New System.Drawing.Point(-1, 359)
        Me.DGVDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.RowHeadersWidth = 51
        Me.DGVDatos.RowTemplate.Height = 80
        Me.DGVDatos.Size = New System.Drawing.Size(1060, 200)
        Me.DGVDatos.TabIndex = 2
        '
        'Nombre
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Apellido
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Apellido.DefaultCellStyle = DataGridViewCellStyle2
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 6
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 125
        '
        'FechaNacimiento
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNacimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.MinimumWidth = 6
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Width = 125
        '
        'Sexo
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Sexo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.MinimumWidth = 6
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 125
        '
        'Eliminar
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle5
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 125
        '
        'Saldo
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle6
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.MinimumWidth = 6
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 125
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Foto.MinimumWidth = 6
        Me.Foto.Name = "Foto"
        Me.Foto.Width = 125
        '
        'Ruta
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Ruta.DefaultCellStyle = DataGridViewCellStyle7
        Me.Ruta.HeaderText = "Ruta"
        Me.Ruta.MinimumWidth = 6
        Me.Ruta.Name = "Ruta"
        Me.Ruta.Width = 125
        '
        'PBAvatar
        '
        Me.PBAvatar.BackgroundImage = Global.Practico5.My.Resources.Resources.Usuario
        Me.PBAvatar.Location = New System.Drawing.Point(671, 13)
        Me.PBAvatar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBAvatar.Name = "PBAvatar"
        Me.PBAvatar.Size = New System.Drawing.Size(275, 276)
        Me.PBAvatar.TabIndex = 1
        Me.PBAvatar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico5.My.Resources.Resources.FondoNegroCuadrados
        Me.ClientSize = New System.Drawing.Size(1051, 553)
        Me.Controls.Add(Me.DGVDatos)
        Me.Controls.Add(Me.PBAvatar)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Formulario con DataGrid"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents BAgregar As Button
    Friend WithEvents LNombre As Label
    Friend WithEvents PBAvatar As PictureBox
    Friend WithEvents LSaldo As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents DTPFechaNacimiento As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BFoto As Button
    Friend WithEvents TBFoto As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents TBSaldo As TextBox
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
End Class
