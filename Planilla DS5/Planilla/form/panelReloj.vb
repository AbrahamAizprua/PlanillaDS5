Imports Planilla.classForm
Imports System.Globalization


Public Class panelReloj

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        showForm(panelMarcacion)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblreloj.Text = Date.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
        lblfecha.Text = Date.Now.ToLongDateString.ToUpper
    End Sub

    Private Sub panelReloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = nameUser & " - " & lastName_user
        getMarc()

    End Sub
    Private Sub insert_update(ByVal index As Integer)
        Try
            Dim tamar As New planillaDSTableAdapters.MARCACIONTableAdapter
            Dim dtmar As New planillaDS.MARCACIONDataTable
            Dim rowmar As planillaDS.MARCACIONRow

            Dim datelarch As New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second, Now.Millisecond, DateTimeKind.Unspecified)
            Dim dateshort As New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0, DateTimeKind.Unspecified)
         
            Dim idUsuario As String = idUser

            tamar.FillMarcacion(dtmar, idUsuario, dateshort)
            If dtmar.Rows.Count > 0 Then
                rowmar = dtmar.Rows(0)
                Select Case index
                    Case 1
                        tamar.UpdateMarcacionCond(datelarch, rowmar.Hora2, rowmar.Hora3, rowmar.Hora4, rowmar.Motivo, idUsuario, rowmar.Fecha, rowmar.Marcacion_ID)
                    Case 2
                        tamar.UpdateMarcacionCond(rowmar.Hora1, datelarch, rowmar.Hora3, rowmar.Hora4, rowmar.Motivo, idUsuario, rowmar.Fecha, rowmar.Marcacion_ID)
                    Case 3
                        tamar.UpdateMarcacionCond(rowmar.Hora1, rowmar.Hora2, datelarch, rowmar.Hora4, rowmar.Motivo, idUsuario, rowmar.Fecha, rowmar.Marcacion_ID)
                    Case 4
                        tamar.UpdateMarcacionCond(rowmar.Hora1, rowmar.Hora2, rowmar.Hora3, datelarch, rowmar.Motivo, idUsuario, rowmar.Fecha, rowmar.Marcacion_ID)
                    Case 5
                        tamar.UpdateMarcacionCond(rowmar.Hora1, rowmar.Hora2, rowmar.Hora3, rowmar.Hora4, txtmotivo.Text, idUsuario, rowmar.Fecha, rowmar.Marcacion_ID)
                End Select
            Else
                Select Case index
                    Case 1
                        tamar.InsertMarcacionSimple(idUsuario, dateshort, datelarch, Nothing, Nothing, Nothing, txtmotivo.Text)
                    Case 2
                        tamar.InsertMarcacionSimple(idUsuario, dateshort, Nothing, datelarch, Nothing, Nothing, txtmotivo.Text)
                    Case 3
                        tamar.InsertMarcacionSimple(idUsuario, dateshort, Nothing, Nothing, datelarch, Nothing, txtmotivo.Text)
                    Case 4
                        tamar.InsertMarcacionSimple(idUsuario, dateshort, Nothing, Nothing, Nothing, datelarch, txtmotivo.Text)
                    Case 5
                        tamar.InsertMarcacionSimple(idUsuario, dateshort, Nothing, Nothing, Nothing, Nothing, txtmotivo.Text)
                End Select
            End If
            txtmotivo.Clear()
            getMarc()

        Catch ex As Exception
            MsgBox("insert_update: " + ex.Message)
        End Try

    End Sub
    Private Sub getMarc()
        Try
            Dim tamar As New planillaDSTableAdapters.MARCACIONTableAdapter
            Dim dtmar As New planillaDS.MARCACIONDataTable
            Dim rowmar As planillaDS.MARCACIONRow

            Dim dateshort As New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0, DateTimeKind.Unspecified)
            Dim idUsuario As String = idUser

            tamar.FillMarcacion(dtmar, idUsuario, dateshort)
            If dtmar.Rows.Count > 0 Then
                rowmar = dtmar.Rows(0)

                If rowmar.Hora1.Date = dateshort Then
                    lblhe.Text = rowmar.Hora1.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
                    btnentrada.Enabled = False
                Else
                    lblhe.Text = ""
                    btnentrada.Enabled = True
                End If

                If rowmar.Hora2.Date = dateshort Then
                    lblhas.Text = rowmar.Hora2.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
                    btnsalalmu.Enabled = False
                Else
                    lblhas.Text = ""
                    btnsalalmu.Enabled = True
                End If

                If rowmar.Hora3.Date = dateshort Then
                    lblhae.Text = rowmar.Hora3.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
                    btnentaalmu.Enabled = False
                Else
                    lblhae.Text = ""
                    btnentaalmu.Enabled = True
                End If

                If rowmar.Hora4.Date = dateshort Then
                    lblhs.Text = rowmar.Hora4.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
                    btnsalida.Enabled = False
                Else
                    lblhs.Text = ""
                    btnsalida.Enabled = True
                End If

                txtmotivo.Text = rowmar.Motivo

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub bntentrada_Click(sender As Object, e As EventArgs) Handles btnentrada.Click
        insert_update(1)
    End Sub

    Private Sub btnsalalmu_Click(sender As Object, e As EventArgs) Handles btnsalalmu.Click
        insert_update(2)
    End Sub

    Private Sub btnentaalmu_Click(sender As Object, e As EventArgs) Handles btnentaalmu.Click
        insert_update(3)
    End Sub

    Private Sub btnsalida_Click(sender As Object, e As EventArgs) Handles btnsalida.Click
        insert_update(4)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert_update(5)
    End Sub
End Class