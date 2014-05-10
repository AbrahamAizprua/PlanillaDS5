Imports System.Globalization
Imports Planilla.classForm

Public Class buscarMarcaciones

    Private Sub buscarMarcaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDS.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.PlanillaDS.EMPLEADO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim coddesde As Integer = 0
            Dim codhasta As Integer = 0
            Dim fechaDesde As DateTime
            Dim fechaHasta As DateTime
            If cmbempledesde.SelectedValue = Nothing Then
                coddesde = 0
            Else
                coddesde = cmbempledesde.SelectedValue
            End If
            If cmbemplehasta.SelectedValue = Nothing Then
                codhasta = 0
            Else
                codhasta = cmbemplehasta.SelectedValue
            End If
            fechaDesde = New Date(dtpFechaDesde.Value.Year, dtpFechaDesde.Value.Month, dtpFechaDesde.Value.Day)
            fechaHasta = New Date(dtpFechaHasta.Value.Year, dtpFechaHasta.Value.Month, dtpFechaHasta.Value.Day)

            Dim tamar As New planillaDSTableAdapters.MARCACIONTableAdapter
            Dim dtmar As New planillaDS.MARCACIONDataTable
            Dim rowmar As planillaDS.MARCACIONRow

            dg.Rows.Clear()
            tamar.FillBusMarcacion(dtmar, coddesde, codhasta, fechaDesde, fechaHasta)
            If dtmar.Rows.Count > 0 Then
                For x As Integer = 0 To dtmar.Rows.Count - 1
                    dg.Rows.Add(dtmar.Rows(x).Item(0), dtmar.Rows(x).Item(8) & " - " & dtmar.Rows(x).Item(9), formatDate(dtmar.Rows(x).Item(2)), formatTime(dtmar.Rows(x).Item(3)), formatTime(dtmar.Rows(x).Item(4)), formatTime(dtmar.Rows(x).Item(5)), formatTime(dtmar.Rows(x).Item(6)), dtmar.Rows(x).Item(7), dtmar.Rows(x).Item(8))
                    'rowmar = dtmar.Rows(x)
                    'dg.Rows.Add(rowmar.Marcacion_ID, dtmar.Rows(x).Item(8) & " - " & dtmar.Rows(x).Item(9), rowmar.Fecha, rowmar.Hora1, rowmar.Hora2, rowmar.Hora3, rowmar.Hora4, rowmar.Motivo)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    Private Sub cmbempledesde_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaHasta.KeyDown, dtpFechaDesde.KeyDown, cmbemplehasta.KeyDown, cmbempledesde.KeyDown
        enterTab(e)

    End Sub
End Class