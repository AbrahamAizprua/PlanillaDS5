Imports Planilla.classForm
Public Class acreedores

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub insert_update()
        Dim code As Integer = -1
        If cmbid.SelectedValue = Nothing Then
            code = -1
        Else
            code = cmbid.SelectedValue
        End If
        Dim taacre As New planillaDSTableAdapters.ACREEDORESTableAdapter
        Dim dtacre As New planillaDS.ACREEDORESDataTable
        taacre.FillAcreedor(dtacre, code)
        If dtacre.Rows.Count > 0 Then 'update
            taacre.UpdateAcreedor(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, code)
        Else 'insert
            taacre.Insert(txtNombre.Text, txtDireccion.Text, txtTelefono.Text)
        End If
        Me.ACREEDORESTableAdapter.Fill(Me.PlanillaDS.ACREEDORES)
        clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert_update()
    End Sub

    Private Sub acreedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDS.ACREEDORES' Puede moverla o quitarla según sea necesario.
        Me.ACREEDORESTableAdapter.Fill(Me.PlanillaDS.ACREEDORES)
        clear()
    End Sub
    Private Sub buscar()
        Dim code As Integer = -1
        If cmbid.SelectedValue = Nothing Then
            code = -1
        Else
            code = cmbid.SelectedValue
        End If
        Dim taacre As New planillaDSTableAdapters.ACREEDORESTableAdapter
        Dim dtacre As New planillaDS.ACREEDORESDataTable
        Dim rowacre As planillaDS.ACREEDORESRow
        taacre.FillAcreedor(dtacre, code)
        If dtacre.Rows.Count > 0 Then 'update
            rowacre = dtacre.Rows(0)
            cmbid.SelectedValue = rowacre.Acreedor_ID
            txtDireccion.Text = rowacre.Direccion
            txtNombre.Text = rowacre.Nombre
            txtTelefono.Text = rowacre.Telefono
        Else 'insert
            clear()
        End If
    End Sub
    Private Sub clear()
        cmbid.SelectedIndex = -1
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
    End Sub
    Private Sub cmbid_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbid.Validating
        buscar()
    End Sub

    Private Sub cmbid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown, txtNombre.KeyDown, txtDireccion.KeyDown, cmbid.KeyDown
        enterTab(e)
    End Sub
End Class