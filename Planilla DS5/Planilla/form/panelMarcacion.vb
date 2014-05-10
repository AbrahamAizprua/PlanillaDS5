Imports Planilla.classForm

Public Class panelMarcacion

 

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtentrada.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtentrada.Validating
        '  txtentrada.Text = formato(txtentrada.Text.Trim)

    End Sub

    Private Sub buscar(ByVal num As TextBox)
        Try
            Dim taemple As New planillaDSTableAdapters.EMPLEADOTableAdapter
            Dim dtemple As New planillaDS.EMPLEADODataTable
            Dim rowemple As planillaDS.EMPLEADORow
            Dim cod As String = ""
            If num.Text.Trim = "" Then
                cod = "-1"
            Else
                cod = num.Text.Trim
            End If
            taemple.FillEmpleado(dtemple, cod)
            If dtemple.Rows.Count > 0 Then
                rowemple = dtemple.Rows(0)
                panelVerificacion.lblnombre.Text = rowemple.Nombre
                panelVerificacion.lblapellido.Text = rowemple.Apellido
                Dim mss As New IO.MemoryStream(CType(rowemple.Foto, Byte()))
                Dim img As Image = Image.FromStream(mss)
                panelVerificacion.pb.Image = img

                idUser = rowemple.Empleado_ID
                lastName_user = rowemple.Apellido
                nameUser = rowemple.Nombre
                showForm(panelVerificacion)

                Me.Close()

            Else
                txtentrada.Clear()
            End If

        Catch ex As Exception
            MsgBox("Buscar: " & ex.Message)
        End Try
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        buscar(txtentrada)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        txtentrada.Text = txtentrada.Text & sender.text.ToString
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtentrada.Clear()
    End Sub

    Private Sub txtentrada_KeyDown(sender As Object, e As KeyEventArgs) Handles txtentrada.KeyDown, Button9.KeyDown, Button8.KeyDown, Button7.KeyDown, Button6.KeyDown, Button5.KeyDown, Button4.KeyDown, Button3.KeyDown, Button2.KeyDown, Button13.KeyDown, Button12.KeyDown, Button11.KeyDown, Button10.KeyDown, Button1.KeyDown

        If e.KeyCode = Keys.Enter Then
            buscar(txtentrada)
        End If

    End Sub
End Class