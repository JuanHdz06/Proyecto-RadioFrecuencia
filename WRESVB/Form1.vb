Imports Microsoft.Office.Interop
Public Class Form1
    Dim WithEvents RFID As UserControl1
    Public Const cstAplicacion As String = "prjAccysRFID"
    Public Const cstGeneral As String = "General"
    Public Const cstBaudrate As String = "Baudrate"
    Public Const cstIP As String = "IP"
    Public Const cstRuta As String = "Ruta"
    Public Const cstPuertoCOM As String = "PuertoCOM"
    Public Const cstTipoConexion As String = "TipoConexion"
    Dim mbolGrabando As Boolean
    Dim tag As String = ""

    Private Sub lfAgregarItem(ByVal pstrTag As String)

        Dim strTag As String = pstrTag
        Dim ItemX As ListViewItem


        strTag = Replace(pstrTag, Chr(0), "")

        'Verificar si hay un item con el tag indicado
        For Each ItemX In lsvLista.Items
            If ItemX.Text = strTag Then
                ItemX.SubItems(1).Text = Val(ItemX.SubItems(1).Text) + 1
                ItemX.SubItems(3).Text = FormatDateTime(Now, DateFormat.LongTime)
                Exit Sub
            End If
        Next


        'Agregar Item
        ItemX = lsvLista.Items.Insert(0, strTag)
        ItemX.SubItems.Add("1")
        ItemX.SubItems.Add(Len(pstrTag))
        ItemX.SubItems.Add(FormatDateTime(Now, DateFormat.LongTime))
        ItemX.SubItems.Add(RFID.gfASCII2Hex(pstrTag, " "))
        lblTotal.Text = Val(lblTotal.Text) + 1
        
    End Sub

    Private Sub cmdConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConectar.Click
        On Error Resume Next
        If cmdConectar.Text = "Conectar" Then
            lstComandos.Items.Add("CONECTAR")
            cmdConectar.Text = "Desconectar"
            Call lfHabilitarControles(True)
            lblStatus.Text = "Conectado"
            '       Call SaveSetting(cstAplicacion, cstGeneral, cstIP, txtIP)
        Else
            lstComandos.Items.Add("DESCONECTAR")
            cmdConectar.Text = "Conectar"
            Call lfHabilitarControles(False)
            lblStatus.Text = "Desconectado"
        End If

    End Sub

    Private Sub lfHabilitarControles(ByVal pbolHabilitar)

        txtGrabar.Enabled = pbolHabilitar
        cmdGrabar.Enabled = pbolHabilitar
        cmdLeer.Enabled = pbolHabilitar
        lsvLista.Enabled = pbolHabilitar
        ''cmdFirmware.Enabled = pbolHabilitar
        cmdExportar.Enabled = pbolHabilitar
        cmdEliminar.Enabled = pbolHabilitar
        txtIP.Enabled = Not pbolHabilitar
        cboPuertos.Enabled = Not pbolHabilitar

    End Sub

    Private Sub txtIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIP.TextChanged
        Call SaveSetting(cstAplicacion, cstGeneral, cstIP, txtIP.Text)
    End Sub

    Private Sub cboPuertos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPuertos.SelectedIndexChanged
        Call SaveSetting(cstAplicacion, cstGeneral, cstPuertoCOM, cboPuertos.Text)
    End Sub


    Private Sub optEthernet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optEthernet.Click
        On Error Resume Next
        txtIP.Enabled = optEthernet.Checked
        cboPuertos.Enabled = Not optEthernet.Checked
        Call SaveSetting(cstAplicacion, cstGeneral, cstTipoConexion, IIf(optEthernet.Checked, "Ethernet", "Serial"))
    End Sub

    Private Sub optSerial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optSerial.Click
        ''On Error Resume Next
        ''Call optEthernet_Click(sender, e)
    End Sub

    Private Sub cmdFirmware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstComandos.Items.Add("FIRMWARE")
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        'ANTES SE AGREGA UNA REFERENCIA A LA LIBRERIA DE TIPO MICROSOFTEXCEL 12.0 OBJECT LIBRARY
        Dim objExcel As New Excel.Application
        Dim objWorkBook As Excel.Workbook
        Dim objWorksheet As Excel.Worksheet
        Dim i As Integer
        Dim ItemX As ListViewItem
        objWorkBook = objExcel.Workbooks.Add
        objWorksheet = objWorkBook.Worksheets.Add

        'PONER ENCABEZADOS A COLUMNAS EN EXCEL
        objWorksheet.Cells(1, 1) = "REPORTE DE ACTIVOS"

        For i = 1 To 1
            With objWorksheet.Cells(i, 1)
                .Font.Bold = True
                .Font.Size = 20
            End With
        Next

        'COMBINAR Y CENTRAR CELDAS DEL TITULO
        objWorksheet.Range("A1:D1").MergeCells = True
        'objWorksheet.Range("A1:D1").HorizontalAlignment = xlHAlignCenter


        'PONER TITULOS A COLUMNAS EN EXCEL
        objWorksheet.Cells(4, 1) = "CLAVE RFID"
        objWorksheet.Cells(4, 2) = "HORA"
        objWorksheet.Cells(2, 1) = "FECHA : " & Format(Now, "yyyy/MM/dd")
        objWorksheet.Cells(2, 2) = "TOTAL DE ACTIVOS : " & lblTotal.Text
        objWorksheet.Rows(4).Font.Bold = True
        objWorksheet.Rows(2).Font.Bold = True


        'PONER ANCHO A COLUMNAS EN EXCEL
        objWorksheet.Columns(1).ColumnWidth = 20
        objWorksheet.Columns(2).ColumnWidth = 20

        'DEPOSITAR DATOS

        i = 1
        For Each ItemX In lsvLista.Items
            objWorksheet.Cells(i + 4, 1) = "'" & ItemX.Text
            objWorksheet.Cells(i + 4, 2) = ItemX.SubItems(3).Text
            i = i + 1
        Next

        'MOSTRAR EXCEL
        objExcel.Visible = True



    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        'Dim ItemX As ListViewItem
        'Dim i As Integer
        'i = 1
        'For Each ItemX In lsvLista.Items
        '    If ItemX.Text = lsvLista.seleSelectedItem Then
        '        lsvLista.Items.RemoveAt(i)
        '        Exit For
        '    End If
        '    i = i + 1
        'Next

    End Sub

    Private Sub cmdLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeer.Click
        Dim pbolHabilitar As Boolean

        On Error Resume Next
        If cmdLeer.Text = "Leer" Then
            lstComandos.Items.Add("LEER")
            cmdLeer.Text = "Detener"
            lblStatus.Text = "Leyendo..."
            pbolHabilitar = False
        Else
            lstComandos.Items.Add("DETENER")
            cmdLeer.Text = "Leer"
            lblStatus.Text = "Detenido"
            pbolHabilitar = True
        End If

        Call lfHabilitarControles(pbolHabilitar)
        cmdConectar.Enabled = pbolHabilitar
        cmdLeer.Enabled = True
        lsvLista.Enabled = True

    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        lsvLista.Items.Clear()
        lblTotal.Text = 0
        lblTag.Text = "."
    End Sub

    Private Sub lblTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTag.TextChanged
        If lblTag.Text <> "." Then
            tag = lblTag.Text
           
            Call lfAgregarItem(tag)
            
        End If
    End Sub

    Private Sub cmdAumentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAumentar.Click
        lblTag.Text = txtGrabar.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RFID = New UserControl1
        mbolGrabando = False
        Call lfHabilitarControles(False)


        Try
            For Each sPort As String In My.Computer.Ports.SerialPortNames
                cboPuertos.Items.Add(sPort)
            Next
        Catch ex As Exception

        End Try



        txtIP.Text = GetSetting(cstAplicacion, cstGeneral, cstIP)
        cboPuertos.Text = GetSetting(cstAplicacion, cstGeneral, cstPuertoCOM, "COM1")
        optEthernet.Checked = IIf(GetSetting(cstAplicacion, cstGeneral, cstTipoConexion, "Ethernet") = "Ethernet", True, False)
        optSerial.Checked = IIf(GetSetting(cstAplicacion, cstGeneral, cstTipoConexion, "Ethernet") = "Serial", True, False)
        lblTotal.Text = 0

    End Sub

    Private Sub tmrComando_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrComando.Tick


        If lstComandos.Items.Count = 0 Then Exit Sub

        lstComandos.SelectedIndex = 0

        On Error GoTo Errores
        Select Case lstComandos.SelectedItem
            Case "CONECTAR"
                Call RFID.pfConectar(optSerial.Checked, GetSetting(cstAplicacion, cstGeneral, cstPuertoCOM, cboPuertos.Text), 4001, GetSetting(cstAplicacion, cstGeneral, cstIP, txtIP.Text))
            Case "DESCONECTAR"
                Call RFID.pfDesconectar()
                If Val(tmrComando.Tag) = 1 Then End
            Case "GRABAR"
                Call RFID.pfWriteID(True, txtGrabar.Text)
            Case "LEER"
                Call RFID.pfSingleRead()
            Case "DETENER"
                Call RFID.pfStop()
            Case "CERRARSISTEMA"
                tmrComando.Tag = 1
                lstComandos.Items.Add("DETENER")
                lstComandos.Items.Add("DESCONECTAR")
                '  MsgBox("")
            Case "FIRMWARE"
                Call RFID.pfFirmwareVersion()
            Case "PRELEVADOR"
                Call RFID.pfRelevador(True)
            Case "ARELEVADOR"
                Call RFID.pfRelevador(False)
        End Select

        lstComandos.Items.RemoveAt(0)
        If RFID.DescError = "" Then Exit Sub
        lblStatus.Text = RFID.DescError
        Exit Sub
