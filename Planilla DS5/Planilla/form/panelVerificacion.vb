Imports Planilla.classForm
Public Class panelVerificacion


    Private Sub panelVerificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showForm(panelMarcacion)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showForm(panelReloj)
        Me.Close()
    End Sub
End Class