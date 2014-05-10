<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acreedores
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
        Dim Acreedor_IDLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbid = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlanillaDS = New Planilla.planillaDS()
        Me.ACREEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACREEDORESTableAdapter = New Planilla.planillaDSTableAdapters.ACREEDORESTableAdapter()
        Acreedor_IDLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACREEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Acreedor_IDLabel
        '
        Acreedor_IDLabel.AutoSize = True
        Acreedor_IDLabel.Location = New System.Drawing.Point(18, 15)
        Acreedor_IDLabel.Name = "Acreedor_IDLabel"
        Acreedor_IDLabel.Size = New System.Drawing.Size(67, 13)
        Acreedor_IDLabel.TabIndex = 0
        Acreedor_IDLabel.Text = "Acreedor ID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(38, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(30, 67)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(33, 93)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 6
        TelefonoLabel.Text = "Telefono:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbid)
        Me.Panel2.Controls.Add(Acreedor_IDLabel)
        Me.Panel2.Controls.Add(NombreLabel)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(DireccionLabel)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(TelefonoLabel)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Location = New System.Drawing.Point(12, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 126)
        Me.Panel2.TabIndex = 0
        '
        'cmbid
        '
        Me.cmbid.DataSource = Me.ACREEDORESBindingSource
        Me.cmbid.DisplayMember = "IdNom"
        Me.cmbid.FormattingEnabled = True
        Me.cmbid.Location = New System.Drawing.Point(91, 11)
        Me.cmbid.Name = "cmbid"
        Me.cmbid.Size = New System.Drawing.Size(148, 21)
        Me.cmbid.TabIndex = 0
        Me.cmbid.ValueMember = "Acreedor_ID"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(91, 64)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(148, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(91, 90)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 41)
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
        'PlanillaDS
        '
        Me.PlanillaDS.DataSetName = "planillaDS"
        Me.PlanillaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ACREEDORESBindingSource
        '
        Me.ACREEDORESBindingSource.DataMember = "ACREEDORES"
        Me.ACREEDORESBindingSource.DataSource = Me.PlanillaDS
        '
        'ACREEDORESTableAdapter
        '
        Me.ACREEDORESTableAdapter.ClearBeforeFill = True
        '
        'acreedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 201)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "acreedores"
        Me.Text = "Registro de Acreedores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACREEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents cmbid As System.Windows.Forms.ComboBox
    Friend WithEvents PlanillaDS As Planilla.planillaDS
    Friend WithEvents ACREEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACREEDORESTableAdapter As Planilla.planillaDSTableAdapters.ACREEDORESTableAdapter
End Class
