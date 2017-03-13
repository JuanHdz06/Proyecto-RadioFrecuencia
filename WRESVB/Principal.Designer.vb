<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Lector = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.cmdConectar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.lstComandos = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvLista = New System.Windows.Forms.ListView()
        Me.chTag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBytes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGHexString = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdDisminuir = New System.Windows.Forms.Button()
        Me.cmdAumentar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IDtext = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Sfecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.f3 = New System.Windows.Forms.TextBox()
        Me.f2 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.f1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.optEthernet = New System.Windows.Forms.RadioButton()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.cboPuertos = New System.Windows.Forms.ComboBox()
        Me.cmdFirmware = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.optSerial = New System.Windows.Forms.RadioButton()
        Me.txtGrabar = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdLeer = New System.Windows.Forms.Button()
        Me.cmdConectar2 = New System.Windows.Forms.Button()
        Me.tmrComando2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportesAct = New System.Windows.Forms.Button()
        Me.EditarTag = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Lector.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage7.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lector
        '
        Me.Lector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lector.Controls.Add(Me.MetroTabPage1)
        Me.Lector.Controls.Add(Me.MetroTabPage4)
        Me.Lector.Controls.Add(Me.MetroTabPage6)
        Me.Lector.Controls.Add(Me.MetroTabPage5)
        Me.Lector.Controls.Add(Me.MetroTabPage2)
        Me.Lector.Controls.Add(Me.MetroTabPage7)
        Me.Lector.Controls.Add(Me.MetroTabPage3)
        Me.Lector.Location = New System.Drawing.Point(6, 91)
        Me.Lector.Name = "Lector"
        Me.Lector.SelectedIndex = 4
        Me.Lector.Size = New System.Drawing.Size(782, 448)
        Me.Lector.TabIndex = 0
        Me.Lector.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.Button14)
        Me.MetroTabPage1.Controls.Add(Me.cmdConectar)
        Me.MetroTabPage1.Controls.Add(Me.DataGridView1)
        Me.MetroTabPage1.Controls.Add(Me.Label37)
        Me.MetroTabPage1.Controls.Add(Me.TextBox21)
        Me.MetroTabPage1.Controls.Add(Me.Button13)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "                  "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(4, 0)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(69, 26)
        Me.Button14.TabIndex = 63
        Me.Button14.Text = "Actualizar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'cmdConectar
        '
        Me.cmdConectar.Location = New System.Drawing.Point(-22, -29)
        Me.cmdConectar.Name = "cmdConectar"
        Me.cmdConectar.Size = New System.Drawing.Size(120, 26)
        Me.cmdConectar.TabIndex = 48
        Me.cmdConectar.Text = "Conectar"
        Me.cmdConectar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(756, 340)
        Me.DataGridView1.TabIndex = 49
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.Window
        Me.Label37.Location = New System.Drawing.Point(86, 38)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(76, 13)
        Me.Label37.TabIndex = 61
        Me.Label37.Text = "ID Documento"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(172, 35)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(162, 20)
        Me.TextBox21.TabIndex = 50
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(4, 31)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(69, 26)
        Me.Button13.TabIndex = 62
        Me.Button13.Text = "Buscar"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.lstComandos)
        Me.MetroTabPage4.Controls.Add(Me.GroupBox1)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "                  "
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'lstComandos
        '
        Me.lstComandos.FormattingEnabled = True
        Me.lstComandos.Location = New System.Drawing.Point(685, 422)
        Me.lstComandos.Name = "lstComandos"
        Me.lstComandos.Size = New System.Drawing.Size(72, 30)
        Me.lstComandos.TabIndex = 60
        Me.lstComandos.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.lsvLista)
        Me.GroupBox1.Controls.Add(Me.cmdDisminuir)
        Me.GroupBox1.Controls.Add(Me.cmdAumentar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdExportar)
        Me.GroupBox1.Controls.Add(Me.cmdLimpiar)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 390)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activos leidos"
        '
        'lsvLista
        '
        Me.lsvLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTag, Me.chBytes, Me.chHora, Me.chGHexString})
        Me.lsvLista.Enabled = False
        Me.lsvLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLista.Location = New System.Drawing.Point(14, 79)
        Me.lsvLista.Name = "lsvLista"
        Me.lsvLista.Size = New System.Drawing.Size(728, 305)
        Me.lsvLista.TabIndex = 26
        Me.lsvLista.UseCompatibleStateImageBehavior = False
        Me.lsvLista.View = System.Windows.Forms.View.Details
        '
        'chTag
        '
        Me.chTag.Text = "Etiqueta"
        Me.chTag.Width = 123
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
        'cmdDisminuir
        '
        Me.cmdDisminuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisminuir.Location = New System.Drawing.Point(619, 22)
        Me.cmdDisminuir.Name = "cmdDisminuir"
        Me.cmdDisminuir.Size = New System.Drawing.Size(48, 29)
        Me.cmdDisminuir.TabIndex = 25
        Me.cmdDisminuir.Text = "<<"
        Me.cmdDisminuir.UseVisualStyleBackColor = True
        Me.cmdDisminuir.Visible = False
        '
        'cmdAumentar
        '
        Me.cmdAumentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAumentar.Location = New System.Drawing.Point(673, 22)
        Me.cmdAumentar.Name = "cmdAumentar"
        Me.cmdAumentar.Size = New System.Drawing.Size(48, 29)
        Me.cmdAumentar.TabIndex = 24
        Me.cmdAumentar.Text = ">>"
        Me.cmdAumentar.UseVisualStyleBackColor = True
        Me.cmdAumentar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(450, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Total de activos:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmdExportar
        '
        Me.cmdExportar.AutoSize = True
        Me.cmdExportar.BackColor = System.Drawing.SystemColors.Window
        Me.cmdExportar.Enabled = False
        Me.cmdExportar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportar.Location = New System.Drawing.Point(167, 22)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(129, 35)
        Me.cmdExportar.TabIndex = 48
        Me.cmdExportar.Text = "Exportar"
        Me.cmdExportar.UseVisualStyleBackColor = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(14, 22)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(129, 35)
        Me.cmdLimpiar.TabIndex = 47
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(502, 38)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(17, 19)
        Me.lblTotal.TabIndex = 65
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label5)
        Me.MetroTabPage2.Controls.Add(Me.Label18)
        Me.MetroTabPage2.Controls.Add(Me.Button9)
        Me.MetroTabPage2.Controls.Add(Me.Label17)
        Me.MetroTabPage2.Controls.Add(Me.Label15)
        Me.MetroTabPage2.Controls.Add(Me.TextBox10)
        Me.MetroTabPage2.Controls.Add(Me.Button1)
        Me.MetroTabPage2.Controls.Add(Me.Label16)
        Me.MetroTabPage2.Controls.Add(Me.Button3)
        Me.MetroTabPage2.Controls.Add(Me.grilla)
        Me.MetroTabPage2.Controls.Add(Me.Button4)
        Me.MetroTabPage2.Controls.Add(Me.IDtext)
        Me.MetroTabPage2.Controls.Add(Me.Label13)
        Me.MetroTabPage2.Controls.Add(Me.Label14)
        Me.MetroTabPage2.Controls.Add(Me.Label8)
        Me.MetroTabPage2.Controls.Add(Me.TextBox2)
        Me.MetroTabPage2.Controls.Add(Me.TextBox4)
        Me.MetroTabPage2.Controls.Add(Me.TextBox9)
        Me.MetroTabPage2.Controls.Add(Me.TextBox8)
        Me.MetroTabPage2.Controls.Add(Me.TextBox7)
        Me.MetroTabPage2.Controls.Add(Me.Label6)
        Me.MetroTabPage2.Controls.Add(Me.Label12)
        Me.MetroTabPage2.Controls.Add(Me.Label11)
        Me.MetroTabPage2.Controls.Add(Me.Label10)
        Me.MetroTabPage2.Controls.Add(Me.TextBox3)
        Me.MetroTabPage2.Controls.Add(Me.Label9)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.TextBox6)
        Me.MetroTabPage2.Controls.Add(Me.lblTag)
        Me.MetroTabPage2.Controls.Add(Me.TextBox5)
        Me.MetroTabPage2.Controls.Add(Me.TextBox1)
        Me.MetroTabPage2.Controls.Add(Me.Label7)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "                  "
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(8, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Codido de barras"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label18.Location = New System.Drawing.Point(235, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 24)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "Borrar"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(232, 8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 65)
        Me.Button9.TabIndex = 87
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label17.Location = New System.Drawing.Point(146, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 24)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(386, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 24)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Status"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(114, 150)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(236, 20)
        Me.TextBox10.TabIndex = 89
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(47, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 65)
        Me.Button1.TabIndex = 61
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label16.Location = New System.Drawing.Point(43, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 24)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Guardar"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(140, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 65)
        Me.Button3.TabIndex = 82
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(540, 310)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(192, 72)
        Me.grilla.TabIndex = 81
        Me.grilla.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(433, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 35)
        Me.Button4.TabIndex = 84
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'IDtext
        '
        Me.IDtext.Location = New System.Drawing.Point(114, 113)
        Me.IDtext.Name = "IDtext"
        Me.IDtext.Size = New System.Drawing.Size(236, 20)
        Me.IDtext.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(7, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Codigo alterno"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(387, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "ID Tipo Documento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(7, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Asunto"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 225)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 87)
        Me.TextBox2.TabIndex = 71
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(114, 332)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(236, 20)
        Me.TextBox4.TabIndex = 73
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(493, 250)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(222, 20)
        Me.TextBox9.TabIndex = 78
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(493, 218)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(222, 20)
        Me.TextBox8.TabIndex = 77
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(493, 184)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(222, 20)
        Me.TextBox7.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(7, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Hojas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(387, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Expediente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(387, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Linea"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(387, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Nivel"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 362)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(236, 20)
        Me.TextBox3.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(387, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Divicion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(386, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Etiqueta: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ID Documento"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(493, 150)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(222, 20)
        Me.TextBox6.TabIndex = 75
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.SystemColors.Window
        Me.lblTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTag.Location = New System.Drawing.Point(504, 15)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(24, 33)
        Me.lblTag.TabIndex = 59
        Me.lblTag.Text = "."
        Me.lblTag.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(493, 113)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(222, 20)
        Me.TextBox5.TabIndex = 74
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 20)
        Me.TextBox1.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(7, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Estante"
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage6.TabIndex = 5
        Me.MetroTabPage6.Text = "                  "
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage5.TabIndex = 4
        Me.MetroTabPage5.Text = "                  "
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'MetroTabPage7
        '
        Me.MetroTabPage7.Controls.Add(Me.TextBox11)
        Me.MetroTabPage7.Controls.Add(Me.TextBox12)
        Me.MetroTabPage7.Controls.Add(Me.Sfecha)
        Me.MetroTabPage7.Controls.Add(Me.TextBox14)
        Me.MetroTabPage7.Controls.Add(Me.TextBox15)
        Me.MetroTabPage7.Controls.Add(Me.Label30)
        Me.MetroTabPage7.Controls.Add(Me.TextBox16)
        Me.MetroTabPage7.Controls.Add(Me.Label36)
        Me.MetroTabPage7.Controls.Add(Me.Label32)
        Me.MetroTabPage7.Controls.Add(Me.f3)
        Me.MetroTabPage7.Controls.Add(Me.f2)
        Me.MetroTabPage7.Controls.Add(Me.TextBox13)
        Me.MetroTabPage7.Controls.Add(Me.TextBox19)
        Me.MetroTabPage7.Controls.Add(Me.TextBox20)
        Me.MetroTabPage7.Controls.Add(Me.Label22)
        Me.MetroTabPage7.Controls.Add(Me.Label25)
        Me.MetroTabPage7.Controls.Add(Me.Label31)
        Me.MetroTabPage7.Controls.Add(Me.Label27)
        Me.MetroTabPage7.Controls.Add(Me.f1)
        Me.MetroTabPage7.Controls.Add(Me.Label23)
        Me.MetroTabPage7.Controls.Add(Me.Label24)
        Me.MetroTabPage7.Controls.Add(Me.TextBox17)
        Me.MetroTabPage7.Controls.Add(Me.Label28)
        Me.MetroTabPage7.Controls.Add(Me.Label19)
        Me.MetroTabPage7.Controls.Add(Me.Button10)
        Me.MetroTabPage7.Controls.Add(Me.Label20)
        Me.MetroTabPage7.Controls.Add(Me.Label26)
        Me.MetroTabPage7.Controls.Add(Me.Button11)
        Me.MetroTabPage7.Controls.Add(Me.Label21)
        Me.MetroTabPage7.Controls.Add(Me.Button12)
        Me.MetroTabPage7.HorizontalScrollbarBarColor = True
        Me.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.HorizontalScrollbarSize = 10
        Me.MetroTabPage7.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage7.Name = "MetroTabPage7"
        Me.MetroTabPage7.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage7.TabIndex = 6
        Me.MetroTabPage7.Text = "                  "
        Me.MetroTabPage7.VerticalScrollbarBarColor = True
        Me.MetroTabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.VerticalScrollbarSize = 10
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(111, 115)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(211, 20)
        Me.TextBox11.TabIndex = 108
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(111, 297)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(211, 20)
        Me.TextBox12.TabIndex = 107
        '
        'Sfecha
        '
        Me.Sfecha.Location = New System.Drawing.Point(493, 223)
        Me.Sfecha.Name = "Sfecha"
        Me.Sfecha.Size = New System.Drawing.Size(200, 20)
        Me.Sfecha.TabIndex = 127
        Me.Sfecha.Value = New Date(2016, 6, 28, 11, 5, 3, 0)
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(493, 189)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(211, 20)
        Me.TextBox14.TabIndex = 126
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(111, 226)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(211, 20)
        Me.TextBox15.TabIndex = 104
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Window
        Me.Label30.Location = New System.Drawing.Point(394, 118)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Apellido"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(111, 189)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(211, 20)
        Me.TextBox16.TabIndex = 103
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Window
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(631, 152)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(15, 20)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "-"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Window
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(551, 150)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(15, 20)
        Me.Label32.TabIndex = 124
        Me.Label32.Text = "-"
        '
        'f3
        '
        Me.f3.Location = New System.Drawing.Point(652, 152)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(52, 20)
        Me.f3.TabIndex = 123
        Me.f3.Text = "aa"
        Me.f3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'f2
        '
        Me.f2.Location = New System.Drawing.Point(572, 152)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(52, 20)
        Me.f2.TabIndex = 122
        Me.f2.Text = "mm"
        Me.f2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(111, 260)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(211, 20)
        Me.TextBox13.TabIndex = 106
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(493, 114)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(211, 20)
        Me.TextBox19.TabIndex = 113
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(111, 338)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(211, 20)
        Me.TextBox20.TabIndex = 112
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Window
        Me.Label22.Location = New System.Drawing.Point(12, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 13)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "ID Tipo de Usuario"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Window
        Me.Label25.Location = New System.Drawing.Point(12, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "ID Area"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Window
        Me.Label31.Location = New System.Drawing.Point(14, 341)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 13)
        Me.Label31.TabIndex = 109
        Me.Label31.Text = "Nombre"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Window
        Me.Label27.Location = New System.Drawing.Point(12, 229)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 13)
        Me.Label27.TabIndex = 98
        Me.Label27.Text = "ID Puesto"
        '
        'f1
        '
        Me.f1.Location = New System.Drawing.Point(493, 152)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(52, 20)
        Me.f1.TabIndex = 105
        Me.f1.Text = "dd"
        Me.f1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Window
        Me.Label23.Location = New System.Drawing.Point(12, 300)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "Password"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Location = New System.Drawing.Point(12, 263)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 13)
        Me.Label24.TabIndex = 100
        Me.Label24.Text = "Nombre de usuario"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(111, 152)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(211, 20)
        Me.TextBox17.TabIndex = 95
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Window
        Me.Label28.Location = New System.Drawing.Point(12, 118)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 96
        Me.Label28.Text = "ID Usuario"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label19.Location = New System.Drawing.Point(235, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 24)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "Borrar"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(232, 8)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(69, 65)
        Me.Button10.TabIndex = 93
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Window
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label20.Location = New System.Drawing.Point(146, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 24)
        Me.Label20.TabIndex = 92
        Me.Label20.Text = "Editar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Window
        Me.Label26.Location = New System.Drawing.Point(394, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 97
        Me.Label26.Text = "Fecha"
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(47, 8)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(69, 65)
        Me.Button11.TabIndex = 89
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Window
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label21.Location = New System.Drawing.Point(43, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 24)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "Guardar"
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(140, 8)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(69, 65)
        Me.Button12.TabIndex = 90
        Me.Button12.UseVisualStyleBackColor = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.optEthernet)
        Me.MetroTabPage3.Controls.Add(Me.lblIP)
        Me.MetroTabPage3.Controls.Add(Me.cboPuertos)
        Me.MetroTabPage3.Controls.Add(Me.cmdFirmware)
        Me.MetroTabPage3.Controls.Add(Me.cmdGrabar)
        Me.MetroTabPage3.Controls.Add(Me.optSerial)
        Me.MetroTabPage3.Controls.Add(Me.txtGrabar)
        Me.MetroTabPage3.Controls.Add(Me.txtIP)
        Me.MetroTabPage3.Controls.Add(Me.Label4)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(774, 406)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "                  "
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'optEthernet
        '
        Me.optEthernet.AutoSize = True
        Me.optEthernet.BackColor = System.Drawing.SystemColors.Window
        Me.optEthernet.Checked = True
        Me.optEthernet.Location = New System.Drawing.Point(21, 14)
        Me.optEthernet.Name = "optEthernet"
        Me.optEthernet.Size = New System.Drawing.Size(93, 17)
        Me.optEthernet.TabIndex = 54
        Me.optEthernet.TabStop = True
        Me.optEthernet.Text = "WIFI/Ethernet"
        Me.optEthernet.UseVisualStyleBackColor = False
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.BackColor = System.Drawing.SystemColors.Window
        Me.lblIP.Location = New System.Drawing.Point(43, 34)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(63, 13)
        Me.lblIP.TabIndex = 50
        Me.lblIP.Text = "IP TITANIO"
        '
        'cboPuertos
        '
        Me.cboPuertos.FormattingEnabled = True
        Me.cboPuertos.Location = New System.Drawing.Point(27, 226)
        Me.cboPuertos.Name = "cboPuertos"
        Me.cboPuertos.Size = New System.Drawing.Size(93, 21)
        Me.cboPuertos.TabIndex = 52
        Me.cboPuertos.Visible = False
        '
        'cmdFirmware
        '
        Me.cmdFirmware.Enabled = False
        Me.cmdFirmware.Location = New System.Drawing.Point(16, 151)
        Me.cmdFirmware.Name = "cmdFirmware"
        Me.cmdFirmware.Size = New System.Drawing.Size(120, 26)
        Me.cmdFirmware.TabIndex = 56
        Me.cmdFirmware.Text = "Firmware"
        Me.cmdFirmware.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(16, 90)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(101, 35)
        Me.cmdGrabar.TabIndex = 21
        Me.cmdGrabar.Text = "Cambiarr ID"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'optSerial
        '
        Me.optSerial.AutoSize = True
        Me.optSerial.BackColor = System.Drawing.SystemColors.Window
        Me.optSerial.Location = New System.Drawing.Point(27, 203)
        Me.optSerial.Name = "optSerial"
        Me.optSerial.Size = New System.Drawing.Size(51, 17)
        Me.optSerial.TabIndex = 55
        Me.optSerial.Text = "Serial"
        Me.optSerial.UseVisualStyleBackColor = False
        Me.optSerial.Visible = False
        '
        'txtGrabar
        '
        Me.txtGrabar.Enabled = False
        Me.txtGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrabar.Location = New System.Drawing.Point(123, 96)
        Me.txtGrabar.Name = "txtGrabar"
        Me.txtGrabar.Size = New System.Drawing.Size(211, 22)
        Me.txtGrabar.TabIndex = 19
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(16, 50)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(92, 20)
        Me.txtIP.TabIndex = 51
        Me.txtIP.Text = "10.1.1.10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(74, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Puerto"
        Me.Label4.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(23, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 24)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "Status"
        '
        'cmdLeer
        '
        Me.cmdLeer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLeer.Enabled = False
        Me.cmdLeer.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLeer.Location = New System.Drawing.Point(706, 63)
        Me.cmdLeer.Name = "cmdLeer"
        Me.cmdLeer.Size = New System.Drawing.Size(79, 29)
        Me.cmdLeer.TabIndex = 22
        Me.cmdLeer.Text = "Leer"
        Me.cmdLeer.UseVisualStyleBackColor = True
        '
        'cmdConectar2
        '
        Me.cmdConectar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConectar2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConectar2.Location = New System.Drawing.Point(706, 30)
        Me.cmdConectar2.Name = "cmdConectar2"
        Me.cmdConectar2.Size = New System.Drawing.Size(79, 29)
        Me.cmdConectar2.TabIndex = 46
        Me.cmdConectar2.Text = "Conectar"
        Me.cmdConectar2.UseVisualStyleBackColor = True
        '
        'tmrComando2
        '
        Me.tmrComando2.Enabled = True
        Me.tmrComando2.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(14, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 67)
        Me.Button2.TabIndex = 47
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ReportesAct
        '
        Me.ReportesAct.BackgroundImage = CType(resources.GetObject("ReportesAct.BackgroundImage"), System.Drawing.Image)
        Me.ReportesAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportesAct.Location = New System.Drawing.Point(99, 50)
        Me.ReportesAct.Name = "ReportesAct"
        Me.ReportesAct.Size = New System.Drawing.Size(75, 67)
        Me.ReportesAct.TabIndex = 48
        Me.ReportesAct.UseVisualStyleBackColor = True
        '
        'EditarTag
        '
        Me.EditarTag.BackgroundImage = CType(resources.GetObject("EditarTag.BackgroundImage"), System.Drawing.Image)
        Me.EditarTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditarTag.Location = New System.Drawing.Point(184, 50)
        Me.EditarTag.Name = "EditarTag"
        Me.EditarTag.Size = New System.Drawing.Size(75, 67)
        Me.EditarTag.TabIndex = 49
        Me.EditarTag.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(269, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 67)
        Me.Button5.TabIndex = 50
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(354, 50)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 67)
        Me.Button6.TabIndex = 51
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(438, 50)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 67)
        Me.Button7.TabIndex = 52
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(523, 50)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 67)
        Me.Button8.TabIndex = 53
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 562)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.EditarTag)
        Me.Controls.Add(Me.ReportesAct)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdConectar2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Lector)
        Me.Controls.Add(Me.cmdLeer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.Lector.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage7.ResumeLayout(False)
        Me.MetroTabPage7.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lector As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdConectar As System.Windows.Forms.Button
    Private WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdConectar2 As System.Windows.Forms.Button
    Friend WithEvents optEthernet As System.Windows.Forms.RadioButton
    Friend WithEvents optSerial As System.Windows.Forms.RadioButton
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents cboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvLista As System.Windows.Forms.ListView
    Friend WithEvents chTag As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBytes As System.Windows.Forms.ColumnHeader
    Friend WithEvents chHora As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGHexString As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdDisminuir As System.Windows.Forms.Button
    Friend WithEvents cmdAumentar As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdLeer As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents txtGrabar As System.Windows.Forms.TextBox
    Friend WithEvents lstComandos As System.Windows.Forms.ListBox
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrComando2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdFirmware As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportesAct As System.Windows.Forms.Button
    Friend WithEvents EditarTag As System.Windows.Forms.Button
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents IDtext As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents f1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents f3 As System.Windows.Forms.TextBox
    Friend WithEvents f2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Sfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
End Class
