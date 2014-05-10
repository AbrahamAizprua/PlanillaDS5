Imports System.Globalization
Imports sqlLinq.sqlcode

Public NotInheritable Class classForm

    Public Shared idUser As String = ""
    Public Shared nameUser As String = ""
    Public Shared lastName_user As String = ""

    Public Shared Sub showForm(ByVal form_origen As Form)
        Try
            With form_origen
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .StartPosition = FormStartPosition.CenterScreen
                .MdiParent = Menu
                .ControlBox = False
                .Show()
            End With
        Catch ex As Exception
            MsgBox("showform: " + ex.Message)
        End Try
    End Sub
    Public Shared Sub onlyNumber(ByVal e As KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar.ToString) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Function formato(ByVal str As String)
        Try
            Dim cadena As String = ""
            If Not String.IsNullOrWhiteSpace(str.ToString) Then
                cadena = Format(CDbl(str), "000000")
            Else
                cadena = "000000"
            End If
            Return cadena
        Catch ex As Exception
            Return "000000"
        End Try
    End Function

    Public Shared Function formatoDec(ByVal cotrol_ As String) As String
        Try
            If IsNumeric(cotrol_) Then
                Dim num As Double = CDbl(cotrol_)
                Return num.ToString("F", CultureInfo.InvariantCulture)
            Else
                Return "0.00"
            End If
        Catch ex As Exception
            MsgBox("formatoDec: " & ex.Message)
            Return "0.00"
        End Try
    End Function
    Public Shared Sub formatoDec(ByRef cotrol_ As TextBox)
        Try
            If IsNumeric(cotrol_.Text) Then
                Dim num As Double = CDbl(cotrol_.Text)
                cotrol_.Text = num.ToString("F", CultureInfo.InvariantCulture)
            Else
                cotrol_.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox("formatoDec: " & ex.Message)
            cotrol_.Text = "0.00"
        End Try
    End Sub
    Public Shared Sub enterTab(ByVal e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                e.Handled = False
                SendKeys.Send("{TAB}")
            End If

        Catch ex As Exception
            MsgBox("enterTab")
        End Try
    End Sub
    Public Shared Function noNull(ByVal control As ComboBox)
        Try
            If control.SelectedValue = Nothing Then
                Return ""
            Else
                Return control.SelectedValue
            End If
        Catch ex As Exception
            MsgBox("noNull: " & ex.Message)
            Return ""
        End Try
    End Function

    Public Shared Sub loadImage(ByRef ptb As PictureBox, ByVal path As String)
        Try
            Dim imagen As System.Drawing.Image
            imagen = Image.FromFile(path)
            Dim bmp As Bitmap = New Bitmap(imagen)
            ptb.Image = bmp
            ptb.BorderStyle = BorderStyle.Fixed3D
            ptb.SizeMode = PictureBoxSizeMode.StretchImage
            imagen.Dispose()
        Catch ex As Exception
            MsgBox("loadImage: " & ex.Message)
        End Try
    End Sub

    Public Shared Function formatDate(ByVal date_ As Date) As String
        Return date_.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
    End Function
    Public Shared Function formatTime(ByVal time_ As Date) As String
        Dim dt As New Date(1900, 1, 1)
        If time_.Date = dt Then
            Return ""
        Else
            Return time_.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)
        End If
    End Function
    'f3844b12
End Class