Errores:
        MsgBox(Err.Description, vbCritical, "Error No. " & Err.Number & " - ACCSYS-3000")
        Exit Sub

    End Sub


    Private Sub RFID_peRespuesta(ByRef pintRespuesta As UserControl1.eTipoRespuesta, ByRef pstrDato As String) Handles RFID.peRespuesta
        Dim strTag As String

        Select Case pintRespuesta
            Case UserControl1.eTipoRespuesta.eeLectura
                strTag = pstrDato
                lblTag.Text = strTag
                'Call lfAgregarItem(pstrDato)
            Case UserControl1.eTipoRespuesta.eeStatusCommand
            Case UserControl1.eTipoRespuesta.eeWrite
                If mbolGrabando = True Then
                    If pstrDato = Chr(0) Then
                        lblStatus.Text = "Grabado exitosamente."
                        'Call lfAumentarNumero()

                        mbolGrabando = False
                        '                    lstComandos.AddItem "DETENER"
                        cmdGrabar.Text = "Grabar"
                        '                    lblStatus.Caption = "Detenido"

                    Else
                        lblStatus.Text = "Error al grabar."
                    End If
                End If
            Case UserControl1.eTipoRespuesta.eeFirmware
                MsgBox(pstrDato)
        End Select

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        

    End Sub



    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        On Error Resume Next
        If Me.cmdGrabar.Text = "Grabar" Then
            mbolGrabando = True
            lstComandos.Items.Add("GRABAR")
            cmdGrabar.Text = "Detener"
            lblStatus.Text = "Grabando..."
        Else
            mbolGrabando = False
            lstComandos.Items.Add("DETENER")
            cmdGrabar.Text = "Grabar"
            lblStatus.Text = "Detenido"
        End If
    End Sub

    Private Sub lstComandos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstComandos.SelectedIndexChanged

    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTag.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub optEthernet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEthernet.CheckedChanged

    End Sub

    Private Sub lblIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIP.Click

    End Sub

    Private Sub optSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSerial.CheckedChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtGrabar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrabar.TextChanged

    End Sub

    Private Sub cmdDisminuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisminuir.Click

    End Sub
End Class
