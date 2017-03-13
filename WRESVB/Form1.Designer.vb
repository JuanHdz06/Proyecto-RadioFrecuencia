<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.optSerial = New System.Windows.Forms.RadioButton()
        Me.optEthernet = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPuertos = New System.Windows.Forms.ComboBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.cmdConectar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.tmrComando = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstComandos = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrabar = New System.Windows.Forms.TextBox()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdLeer = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdAumentar = New System.Windows.Forms.Button()
        Me.cmdDisminuir = New System.Windows.Forms.Button()
        Me.lsvLista = New System.Windows.Forms.ListView()
        Me.chTag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNoRegs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBytes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGHexString = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdFirmware = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(363, 9)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(120, 26)
        Me.cmdEliminar.TabIndex = 45
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdExportar
        '
        Me.cmdExportar.Enabled = False
        Me.cmdExportar.Location = New System.Drawing.Point(138, 9)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(120, 26)
        Me.cmdExportar.TabIndex = 44
        Me.cmdExportar.Text = "Exportar"
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'optSerial
        '
        Me.optSerial.AutoSize = True
        Me.optSerial.Location = New System.Drawing.Point(500, 7)
        Me.optSerial.Name = "optSerial"
        Me.optSerial.Size = New System.Drawing.Size(51, 17)
        Me.optSerial.TabIndex = 43
        Me.optSerial.Text = "Serial"
        Me.optSerial.UseVisualStyleBackColor = True
        '
        'optEthernet
        '
        Me.optEthernet.AutoSize = True
        Me.optEthernet.Checked = True
        Me.optEthernet.Location = New System.Drawing.Point(633, 7)
        Me.optEthernet.Name = "optEthernet"
        Me.optEthernet.Size = New System.Drawing.Size(93, 17)
        Me.optEthernet.TabIndex = 42
        Me.optEthernet.TabStop = True
        Me.optEthernet.Text = "WIFI/Ethernet"
        Me.optEthernet.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Puerto"
        '
        'cboPuertos
        '
        Me.cboPuertos.FormattingEnabled = True
        Me.cboPuertos.Location = New System.Drawing.Point(502, 25)
        Me.cboPuertos.Name = "cboPuertos"
        Me.cboPuertos.Size = New System.Drawing.Size(93, 21)
        Me.cboPuertos.TabIndex = 38
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(675, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(92, 20)
        Me.txtIP.TabIndex = 37
        Me.txtIP.Text = "10.1.1.10"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(732, 9)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(63, 13)
        Me.lblIP.TabIndex = 36
        Me.lblIP.Text = "IP TITANIO"
        '
        'cmdConectar
        '
        Me.cmdConectar.Location = New System.Drawing.Point(12, 9)
        Me.cmdConectar.Name = "cmdConectar"
        Me.cmdConectar.Size = New System.Drawing.Size(120, 26)
        Me.cmdConectar.TabIndex = 34
        Me.cmdConectar.Text = "Conectar"
        Me.cmdConectar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.Location = New System.Drawing.Point(264, 9)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(93, 26)
        Me.cmdLimpiar.TabIndex = 36
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'tmrComando
        '
        Me.tmrComando.Enabled = True
        Me.tmrComando.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'lstComandos
        '
        Me.lstComandos.FormattingEnabled = True
        Me.lstComandos.Location = New System.Drawing.Point(737, 429)
        Me.lstComandos.Name = "lstComandos"
        Me.lstComandos.Size = New System.Drawing.Size(72, 30)
        Me.lstComandos.TabIndex = 44
        Me.lstComandos.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(716, 429)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(658, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Total:"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblTag.Location = New System.Drawing.Point(258, 413)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(24, 33)
        Me.lblTag.TabIndex = 43
        Me.lblTag.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(26, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 33)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Etiqueta: "
        '
        'txtGrabar
        '
        Me.txtGrabar.Enabled = False
        Me.txtGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrabar.Location = New System.Drawing.Point(150, 19)
        Me.txtGrabar.Name = "txtGrabar"
        Me.txtGrabar.Size = New System.Drawing.Size(242, 35)
        Me.txtGrabar.TabIndex = 19
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(14, 19)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(129, 35)
        Me.cmdGrabar.TabIndex = 21
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdLeer
        '
        Me.cmdLeer.Enabled = False
        Me.cmdLeer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLeer.Location = New System.Drawing.Point(14, 60)
        Me.cmdLeer.Name = "cmdLeer"
        Me.cmdLeer.Size = New System.Drawing.Size(129, 35)
        Me.cmdLeer.TabIndex = 22
        Me.cmdLeer.Text = "Leer"
        Me.cmdLeer.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(149, 64)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 24)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "Status"
        '
        'cmdAumentar
        '
        Me.cmdAumentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAumentar.Location = New System.Drawing.Point(452, 22)
        Me.cmdAumentar.Name = "cmdAumentar"
        Me.cmdAumentar.Size = New System.Drawing.Size(48, 29)
        Me.cmdAumentar.TabIndex = 24
        Me.cmdAumentar.Text = ">>"
        Me.cmdAumentar.UseVisualStyleBackColor = True
        Me.cmdAumentar.Visible = False
        '
        'cmdDisminuir
        '
        Me.cmdDisminuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisminuir.Location = New System.Drawing.Point(398, 22)
        Me.cmdDisminuir.Name = "cmdDisminuir"
        Me.cmdDisminuir.Size = New System.Drawing.Size(48, 29)
        Me.cmdDisminuir.TabIndex = 25
        Me.cmdDisminuir.Text = "<<"
        Me.cmdDisminuir.UseVisualStyleBackColor = True
        Me.cmdDisminuir.Visible = False
        '
        'lsvLista
        '
        Me.lsvLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTag, Me.chNoRegs, Me.chBytes, Me.chHora, Me.chGHexString})
        Me.lsvLista.Enabled = False
        Me.lsvLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLista.Location = New System.Drawing.Point(14, 101)
        Me.lsvLista.Name = "lsvLista"
        Me.lsvLista.Size = New System.Drawing.Size(764, 237)
        Me.lsvLista.TabIndex = 26
        Me.lsvLista.UseCompatibleStateImageBehavior = False
        Me.lsvLista.View = System.Windows.Forms.View.Details
        '
        'chTag
        '
        Me.chTag.Text = "Tag"
        Me.chTag.Width = 123
        '
        'chNoRegs
        '
        Me.chNoRegs.Text = "No. Regs"
        Me.chNoRegs.Width = 75
        '
        'chBytes
        '
        Me.chBytes.Text = "Bytes"
        Me.chBytes.Width = 75
        '
        'chHora
        '
        Me.chHora.Text = "Hora"
        Me.chHora.Width = 149
        '
        'chGHexString
        '
        Me.chGHexString.Text = "Hex String"
        Me.chGHexString.Width = 221
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdFirmware)
        Me.GroupBox1.Controls.Add(Me.lsvLista)
        Me.GroupBox1.Controls.Add(Me.cmdDisminuir)
        Me.GroupBox1.Controls.Add(Me.cmdAumentar)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.cmdLeer)
        Me.GroupBox1.Controls.Add(Me.cmdGrabar)
        Me.GroupBox1.Controls.Add(Me.txtGrabar)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 344)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'cmdFirmware
        '
        Me.cmdFirmware.Enabled = False
        Me.cmdFirmware.Location = New System.Drawing.Point(516, 24)
        Me.cmdFirmware.Name = "cmdFirmware"
        Me.cmdFirmware.Size = New System.Drawing.Size(120, 26)
        Me.cmdFirmware.TabIndex = 36
        Me.cmdFirmware.Text = "Firmware"
        Me.cmdFirmware.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 471)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstComandos)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.optEthernet)
        Me.Controls.Add(Me.optSerial)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.cboPuertos)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdConectar)
        Me.Name = "Form1"
        Me.Text = "ReadWrite"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents cmdConectar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents optSerial As System.Windows.Forms.RadioButton
    Friend WithEvents optEthernet As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents tmrComando As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lstComandos As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGrabar As System.Windows.Forms.TextBox
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdLeer As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdAumentar As System.Windows.Forms.Button
    Friend WithEvents cmdDisminuir As System.Windows.Forms.Button
    Friend WithEvents lsvLista As System.Windows.Forms.ListView
    Friend WithEvents chTag As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNoRegs As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBytes As System.Windows.Forms.ColumnHeader
    Friend WithEvents chHora As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGHexString As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdFirmware As System.Windows.Forms.Button

End Class
