<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarMarcaciones
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.marcacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.he = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.has = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hae = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cmbemplehasta = New System.Windows.Forms.ComboBox()
        Me.EMPLEADOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDS = New Planilla.planillaDS()
        Me.cmbempledesde = New System.Windows.Forms.ComboBox()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOTableAdapter = New Planilla.planillaDSTableAdapters.EMPLEADOTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 41)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dg)
        Me.Panel2.Controls.Add(Me.dtpFechaHasta)
        Me.Panel2.Controls.Add(Me.dtpFechaDesde)
        Me.Panel2.Controls.Add(Me.cmbemplehasta)
        Me.Panel2.Controls.Add(Me.cmbempledesde)
        Me.Panel2.Location = New System.Drawing.Point(12, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 278)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Empleado Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Empleado Desde:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marcacion, Me.nombre, Me.fecha, Me.he, Me.has, Me.hae, Me.salida, Me.motivo})
        Me.dg.Location = New System.Drawing.Point(10, 57)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(884, 214)
        Me.dg.TabIndex = 4
        '
        'marcacion
        '
        Me.marcacion.HeaderText = "N°"
        Me.marcacion.Name = "marcacion"
        Me.marcacion.ReadOnly = True
        Me.marcacion.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 75
        '
        'he
        '
        Me.he.HeaderText = "Entrada"
        Me.he.Name = "he"
        Me.he.ReadOnly = True
        Me.he.Width = 75
        '
        'has
        '
        Me.has.HeaderText = "Almuerzo Salida"
        Me.has.Name = "has"
        Me.has.ReadOnly = True
        Me.has.Width = 75
        '
        'hae
        '
        Me.hae.HeaderText = "Almuerzo Entrada"
        Me.hae.Name = "hae"
        Me.hae.ReadOnly = True
        Me.hae.Width = 75
        '
        'salida
        '
        Me.salida.HeaderText = "Salida"
        Me.salida.Name = "salida"
        Me.salida.ReadOnly = True
        Me.salida.Width = 75
        '
        'motivo
        '
        Me.motivo.HeaderText = "Motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.Width = 250
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(403, 31)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaHasta.TabIndex = 3
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(403, 4)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaDesde.TabIndex = 2
        '
        'cmbemplehasta
        '
        Me.cmbemplehasta.DataSource = Me.EMPLEADOBindingSource1
        Me.cmbemplehasta.DisplayMember = "IdNom"
        Me.cmbemplehasta.FormattingEnabled = True
        Me.cmbemplehasta.Location = New System.Drawing.Point(104, 30)
        Me.cmbemplehasta.Name = "cmbemplehasta"
        Me.cmbemplehasta.Size = New System.Drawing.Size(192, 21)
        Me.cmbemplehasta.TabIndex = 1
        Me.cmbemplehasta.ValueMember = "Empleado_ID"
        '
        'EMPLEADOBindingSource1
        '
        Me.EMPLEADOBindingSource1.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource1.DataSource = Me.PlanillaDS
        '
        'PlanillaDS
        '
        Me.PlanillaDS.DataSetName = "planillaDS"
        Me.PlanillaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbempledesde
        '
        Me.cmbempledesde.DataSource = Me.EMPLEADOBindingSource
        Me.cmbempledesde.DisplayMember = "IdNom"
        Me.cmbempledesde.FormattingEnabled = True
        Me.cmbempledesde.Location = New System.Drawing.Point(104, 3)
        Me.cmbempledesde.Name = "cmbempledesde"
        Me.cmbempledesde.Size = New System.Drawing.Size(192, 21)
        Me.cmbempledesde.TabIndex = 0
        Me.cmbempledesde.ValueMember = "Empleado_ID"
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.PlanillaDS
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
        '
        'buscarMarcaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 349)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "buscarMarcaciones"
        Me.Text = "buscarMarcaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbemplehasta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbempledesde As System.Windows.Forms.ComboBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PlanillaDS As Planilla.planillaDS
    Friend WithEvents EMPLEADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLEADOTableAdapter As Planilla.planillaDSTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents EMPLEADOBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents marcacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents has As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hae As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
