<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parametros
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.cmbcodigo = New System.Windows.Forms.ComboBox()
        Me.PARAMETROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDS = New Planilla.planillaDS()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PARAMETROSTableAdapter = New Planilla.planillaDSTableAdapters.PARAMETROSTableAdapter()
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PARAMETROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(48, 11)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(25, 38)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(57, 64)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 6
        ValorLabel.Text = "Valor:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(49, 90)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 8
        EstadoLabel.Text = "Estado:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbestado)
        Me.Panel2.Controls.Add(Me.cmbcodigo)
        Me.Panel2.Controls.Add(CodigoLabel)
        Me.Panel2.Controls.Add(DescripcionLabel)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(ValorLabel)
        Me.Panel2.Controls.Add(Me.txtValor)
        Me.Panel2.Controls.Add(EstadoLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 121)
        Me.Panel2.TabIndex = 0
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"0 - Activo", "1 - Inactivo"})
        Me.cmbestado.Location = New System.Drawing.Point(97, 87)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(179, 21)
        Me.cmbestado.TabIndex = 3
        '
        'cmbcodigo
        '
        Me.cmbcodigo.DataSource = Me.PARAMETROSBindingSource
        Me.cmbcodigo.DisplayMember = "CodDesc"
        Me.cmbcodigo.FormattingEnabled = True
        Me.cmbcodigo.Location = New System.Drawing.Point(97, 8)
        Me.cmbcodigo.Name = "cmbcodigo"
        Me.cmbcodigo.Size = New System.Drawing.Size(179, 21)
        Me.cmbcodigo.TabIndex = 0
        Me.cmbcodigo.ValueMember = "Codigo"
        '
        'PARAMETROSBindingSource
        '
        Me.PARAMETROSBindingSource.DataMember = "PARAMETROS"
        Me.PARAMETROSBindingSource.DataSource = Me.PlanillaDS
        '
        'PlanillaDS
        '
        Me.PlanillaDS.DataSetName = "planillaDS"
        Me.PlanillaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(97, 35)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(179, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(97, 61)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(179, 20)
        Me.txtValor.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 41)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PARAMETROSTableAdapter
        '
        Me.PARAMETROSTableAdapter.ClearBeforeFill = True
        '
        'parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 192)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "parametros"
        Me.Text = "Registro de Prametro"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PARAMETROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents cmbcodigo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Friend WithEvents PlanillaDS As Planilla.planillaDS
    Friend WithEvents PARAMETROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARAMETROSTableAdapter As Planilla.planillaDSTableAdapters.PARAMETROSTableAdapter
End Class
