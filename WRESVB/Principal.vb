Imports Microsoft.Office.Interop
Imports System.Data.SqlClient

Public Class Principal
    Dim WithEvents RFID As UserControl1
    Public Const cstAplicacion As String = "prjAccysRFID"
    Public Const cstGeneral As String = "General"
    Public Const cstBaudrate As String = "Baudrate"
    Public Const cstIP As String = "IP"
    Public Const cstRuta As String = "Ruta"
    Public Const cstPuertoCOM As String = "PuertoCOM"
    Public Const cstTipoConexion As String = "TipoConexion"
    Dim mbolGrabando As Boolean
    Private dv As New DataView
    Dim tag As String = ""
    


    Private Sub lfAgregarItem(ByVal pstrTag As String)

        Dim strTag As String = pstrTag
        Dim ItemX As ListViewItem


        strTag = Replace(pstrTag, Chr(0), "")

        'Verificar si hay un item con el tag indicado
        For Each ItemX In lsvLista.Items
            If ItemX.Text = strTag Then
                'ItemX.SubItems(1).Text = Val(ItemX.SubItems(1).Text) + 1   ///No de reg.
                'ItemX.SubItems(3).Text = FormatDateTime(Now, DateFormat.LongTime)
                Exit Sub
            End If
        Next


        'Agregar Item
        ItemX = lsvLista.Items.Insert(0, strTag)
        'ItemX.SubItems.Add("1") 
        ItemX.SubItems.Add(Len(pstrTag))
        ItemX.SubItems.Add(FormatDateTime(Now, DateFormat.LongTime))
        ItemX.SubItems.Add(RFID.gfASCII2Hex(pstrTag, " "))
        lblTotal.Text = Val(lblTotal.Text) + 1


    End Sub


    Private Sub lfHabilitarControles(ByVal pbolHabilitar)

        txtGrabar.Enabled = pbolHabilitar
        cmdGrabar.Enabled = pbolHabilitar
        cmdLeer.Enabled = pbolHabilitar
        lsvLista.Enabled = pbolHabilitar
        cmdFirmware.Enabled = pbolHabilitar
        cmdExportar.Enabled = pbolHabilitar
        'cmdEliminar.Enabled = pbolHabilitar
        txtIP.Enabled = Not pbolHabilitar
        cboPuertos.Enabled = Not pbolHabilitar

    End Sub

    Private Sub txtIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SaveSetting(cstAplicacion, cstGeneral, cstIP, txtIP.Text)
    End Sub

    Private Sub cboPuertos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SaveSetting(cstAplicacion, cstGeneral, cstPuertoCOM, cboPuertos.Text)
    End Sub


    Private Sub optEthernet_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        txtIP.Enabled = optEthernet.Checked
        cboPuertos.Enabled = Not optEthernet.Checked
        Call SaveSetting(cstAplicacion, cstGeneral, cstTipoConexion, IIf(optEthernet.Checked, "Ethernet", "Serial"))
    End Sub

    Private Sub optSerial_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Call optEthernet_Click(sender, e)
    End Sub

    Private Sub cmdFirmware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstComandos.Items.Add("FIRMWARE")
    End Sub

    ''------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    Private Sub lblTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTag.TextChanged
        If lblTag.Text <> "." Then
            tag = lblTag.Text
            IDtext.Text = lblTag.Text

            Call lfAgregarItem(tag)

        End If
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

    Private Sub cmdConectar2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConectar2.Click
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

    Private Sub cmdLeer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeer.Click
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
        cmdConectar2.Enabled = pbolHabilitar
        cmdLeer.Enabled = True
        lsvLista.Enabled = True
    End Sub

    Private Sub txtIP_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIP.TextChanged
        Call SaveSetting(cstAplicacion, cstGeneral, cstIP, txtIP.Text)
    End Sub

    Private Sub cboPuertos_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPuertos.SelectedIndexChanged
        Call SaveSetting(cstAplicacion, cstGeneral, cstPuertoCOM, cboPuertos.Text)
    End Sub

    Private Sub cmdLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        lsvLista.Items.Clear()
        lblTotal.Text = 0
        lblTag.Text = "."
    End Sub

    Private Sub cmdExportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
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
        objWorksheet.Cells(4, 3) = "ID"
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
            objWorksheet.Cells(i + 4, 2) = ItemX.SubItems(2).Text
            objWorksheet.Cells(i + 4, 3) = ItemX.SubItems(3).Text
            i = i + 1
        Next

        'MOSTRAR EXCEL
        objExcel.Visible = True


    End Sub

    Private Sub cmdAumentar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAumentar.Click
        lblTag.Text = txtGrabar.Text
    End Sub



    Private Sub tmrComando2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrComando2.Tick

        If lstComandos.Items.Count = 0 Then Exit Sub

        lstComandos.SelectedIndex = 0

        On Error GoTo Errores
        Select Case lstComandos.SelectedItem
            Case "CONECTAR"
                Call RFID.pfConectar(optSerial.Checked, GetSetting(cstAplicacion, cstGeneral, cstPuertoCOM, cboPuertos.Text), 4001, GetSetting(cstAplicacion, cstGeneral, cstIP, txtIP.Text))
            Case "DESCONECTAR"
                Call RFID.pfDesconectar()
                If Val(tmrComando2.Tag) = 1 Then End
            Case "GRABAR"
                Call RFID.pfWriteID(True, txtGrabar.Text)
            Case "LEER"
                Call RFID.pfSingleRead()
            Case "DETENER"
                Call RFID.pfStop()
            Case "CERRARSISTEMA"
                tmrComando2.Tag = 1
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

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

     

        

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


       
        'MetroTabPage7.Dispose() eliminar tab
        Dim cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
        Dim da As New SqlDataAdapter("select * from V_Doc", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        DataGridView1.DataSource = dv






    End Sub

    Private Sub cmdEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try
                Dim query As String = "INSERT INTO DOCUMENTO (cod_bar,cod_alterno,asunto,hojas,estante,division,nivel,linea,exediente,id_tipo_documento) " & _
                                        "VALUES (@param2, @param3,@param4, @param5, @param6,@param7, @param8, @param9,@param10,@param11)"
                Dim cmd As New SqlCommand(query, cnn)

                'DEPOSITAR DATOS



                'cmd.Parameters.AddWithValue("@param1", IDtext.Text) 'Nombre de la etiqueta y ID
                cmd.Parameters.AddWithValue("@param2", TextBox10.Text)
                cmd.Parameters.AddWithValue("@param3", TextBox1.Text)
                cmd.Parameters.AddWithValue("@param4", TextBox2.Text)
                cmd.Parameters.AddWithValue("@param5", TextBox4.Text)
                cmd.Parameters.AddWithValue("@param6", TextBox3.Text)
                cmd.Parameters.AddWithValue("@param7", TextBox5.Text)
                cmd.Parameters.AddWithValue("@param8", TextBox6.Text)
                cmd.Parameters.AddWithValue("@param9", TextBox7.Text)
                cmd.Parameters.AddWithValue("@param10", TextBox8.Text)
                cmd.Parameters.AddWithValue("@param11", TextBox9.Text)

                cmd.ExecuteNonQuery()

                MsgBox("Guardado en la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using

    End Sub

    Private Sub cmdFirmware_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirmware.Click
        lstComandos.Items.Add("FIRMWARE")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        cmdConectar2.Enabled = pbolHabilitar
        cmdLeer.Enabled = True
        lsvLista.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Lector.SelectedTab = MetroTabPage1
    End Sub

    Private Sub ReportesAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesAct.Click
        Lector.SelectedTab = MetroTabPage4
    End Sub

    Private Sub EditarTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarTag.Click
        Lector.SelectedTab = MetroTabPage6
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try

                MsgBox("Editado en la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    

    
    Private Sub lblStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.TextChanged
        If lblStatus.Text = "Desconectado" Then
            cmdConectar2.Text = "Conectar"
        ElseIf lblStatus.Text = "Conectado" Then
            cmdConectar2.Text = "Desconectar"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try
                Dim modificar As String = "UPDATE DOCUMENTO SET cod_bar = '" & TextBox10.Text & "', cod_alterno = '" & TextBox1.Text & "',asunto = '" & TextBox2.Text & "',hojas = '" & TextBox4.Text & "',estante = '" & TextBox3.Text & "',division = '" & TextBox5.Text & "', nivel = '" & TextBox6.Text & "', linea = '" & TextBox7.Text & "', exediente = '" & TextBox8.Text & "', id_tipo_documento = '" & TextBox9.Text & "' WHERE id_documento = '" & IDtext.Text & "'"
                Dim cmd As New SqlCommand(modificar, cnn)


                cmd.ExecuteNonQuery()

                MsgBox("Editado en la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    Private Sub IDtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDtext.TextChanged
        Dim sql As String
        Dim cn As SqlConnection
        Dim cm As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Try
            sql = "select * from DOCUMENTO where id_documento = '" + IDtext.Text + "'"
            cn = New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cn.Open()

            cm = New SqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New SqlDataAdapter(cm)

            ds = New DataSet()
            da.Fill(ds)
            grilla.DataSource = ds.Tables(0).DefaultView

            
            TextBox1.Text = grilla.CurrentRow.Cells(1).Value.ToString()
            TextBox2.Text = grilla.CurrentRow.Cells(2).Value.ToString()
            TextBox3.Text = grilla.CurrentRow.Cells(3).Value.ToString()
            TextBox4.Text = grilla.CurrentRow.Cells(4).Value.ToString()
            TextBox5.Text = grilla.CurrentRow.Cells(5).Value.ToString()
            TextBox6.Text = grilla.CurrentRow.Cells(6).Value.ToString()
            TextBox7.Text = grilla.CurrentRow.Cells(7).Value.ToString()
            TextBox8.Text = grilla.CurrentRow.Cells(8).Value.ToString()
            TextBox9.Text = grilla.CurrentRow.Cells(9).Value.ToString()
            TextBox10.Text = grilla.CurrentRow.Cells(10).Value.ToString()

        Catch
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        IDtext.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lector.SelectedTab = MetroTabPage5
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Lector.SelectedTab = MetroTabPage2 '5
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Lector.SelectedTab = MetroTabPage7 '6
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Lector.SelectedTab = MetroTabPage3 '7
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try
                Dim elimina As String = "delete from DOCUMENTO where id_documento = '" & IDtext.Text & "'"
                Dim cmd As New SqlCommand(elimina, cnn)


                cmd.ExecuteNonQuery()

                MsgBox("Eliminado de la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    Private Sub f1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1.Click
        If f1.Text = "dd" Then
            f1.Text = ""
        End If
    End Sub

    Private Sub f2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f2.Click
        If f2.Text = "mm" Then
            f2.Text = ""
        End If
    End Sub

    Private Sub f3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f3.Click
        If f3.Text = "aa" Then
            f3.Text = ""
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Using con As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            con.Open()

            Try
                Dim agregausuario As String = "INSERT INTO USUARIO (id_usuario,id_tipo_usuario,id_area,id_puesto,login,password,nombre,apellido,fecha_nacimiento) " & _
                                        "VALUES (@param1, @param2, @param3,@param4, @param5, @param6,@param7, @param8, @param9)"
                Dim cmd1 As New SqlCommand(agregausuario, con)

                'DEPOSITAR DATOS
                'TextBox14 fecha

                cmd1.Parameters.AddWithValue("@param1", TextBox11.Text)
                cmd1.Parameters.AddWithValue("@param2", TextBox17.Text)
                cmd1.Parameters.AddWithValue("@param3", TextBox16.Text)
                cmd1.Parameters.AddWithValue("@param4", TextBox15.Text)
                cmd1.Parameters.AddWithValue("@param5", TextBox13.Text)
                cmd1.Parameters.AddWithValue("@param6", TextBox12.Text)
                cmd1.Parameters.AddWithValue("@param7", TextBox20.Text)
                cmd1.Parameters.AddWithValue("@param8", TextBox19.Text)
                cmd1.Parameters.AddWithValue("@param9", TextBox14.Text)


                cmd1.ExecuteNonQuery()

                MsgBox("Guardado en la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try
                Dim modificar As String = "UPDATE USUARIO SET id_usuario = '" & TextBox11.Text & "', id_tipo_usuario = '" & TextBox17.Text & "', id_area = '" & TextBox16.Text & "',id_puesto = '" & TextBox15.Text & "',login = '" & TextBox13.Text & "',password = '" & TextBox12.Text & "',nombre = '" & TextBox20.Text & "', apellido = '" & TextBox19.Text & "', fecha_nacimiento = '" & TextBox14.Text & "' WHERE id_usuario = '" & TextBox11.Text & "'"
                Dim cmd As New SqlCommand(modificar, cnn)


                cmd.ExecuteNonQuery()

                MsgBox("Usuario modificado en la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    Private Sub f1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1.TextChanged
        TextBox14.Text = f3.Text & "-" & f2.Text + "-" & f1.Text
    End Sub

    Private Sub f2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f2.TextChanged
        TextBox14.Text = f3.Text & "-" & f2.Text + "-" & f1.Text
    End Sub

    Private Sub f3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f3.TextChanged
        TextBox14.Text = f3.Text & "-" & f2.Text + "-" & f1.Text
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Using cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
            cnn.Open()

            Try
                Dim elimina As String = "delete from USUARIO WHERE id_usuario = '" & TextBox11.Text & "'"
                Dim cmd As New SqlCommand(elimina, cnn)


                cmd.ExecuteNonQuery()

                MsgBox("Eliminado de la base de datos")
            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        End Using
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        'dv.RowFilter = String.Format("CONVERT(Codigo_de_Barras,System.String) Like '%{0}%'", TextBox21.Text)
    End Sub

    
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
        Dim da As New SqlDataAdapter("select * from Documento where cod_bar like '%" & TextBox21.Text & "' ", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        DataGridView1.DataSource = dv

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim cnn As New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")
        Dim da As New SqlDataAdapter("select * from V_Doc", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        DataGridView1.DataSource = dv
    End Sub
End Class
