<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelReloj
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
        Me.components = New System.ComponentModel.Container()
        Me.lblreloj = New System.Windows.Forms.Label()
        Me.btnentrada = New System.Windows.Forms.Button()
        Me.btnsalalmu = New System.Windows.Forms.Button()
        Me.btnentaalmu = New System.Windows.Forms.Button()
        Me.btnsalida = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblhe = New System.Windows.Forms.Label()
        Me.lblhas = New System.Windows.Forms.Label()
        Me.lblhae = New System.Windows.Forms.Label()
        Me.lblhs = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblreloj
        '
        Me.lblreloj.Font = New System.Drawing.Font("Anonymous Pro", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblreloj.Location = New System.Drawing.Point(11, 9)
        Me.lblreloj.Name = "lblreloj"
        Me.lblreloj.Size = New System.Drawing.Size(620, 43)
        Me.lblreloj.TabIndex = 0
        Me.lblreloj.Text = "01:58:00"
        Me.lblreloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnentrada
        '
        Me.btnentrada.BackColor = System.Drawing.Color.Gray
        Me.btnentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentrada.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnentrada.Location = New System.Drawing.Point(11, 71)
        Me.btnentrada.Name = "btnentrada"
        Me.btnentrada.Size = New System.Drawing.Size(150, 48)
        Me.btnentrada.TabIndex = 1
        Me.btnentrada.Text = "Entrada"
        Me.btnentrada.UseVisualStyleBackColor = False
        '
        'btnsalalmu
        '
        Me.btnsalalmu.BackColor = System.Drawing.Color.Gray
        Me.btnsalalmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalalmu.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalalmu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsalalmu.Location = New System.Drawing.Point(169, 71)
        Me.btnsalalmu.Name = "btnsalalmu"
        Me.btnsalalmu.Size = New System.Drawing.Size(150, 48)
        Me.btnsalalmu.TabIndex = 2
        Me.btnsalalmu.Text = "Salida Almuerzo"
        Me.btnsalalmu.UseVisualStyleBackColor = False
        '
        'btnentaalmu
        '
        Me.btnentaalmu.BackColor = System.Drawing.Color.Gray
        Me.btnentaalmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentaalmu.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentaalmu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnentaalmu.Location = New System.Drawing.Point(325, 71)
        Me.btnentaalmu.Name = "btnentaalmu"
        Me.btnentaalmu.Size = New System.Drawing.Size(150, 48)
        Me.btnentaalmu.TabIndex = 3
        Me.btnentaalmu.Text = "Entrada Almuerzo"
        Me.btnentaalmu.UseVisualStyleBackColor = False
        '
        'btnsalida
        '
        Me.btnsalida.BackColor = System.Drawing.Color.Gray
        Me.btnsalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalida.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsalida.Location = New System.Drawing.Point(481, 71)
        Me.btnsalida.Name = "btnsalida"
        Me.btnsalida.Size = New System.Drawing.Size(150, 48)
        Me.btnsalida.TabIndex = 4
        Me.btnsalida.Text = "Salida"
        Me.btnsalida.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(509, 337)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 25)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Anonymous Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfecha
        '
        Me.lblfecha.Font = New System.Drawing.Font("Anonymous Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblfecha.Location = New System.Drawing.Point(242, 133)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(367, 23)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "01/01/0000"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Anonymous Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hora Entrada:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Anonymous Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Almuerzo Salida:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Anonymous Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Almuerzo Entrada:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Anonymous Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Hora Salida:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhe
        '
        Me.lblhe.Font = New System.Drawing.Font("Anonymous Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhe.Location = New System.Drawing.Point(242, 162)
        Me.lblhe.Name = "lblhe"
        Me.lblhe.Size = New System.Drawing.Size(133, 23)
        Me.lblhe.TabIndex = 16
        Me.lblhe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblhas
        '
        Me.lblhas.Font = New System.Drawing.Font("Anonymous Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhas.Location = New System.Drawing.Point(242, 194)
        Me.lblhas.Name = "lblhas"
        Me.lblhas.Size = New System.Drawing.Size(133, 23)
        Me.lblhas.TabIndex = 17
        Me.lblhas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblhae
        '
        Me.lblhae.Font = New System.Drawing.Font("Anonymous Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhae.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhae.Location = New System.Drawing.Point(242, 226)
        Me.lblhae.Name = "lblhae"
        Me.lblhae.Size = New System.Drawing.Size(133, 23)
        Me.lblhae.TabIndex = 18
        Me.lblhae.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblhs
        '
        Me.lblhs.Font = New System.Drawing.Font("Anonymous Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblhs.Location = New System.Drawing.Point(242, 258)
        Me.lblhs.Name = "lblhs"
        Me.lblhs.Size = New System.Drawing.Size(133, 23)
        Me.lblhs.TabIndex = 19
        Me.lblhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmotivo
        '
        Me.txtmotivo.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmotivo.Location = New System.Drawing.Point(11, 284)
        Me.txtmotivo.MaxLength = 150
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(492, 78)
        Me.txtmotivo.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Anonymous Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(509, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 47)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Guardar Motivo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelReloj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(642, 374)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.lblhs)
        Me.Controls.Add(Me.lblhae)
        Me.Controls.Add(Me.lblhas)
        Me.Controls.Add(Me.lblhe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnsalida)
        Me.Controls.Add(Me.btnentaalmu)
        Me.Controls.Add(Me.btnsalalmu)
        Me.Controls.Add(Me.btnentrada)
        Me.Controls.Add(Me.lblreloj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "panelReloj"
        Me.Text = "panelReloj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblreloj As System.Windows.Forms.Label
    Friend WithEvents btnentrada As System.Windows.Forms.Button
    Friend WithEvents btnsalalmu As System.Windows.Forms.Button
    Friend WithEvents btnentaalmu As System.Windows.Forms.Button
    Friend WithEvents btnsalida As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblhe As System.Windows.Forms.Label
    Friend WithEvents lblhas As System.Windows.Forms.Label
    Friend WithEvents lblhae As System.Windows.Forms.Label
    Friend WithEvents lblhs As System.Windows.Forms.Label
    Friend WithEvents txtmotivo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
