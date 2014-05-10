<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado
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
        Dim Empleado_IDLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim Fecha_NacimientoLabel As System.Windows.Forms.Label
        Dim Fecha_IngresoLabel As System.Windows.Forms.Label
        Dim Fecha_SalidaLabel As System.Windows.Forms.Label
        Dim Salario_InicialLabel As System.Windows.Forms.Label
        Dim Salario_ActualLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim Estado_CivilLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbempleadoid = New System.Windows.Forms.ComboBox()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDS = New Planilla.planillaDS()
        Me.cmbEstado_Civil = New System.Windows.Forms.ComboBox()
        Me.rbf = New System.Windows.Forms.RadioButton()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ptb = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.dtpFecha_Nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Salida = New System.Windows.Forms.DateTimePicker()
        Me.txtSalario_Inicial = New System.Windows.Forms.TextBox()
        Me.txtSalario_Actual = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.EMPLEADOTableAdapter = New Planilla.planillaDSTableAdapters.EMPLEADOTableAdapter()
        Empleado_IDLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        Fecha_NacimientoLabel = New System.Windows.Forms.Label()
        Fecha_IngresoLabel = New System.Windows.Forms.Label()
        Fecha_SalidaLabel = New System.Windows.Forms.Label()
        Salario_InicialLabel = New System.Windows.Forms.Label()
        Salario_ActualLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        MovilLabel = New System.Windows.Forms.Label()
        Estado_CivilLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Empleado_IDLabel
        '
        Empleado_IDLabel.AutoSize = True
        Empleado_IDLabel.Location = New System.Drawing.Point(39, 13)
        Empleado_IDLabel.Name = "Empleado_IDLabel"
        Empleado_IDLabel.Size = New System.Drawing.Size(71, 13)
        Empleado_IDLabel.TabIndex = 0
        Empleado_IDLabel.Text = "Empleado ID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(63, 39)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(63, 65)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(67, 91)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 6
        CedulaLabel.Text = "Cedula:"
        '
        'Fecha_NacimientoLabel
        '
        Fecha_NacimientoLabel.AutoSize = True
        Fecha_NacimientoLabel.Location = New System.Drawing.Point(14, 120)
        Fecha_NacimientoLabel.Name = "Fecha_NacimientoLabel"
        Fecha_NacimientoLabel.Size = New System.Drawing.Size(96, 13)
        Fecha_NacimientoLabel.TabIndex = 8
        Fecha_NacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'Fecha_IngresoLabel
        '
        Fecha_IngresoLabel.AutoSize = True
        Fecha_IngresoLabel.Location = New System.Drawing.Point(306, 198)
        Fecha_IngresoLabel.Name = "Fecha_IngresoLabel"
        Fecha_IngresoLabel.Size = New System.Drawing.Size(78, 13)
        Fecha_IngresoLabel.TabIndex = 10
        Fecha_IngresoLabel.Text = "Fecha Ingreso:"
        '
        'Fecha_SalidaLabel
        '
        Fecha_SalidaLabel.AutoSize = True
        Fecha_SalidaLabel.Location = New System.Drawing.Point(312, 224)
        Fecha_SalidaLabel.Name = "Fecha_SalidaLabel"
        Fecha_SalidaLabel.Size = New System.Drawing.Size(72, 13)
        Fecha_SalidaLabel.TabIndex = 12
        Fecha_SalidaLabel.Text = "Fecha Salida:"
        '
        'Salario_InicialLabel
        '
        Salario_InicialLabel.AutoSize = True
        Salario_InicialLabel.Location = New System.Drawing.Point(312, 247)
        Salario_InicialLabel.Name = "Salario_InicialLabel"
        Salario_InicialLabel.Size = New System.Drawing.Size(72, 13)
        Salario_InicialLabel.TabIndex = 14
        Salario_InicialLabel.Text = "Salario Inicial:"
        '
        'Salario_ActualLabel
        '
        Salario_ActualLabel.AutoSize = True
        Salario_ActualLabel.Location = New System.Drawing.Point(309, 273)
        Salario_ActualLabel.Name = "Salario_ActualLabel"
        Salario_ActualLabel.Size = New System.Drawing.Size(75, 13)
        Salario_ActualLabel.TabIndex = 16
        Salario_ActualLabel.Text = "Salario Actual:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(67, 273)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 18
        EstadoLabel.Text = "Estado:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(55, 143)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 20
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(58, 169)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 22
        TelefonoLabel.Text = "Telefono:"
        '
        'MovilLabel
        '
        MovilLabel.AutoSize = True
        MovilLabel.Location = New System.Drawing.Point(75, 195)
        MovilLabel.Name = "MovilLabel"
        MovilLabel.Size = New System.Drawing.Size(35, 13)
        MovilLabel.TabIndex = 24
        MovilLabel.Text = "Movil:"
        '
        'Estado_CivilLabel
        '
        Estado_CivilLabel.AutoSize = True
        Estado_CivilLabel.Location = New System.Drawing.Point(45, 221)
        Estado_CivilLabel.Name = "Estado_CivilLabel"
        Estado_CivilLabel.Size = New System.Drawing.Size(65, 13)
        Estado_CivilLabel.TabIndex = 26
        Estado_CivilLabel.Text = "Estado Civil:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(65, 247)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 28
        GeneroLabel.Text = "Genero:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 41)
        Me.Panel1.TabIndex = 1
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(77, 3)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 31)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(3, 3)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 31)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbempleadoid)
        Me.Panel2.Controls.Add(Me.cmbEstado_Civil)
        Me.Panel2.Controls.Add(Me.rbf)
        Me.Panel2.Controls.Add(Me.rbm)
        Me.Panel2.Controls.Add(Me.cmbEstado)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.ptb)
        Me.Panel2.Controls.Add(Empleado_IDLabel)
        Me.Panel2.Controls.Add(NombreLabel)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(ApellidoLabel)
        Me.Panel2.Controls.Add(Me.txtApellido)
        Me.Panel2.Controls.Add(CedulaLabel)
        Me.Panel2.Controls.Add(Me.txtCedula)
        Me.Panel2.Controls.Add(Fecha_NacimientoLabel)
        Me.Panel2.Controls.Add(Me.dtpFecha_Nacimiento)
        Me.Panel2.Controls.Add(Fecha_IngresoLabel)
        Me.Panel2.Controls.Add(Me.dtpFecha_Ingreso)
        Me.Panel2.Controls.Add(Fecha_SalidaLabel)
        Me.Panel2.Controls.Add(Me.dtpFecha_Salida)
        Me.Panel2.Controls.Add(Salario_InicialLabel)
        Me.Panel2.Controls.Add(Me.txtSalario_Inicial)
        Me.Panel2.Controls.Add(Salario_ActualLabel)
        Me.Panel2.Controls.Add(Me.txtSalario_Actual)
        Me.Panel2.Controls.Add(EstadoLabel)
        Me.Panel2.Controls.Add(DireccionLabel)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(TelefonoLabel)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(MovilLabel)
        Me.Panel2.Controls.Add(Me.txtMovil)
        Me.Panel2.Controls.Add(Estado_CivilLabel)
        Me.Panel2.Controls.Add(GeneroLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 304)
        Me.Panel2.TabIndex = 0
        '
        'cmbempleadoid
        '
        Me.cmbempleadoid.DataSource = Me.EMPLEADOBindingSource
        Me.cmbempleadoid.DisplayMember = "IdNom"
        Me.cmbempleadoid.FormattingEnabled = True
        Me.cmbempleadoid.Location = New System.Drawing.Point(116, 9)
        Me.cmbempleadoid.Name = "cmbempleadoid"
        Me.cmbempleadoid.Size = New System.Drawing.Size(178, 21)
        Me.cmbempleadoid.TabIndex = 0
        Me.cmbempleadoid.ValueMember = "Empleado_ID"
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.PlanillaDS
        '
        'PlanillaDS
        '
        Me.PlanillaDS.DataSetName = "planillaDS"
        Me.PlanillaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbEstado_Civil
        '
        Me.cmbEstado_Civil.FormattingEnabled = True
        Me.cmbEstado_Civil.Items.AddRange(New Object() {"01 - Soltero", "02 - Casado", "03 - Viudo", "04 - Divorsido"})
        Me.cmbEstado_Civil.Location = New System.Drawing.Point(116, 218)
        Me.cmbEstado_Civil.Name = "cmbEstado_Civil"
        Me.cmbEstado_Civil.Size = New System.Drawing.Size(178, 21)
        Me.cmbEstado_Civil.TabIndex = 8
        '
        'rbf
        '
        Me.rbf.AutoSize = True
        Me.rbf.Location = New System.Drawing.Point(223, 244)
        Me.rbf.Name = "rbf"
        Me.rbf.Size = New System.Drawing.Size(71, 17)
        Me.rbf.TabIndex = 10
        Me.rbf.TabStop = True
        Me.rbf.Text = "Femenino"
        Me.rbf.UseVisualStyleBackColor = True
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Location = New System.Drawing.Point(116, 244)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(68, 17)
        Me.rbm.TabIndex = 9
        Me.rbm.TabStop = True
        Me.rbm.Text = "Maculino"
        Me.rbm.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"01 - Activo", "02 - Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(116, 270)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(178, 21)
        Me.cmbEstado.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(390, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Examinar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ptb
        '
        Me.ptb.Image = Global.Planilla.My.Resources.Resources.empleado
        Me.ptb.Location = New System.Drawing.Point(390, 10)
        Me.ptb.Name = "ptb"
        Me.ptb.Size = New System.Drawing.Size(178, 146)
        Me.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb.TabIndex = 30
        Me.ptb.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(116, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(178, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(116, 62)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(178, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(116, 88)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(178, 20)
        Me.txtCedula.TabIndex = 3
        '
        'dtpFecha_Nacimiento
        '
        Me.dtpFecha_Nacimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_Nacimiento.Location = New System.Drawing.Point(116, 114)
        Me.dtpFecha_Nacimiento.Name = "dtpFecha_Nacimiento"
        Me.dtpFecha_Nacimiento.Size = New System.Drawing.Size(178, 20)
        Me.dtpFecha_Nacimiento.TabIndex = 4
        '
        'dtpFecha_Ingreso
        '
        Me.dtpFecha_Ingreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_Ingreso.Location = New System.Drawing.Point(390, 192)
        Me.dtpFecha_Ingreso.Name = "dtpFecha_Ingreso"
        Me.dtpFecha_Ingreso.Size = New System.Drawing.Size(178, 20)
        Me.dtpFecha_Ingreso.TabIndex = 13
        '
        'dtpFecha_Salida
        '
        Me.dtpFecha_Salida.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha_Salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_Salida.Location = New System.Drawing.Point(390, 218)
        Me.dtpFecha_Salida.Name = "dtpFecha_Salida"
        Me.dtpFecha_Salida.Size = New System.Drawing.Size(178, 20)
        Me.dtpFecha_Salida.TabIndex = 14
        '
        'txtSalario_Inicial
        '
        Me.txtSalario_Inicial.Location = New System.Drawing.Point(390, 244)
        Me.txtSalario_Inicial.Name = "txtSalario_Inicial"
        Me.txtSalario_Inicial.Size = New System.Drawing.Size(178, 20)
        Me.txtSalario_Inicial.TabIndex = 15
        Me.txtSalario_Inicial.Text = "0.00"
        Me.txtSalario_Inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalario_Actual
        '
        Me.txtSalario_Actual.Location = New System.Drawing.Point(390, 270)
        Me.txtSalario_Actual.Name = "txtSalario_Actual"
        Me.txtSalario_Actual.Size = New System.Drawing.Size(178, 20)
        Me.txtSalario_Actual.TabIndex = 16
        Me.txtSalario_Actual.Text = "0.00"
        Me.txtSalario_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(116, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(178, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(116, 166)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(178, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'txtMovil
        '
        Me.txtMovil.Location = New System.Drawing.Point(116, 192)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(178, 20)
        Me.txtMovil.TabIndex = 7
        '
        'ofd
        '
        Me.ofd.Filter = "Ficheros BMP|*.bmp"" & ""|Ficheros GIF|*.gif"" & |Ficheros JPG o JPEG|*.jpg;*.jpeg |" & _
    "Ficheros PNG|*.png|Ficheros TIFF|*.tif"
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
        '
        'empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 381)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "empleado"
        Me.Text = "Regitro de Empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_Nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha_Salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSalario_Inicial As System.Windows.Forms.TextBox
    Friend WithEvents txtSalario_Actual As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMovil As System.Windows.Forms.TextBox
    Friend WithEvents ptb As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rbf As System.Windows.Forms.RadioButton
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado_Civil As System.Windows.Forms.ComboBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbempleadoid As System.Windows.Forms.ComboBox
    Friend WithEvents PlanillaDS As Planilla.planillaDS
    Friend WithEvents EMPLEADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLEADOTableAdapter As Planilla.planillaDSTableAdapters.EMPLEADOTableAdapter
End Class
