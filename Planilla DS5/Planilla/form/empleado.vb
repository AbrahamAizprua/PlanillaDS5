Imports Planilla.classForm

Public Class empleado

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        dtpFecha_Nacimiento.Value = Now.Date
        dtpFecha_Ingreso.Value = Now.Date
        dtpFecha_Salida.Value = Now.Date
        txtSalario_Inicial.Text = "0.00"
        txtSalario_Actual.Text = "0.00"
        cmbEstado.SelectedIndex = -1
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        cmbEstado_Civil.SelectedIndex = -1
        rbf.Checked = False
        rbm.Checked = True
        ptb.Image = My.Resources.empleado
        link_imagen = ""
    End Sub

    Private Sub buscar(ByVal num As ComboBox)
        Try
            Dim taemple As New planillaDSTableAdapters.EMPLEADOTableAdapter
            Dim dtemple As New planillaDS.EMPLEADODataTable
            Dim rowemple As planillaDS.EMPLEADORow
            Dim cod As String = ""
            If num.SelectedValue = Nothing Then
                cod = num.Text.Trim
            Else
                cod = num.SelectedValue.ToString
            End If
            If cod = "" Then
                cod = "-1"
            End If
            taemple.FillEmpleado(dtemple, cod)
            If dtemple.Rows.Count > 0 Then
                rowemple = dtemple.Rows(0)
                txtNombre.Text = rowemple.Nombre
                txtApellido.Text = rowemple.Apellido
                txtCedula.Text = rowemple.Cedula
                dtpFecha_Nacimiento.Value = rowemple.Fecha_Nacimiento
                dtpFecha_Ingreso.Value = rowemple.Fecha_Ingreso
                dtpFecha_Salida.Value = rowemple.Fecha_Salida
                txtSalario_Inicial.Text = formatoDec(rowemple.Salario_Inicial)
                txtSalario_Actual.Text = formatoDec(rowemple.Salario_Actual)

                cmbEstado.SelectedIndex = rowemple.Estado
                cmbEstado_Civil.SelectedIndex = rowemple.Estado_Civil

                txtDireccion.Text = rowemple.Direccion
                txtTelefono.Text = rowemple.Telefono
                txtMovil.Text = rowemple.Movil

                If rowemple.Genero = "f" Then
                    rbf.Checked = True
                Else
                    rbm.Checked = True
                End If

                Dim mss As New IO.MemoryStream(CType(rowemple.Foto, Byte()))
                Dim img As Image = Image.FromStream(mss)
                ptb.Image = img
                link_imagen = ""
            Else
                clear()
            End If

        Catch ex As Exception
            MsgBox("Buscar: " & ex.Message)
        End Try
    End Sub
    Private Sub InsertUpdate()
        Try
            Dim taemple As New planillaDSTableAdapters.EMPLEADOTableAdapter
            Dim dtemple As New planillaDS.EMPLEADODataTable
            Dim rowemple As planillaDS.EMPLEADORow
            Dim code As Integer = 0

            If cmbempleadoid.SelectedValue = Nothing Then
                code = -1
            Else
                code = cmbempleadoid.SelectedValue
            End If

            taemple.FillEmpleado(dtemple, code)
            Dim sexo As String = ""
            If rbf.Checked = True Then
                sexo = "F"
            Else
                sexo = "M"
            End If

            Dim imagen As System.Drawing.Image
            If link_imagen = "" Then
                imagen = My.Resources.empleado
            Else
                imagen = Image.FromFile(link_imagen)
            End If
            Dim bmp As Bitmap = New Bitmap(imagen)
            imagen.Dispose()
            Dim ms As New System.IO.MemoryStream
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

            If dtemple.Rows.Count > 0 Then 'update
                rowemple = dtemple.Rows(0)
                If link_imagen = "" Then
                    taemple.UpdateEmpleado(txtNombre.Text, txtApellido.Text, txtCedula.Text, dtpFecha_Nacimiento.Value, dtpFecha_Ingreso.Value, dtpFecha_Salida.Value, txtSalario_Inicial.Text, txtSalario_Actual.Text, cmbEstado.SelectedIndex, txtDireccion.Text, txtTelefono.Text, txtMovil.Text, cmbEstado_Civil.SelectedIndex, sexo, rowemple.Foto, cmbempleadoid.SelectedValue)
                Else
                    taemple.UpdateEmpleado(txtNombre.Text, txtApellido.Text, txtCedula.Text, dtpFecha_Nacimiento.Value, dtpFecha_Ingreso.Value, dtpFecha_Salida.Value, txtSalario_Inicial.Text, txtSalario_Actual.Text, cmbEstado.SelectedIndex, txtDireccion.Text, txtTelefono.Text, txtMovil.Text, cmbEstado_Civil.SelectedIndex, sexo, ms.GetBuffer, cmbempleadoid.SelectedValue)
                End If
            Else 'insert
                taemple.Insert(txtNombre.Text, txtApellido.Text, txtCedula.Text, dtpFecha_Nacimiento.Value, dtpFecha_Ingreso.Value, dtpFecha_Salida.Value, txtSalario_Inicial.Text, txtSalario_Actual.Text, cmbEstado.SelectedIndex, txtDireccion.Text, txtTelefono.Text, txtMovil.Text, cmbEstado_Civil.SelectedIndex, sexo, ms.GetBuffer)
            End If
            Me.EMPLEADOTableAdapter.Fill(Me.PlanillaDS.EMPLEADO)
            clear()
        Catch ex As Exception
            MsgBox("InsertUpdate: " & ex.Message)
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        InsertUpdate()
    End Sub
    Dim link_imagen As String = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With ofd
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadImage(ptb, .FileName)
                link_imagen = .FileName
            Else
                link_imagen = ""
                ptb.Image = My.Resources.empleado
            End If
        End With
    End Sub

    Private Sub empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDS.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.PlanillaDS.EMPLEADO)
        clear()
    End Sub

    Private Sub cmbempleadoid_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbempleadoid.Validating
        buscar(sender)
    End Sub

    Private Sub txtSalario_Actual_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSalario_Inicial.Validating, txtSalario_Actual.Validating
        formatoDec(sender)
    End Sub

   
    Private Sub txtSalario_Actual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown, txtSalario_Inicial.KeyDown, txtSalario_Actual.KeyDown, txtNombre.KeyDown, txtMovil.KeyDown, txtDireccion.KeyDown, txtCedula.KeyDown, txtApellido.KeyDown, rbm.KeyDown, rbf.KeyDown, dtpFecha_Salida.KeyDown, dtpFecha_Nacimiento.KeyDown, dtpFecha_Ingreso.KeyDown, cmbEstado_Civil.KeyDown, cmbEstado.KeyDown, cmbempleadoid.KeyDown, Button3.KeyDown
        enterTab(e)
    End Sub
End Class