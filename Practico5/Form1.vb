Imports System.IO
'Imports System.Net.WebRequestMethods
Imports System.Reflection

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim defaultImg As Image = Image.FromFile(Path.Combine(Application.StartupPath, "Fotos", "Usuario.png"))
        Dim colFoto As DataGridViewImageColumn = CType(DGVDatos.Columns("Foto"), DataGridViewImageColumn)
        colFoto.DefaultCellStyle.NullValue = defaultImg
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LSaldo.Click

    End Sub

    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then Return

        Dim origen = OpenFileDialog1.FileName
        Dim nombre = Path.GetFileName(origen)
        Dim destinoFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Fotos")
        If Not Directory.Exists(destinoFolder) Then Directory.CreateDirectory(destinoFolder)

        Dim destino = Path.Combine(destinoFolder, nombre)
        System.IO.File.Copy(origen, destino, True)

        TBFoto.Text = destino
        PBAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PBAvatar.Image = Image.FromFile(destino)
    End Sub

    Private Function Capitalizar(texto As String) As String
        If String.IsNullOrWhiteSpace(texto) Then Return String.Empty
        texto = texto.Trim().ToLower()
        Return Char.ToUpper(texto(0)) & texto.Substring(1)
    End Function

    Private Sub TBNombre_Leave(sender As Object, e As EventArgs) Handles TBNombre.Leave
        TBNombre.Text = Capitalizar(TBNombre.Text)
    End Sub

    Private Sub TBApellido_Leave(sender As Object, e As EventArgs) Handles TBApellido.Leave
        TBApellido.Text = Capitalizar(TBApellido.Text)
    End Sub

    Private Sub DGVDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatos.CellContentClick
        ' Verificar que se hizo clic en una fila valida y en la columna "Eliminar"
        If e.RowIndex >= 0 AndAlso DGVDatos.Columns(e.ColumnIndex).Name = "Eliminar" Then
            Dim respuesta As MsgBoxResult = MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar eliminación")
            If respuesta = MsgBoxResult.Yes Then
                DGVDatos.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        ' Validar que no esten vacios
        If TBNombre.Text = "" Or TBApellido.Text = "" Or TBSaldo.Text = "" Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        ' Validar sexo
        Dim sexoSeleccionado As String
        If RBHombre.Checked Then
            sexoSeleccionado = "Hombre"
        Else
            sexoSeleccionado = "Mujer"
        End If

        ' Verificar si no se selecciono foto y asignar ruta por defecto
        Dim rutaFoto As String = If(String.IsNullOrWhiteSpace(TBFoto.Text), Path.Combine(Application.StartupPath, "Fotos", "Usuario.png"), TBFoto.Text)
        TBFoto.Text = rutaFoto

        Dim idx As Integer = DGVDatos.Rows.Add(TBNombre.Text, TBApellido.Text, DTPFechaNacimiento.Text,
                                               sexoSeleccionado, Nothing, TBSaldo.Text, PBAvatar.Image, TBFoto.Text)

        Dim nuevaFila As DataGridViewRow = DGVDatos.Rows(idx)

        Dim saldo As Integer = TBSaldo.Text
        If saldo < 50D Then
            nuevaFila.DefaultCellStyle.BackColor = Color.Red
        End If

        PBAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PBAvatar.Image = CType(DGVDatos.Rows(idx).Cells("Foto").EditedFormattedValue, Image)
    End Sub

    Private Sub DTPFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaNacimiento.ValueChanged

    End Sub

    Private Sub DGVDatos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatos.RowEnter
        If e.RowIndex < 0 Then Return
        Dim sexo As String = DGVDatos.Rows(e.RowIndex).Cells("sexo").Value?.ToString()

        RBHombre.Checked = (sexo = "Hombre")
        RBMujer.Checked = (sexo = "Mujer")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged

    End Sub
End Class