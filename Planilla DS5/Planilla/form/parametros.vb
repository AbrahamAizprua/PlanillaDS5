Imports Planilla.classForm

Public Class parametros

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDS.PARAMETROS' Puede moverla o quitarla según sea necesario.
        Me.PARAMETROSTableAdapter.Fill(Me.PlanillaDS.PARAMETROS)
        clear()
    End Sub

    Private Sub buscar(ByVal cmb As ComboBox)
        Try
            Dim cod As String = ""
            If cmb.SelectedValue = Nothing Then
                cod = cmb.Text.Trim
            Else
                cod = cmb.SelectedValue
            End If
            Dim tapara As New planillaDSTableAdapters.PARAMETROSTableAdapter
            Dim dtpara As New planillaDS.PARAMETROSDataTable
            Dim rowpara As planillaDS.PARAMETROSRow

            tapara.FillParametro(dtpara, cod)
            If dtpara.Rows.Count > 0 Then
                rowpara = dtpara.Rows(0)
                cmbcodigo.SelectedValue = rowpara.Codigo
                txtDescripcion.Text = rowpara.Descripcion
                txtValor.Text = rowpara.Valor
                cmbestado.SelectedIndex = rowpara.estado
            Else
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clear()
        cmbcodigo.SelectedValue = ""
        txtDescripcion.Clear()
        txtValor.Clear()
        cmbestado.SelectedIndex = -1
    End Sub
    Private Sub insert_update()
        Try
            Dim cod As String = ""
            If cmbcodigo.SelectedValue = Nothing Then
                cod = cmbcodigo.Text
            Else
                cod = cmbcodigo.SelectedValue
            End If
            Dim tapara As New planillaDSTableAdapters.PARAMETROSTableAdapter
            Dim dtpara As New planillaDS.PARAMETROSDataTable

            tapara.FillParametro(dtpara, cod)
            If dtpara.Rows.Count > 0 Then ' update
                tapara.UpdateParametro(txtDescripcion.Text, txtValor.Text, cmbestado.SelectedIndex, cod)
            Else 'insert
                tapara.Insert(cod, txtDescripcion.Text, txtValor.Text, cmbestado.SelectedIndex)
            End If
            Me.PARAMETROSTableAdapter.Fill(Me.PlanillaDS.PARAMETROS)
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert_update()
    End Sub

    Private Sub cmbestado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown, txtDescripcion.KeyDown, cmbestado.KeyDown, cmbcodigo.KeyDown
        enterTab(e)
    End Sub

    Private Sub cmbcodigo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbcodigo.Validating
        buscar(sender)
    End Sub
End Class