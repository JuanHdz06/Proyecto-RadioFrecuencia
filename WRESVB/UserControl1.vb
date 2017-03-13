Imports MSWinsockLib.StateConstants

Public Class UserControl1
    Dim strBankID As String = "00"

    'Public Event peRespuesta(ByVal pintRespuesta As eTipoRespuesta, ByVal pstrDato As String)

    Public Event peRespuesta(ByRef pintRespuesta As eTipoRespuesta, ByRef pstrDato As String)


    Public Enum eTipoRespuesta
        eeFirmware = 0
        eeSingleTag = 1
        eeMultiTag = 2
        eeLectura = 3
        eeStatusCommand = 4
        eeReadBlockData = 5
        eeKillTag = 6
        eeLog = 7
        eeWriteUserData = 8
        eeWriteMemory = 9
        eeUnlockMemory = 10
        eeLockMemory = 11
        eeReadMemory = 12
        eeWrite = 13
    End Enum


    Public bolMultilectura As Boolean


    'local variable(s) to hold property value(s)
    Private mvarDescError As String 'local copy
    Private mvarRBDMemoryBankID As Integer 'local copy
    Private mvarbolSerial As Boolean 'local copy


    Public Function bolSerial(Optional ByVal vData As Boolean = False) As Boolean
        bolSerial = mvarbolSerial
    End Function

    Public Function DescError(Optional ByVal vData As String = "") As String
        If vData = "" Then
            DescError = mvarDescError
        Else
            DescError = vData
        End If

    End Function


    Public Function RBDMemoryBankID(ByVal vData As Integer) As Integer
        RBDMemoryBankID = mvarRBDMemoryBankID
    End Function






    '*******************************************************************************************************
    'Funcion Unknown
    '*******************************************************************************************************
    Public Function CRC_16(ByVal CRC_String As String) As String

        Dim CRCx As Long, POLYx As Long, ITemp As Long, TempCRC As String
        Dim a As Long, i As Long ', Hold As Long, 
        Dim sTemp As String
        Dim itemp2 As Long

        CRCx = 65535 '&HFFFF
        POLYx = 4129 '&H1021

        For a = 1 To Len(CRC_String)
            sTemp = Mid(CRC_String, a, 2)
            ITemp = Val("&h" & sTemp)
            ITemp = ITemp * 256


            For i = 1 To 8
                itemp2 = ITemp Xor CRCx
                itemp2 = itemp2 And 32768

                If itemp2 <> 0 Then
                    CRCx = (CRCx * 2)
                    CRCx = POLYx Xor CRCx
                    CRCx = CRCx And 65535
                Else
                    CRCx = (CRCx * 2)
                    CRCx = CRCx And 65535
                End If

                ITemp = (ITemp * 2)
                ITemp = ITemp And 65535
            Next

            a = a + 1
        Next

        ITemp = CRCx Xor 65535
        TempCRC = Hex(ITemp)

        If Len(TempCRC) < 4 Then
            For i = 1 To 4 - Len(TempCRC)
                TempCRC = "0" + TempCRC
            Next
        End If

        CRC_16 = TempCRC

    End Function


    '******************************************************************************************************
    'funcion que convierte una cadena de codigos hexadecimales a cadena de texto de caracteres raros xD
    '******************************************************************************************************
    Public Function lfConvertirHexATxt(ByVal pstrString As String, Optional ByVal pbolCortarEnNulo As Boolean = False) As String

        Dim i As Integer
        Dim bufferfinal As String
        Dim strChar As String


        'Convertir toda la cadena a codigo hexadecimal
        bufferfinal = ""
        For i = 1 To Len(pstrString) Step 2
            If pbolCortarEnNulo = True Then
                If Mid(pstrString, i, 2) = "00" Then Exit For
            End If
            strChar = Chr(Int("&H" & (Mid(pstrString, i, 2))))
            bufferfinal = bufferfinal & strChar
        Next


        lfConvertirHexATxt = bufferfinal


    End Function




    '******************************************************************************************************
    'funcion que convierte una cadena de texto a codigo hexadecimal
    'sirve para obtener los datos hexadecimales de una cadena, generalmente de caracteres raros
    '******************************************************************************************************
    Public Function lfConvertirTxtAHex(ByVal pstrString As String) As String
        Dim i As Integer
        Dim bufferfinal As String
        Dim strChar As String


        'Convertir toda la cadena a codigo hexadecimal
        bufferfinal = ""
        For i = 1 To Len(pstrString)
            strChar = Hex(Asc(Mid(pstrString, i, 1))) 'obtener el codigo hexadecimal del caracter
            If Len(strChar) = 1 Then strChar = "0" & strChar 'si es solo una cifra agregar cero a la izquierda
            bufferfinal = bufferfinal & strChar
        Next

        'regresar la cadena
        lfConvertirTxtAHex = bufferfinal

    End Function



    '**********************************************************************************************
    'Funcion para habilitar la lectura de un solo tag
    '**********************************************************************************************
    Public Sub pfSingleRead()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String



        On Error Resume Next


        'Crear la señal para activar la lectura
        sum = CRC_16("052000")
        enviar = "052000" + sum

        '' '' ''If Me.bolSerial = True Then
        '' '' ''    Call lfEnviarComando(enviar)
        '' '' ''Else
        hex2ascii = lfConvertirHexATxt(enviar)
        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)
        '' '' ''End If



        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub


    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfFirmwareVersion()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String


        On Error Resume Next

        'Crear la señal para activar el firmware
        sum = CRC_16("050000")
        enviar = "050000" + sum


        '''''    If Me.bolSerial = True Then
        '''''' Call lfEnviarComando(enviar)
        '''''' Else
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        'MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)
        '''''''End If

        mvarDescError = ""
        If Err.Number = 0 Then Exit Sub
        mvarDescError = Err.Number & " - " & Err.Description

    End Sub


    '**********************************************************************************************
    'Funcion para leer el multiples tags
    '**********************************************************************************************
    Public Sub pfMultiRead()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String


        On Error Resume Next


        'Crear la señal para activar el firmware
        sum = CRC_16("07201E0000")
        enviar = "07201E0000" + sum
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        bolMultilectura = True
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub

    '**********************************************************************************************
    'Funcion para leer el Single TTS tags
    '**********************************************************************************************
    Public Sub pfSingleTTSRead()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String


        On Error Resume Next


        'Crear la señal para activar el firmware
        sum = CRC_16("12110E00000000000000000000002BF0")
        enviar = "12110E00000000000000000000002BF0" + sum
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)


    End Sub

    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfStop()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String


        On Error Resume Next
        ' '' '' ''If Me.bolSerial = True Then
        ' '' '' ''    Call lfEnviarComando("00")

        ' '' '' ''Else
        'Crear la señal para activar el firmware
        '    sum = CRC_16("00")
        '    enviar = "00" + sum
        '    hex2ascii = lfConvertirHexATxt(enviar)
        hex2ascii = lfConvertirHexATxt("00")

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)
        ' '' '' ''End If



        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)


    End Sub



    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfRFPowerON()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String



        On Error Resume Next


        'Crear la señal para activar el firmware
        sum = CRC_16("050005")
        enviar = "050005" + sum
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub


    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfRFPowerOFF()

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String



        On Error Resume Next


        'Crear la señal para activar el firmware
        sum = CRC_16("050006")
        enviar = "050006" + sum
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub



    ''**********************************************************************************************
    ''Funcion para leer el firmware
    ''**********************************************************************************************
    'Public Sub pfConectar(pintPuerto As Integer, pstrBaudrate As String)
    '
    '
    '    On Error Resume Next
    '
    '    'Conectar el comm
    ''    MSComm1.Settings = "57600,n,8,1"
    ''    MSComm1.Settings = "9600,n,8,1"
    '    MSComm1.Settings = pstrBaudrate & ",n,8,1"
    '    MSComm1.CommPort = pintPuerto
    '    MSComm1.PortOpen = True
    '    Timer1.Enabled = True
    ' 
    '    DescError = ""
    '    If Err.Number = 0 Then Exit Sub
    '    DescError = Err.Number & " - " & Err.Description
    '
    'End Sub

    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfConectar(ByVal pbolSerial As Boolean, Optional ByVal pintPuertoCOM As String = "COM1", Optional ByVal pintPuerto As Integer = 10001, Optional ByVal pstrIP As String = "10.3.3.10")


        On Error Resume Next

        '    Set MSComm1 = Nothing
        '    Set Timer1 = Nothing
        '    Set Winsock1 = Nothing

        If pbolSerial = True Then
            Control.CheckForIllegalCrossThreadCalls = False
            SerialPort2.Encoding = System.Text.Encoding.Default
            SerialPort2.PortName = pintPuertoCOM
            SerialPort2.Open()


        Else
            'Poner el winsock
            '        Set Winsock1 = New Winsock
            '10001 para equipo Titanio WIFI con Adaptador Lantronix,
            ' 4000 si el equipo viene Ethernet de Fabrica
            'Winsock1.Connect(pstrIP, pintPuerto)
            Winsock1.Connect(pstrIP, 10001)
            'If Winsock1.State = 9 Then
            '  mvarDescError = "-1 - Error al conectar al dispositivo."
            '   Exit Sub
            'End If
        End If


        mvarbolSerial = pbolSerial
        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub

    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfDesconectar()

        On Error Resume Next


        If Me.bolSerial = True Then
            SerialPort2.Close()
        Else
            Winsock1.Close()
            '        Set Winsock1 = Nothing
        End If


        '    MSComm1.PortOpen = False
        '    Timer1.Enabled = True

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub

    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfGenerarEvento(ByVal pintTipoRespuesta As eTipoRespuesta, ByVal pstrTag As String)

        On Error Resume Next
        RaiseEvent peRespuesta(pintTipoRespuesta, pstrTag)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub






    'Private Sub Timer1_Timer()
    '    MsgBox("TIMER")
    '    Dim strData As String

    '    On Error Resume Next
    '    If SerialPort2.PortOpen = False Then Exit Sub
    '    strData = SerialPort2.op
    '    If strData = "" Then Exit Sub
    '    '    RaiseEvent peRespuesta(eeLog, strData & vbTab & Len(strData) & vbCrLf)
    '    RaiseEvent peRespuesta(eTipoRespuesta.eeLog, strData)

    '    Call plExtraerTags(strData)

    'End Sub



    Private Sub plExtraerTags(ByVal pstrData As String)

        'Variables de generales
        Dim strData As String
        Static strDataS As String
        Dim lngIPos As Long

        'Variables de posicion de Tags
        Dim lngFirmware As Long
        Dim lngSingleTag12k As Long
        Dim lngSingleTag8k As Long
        Dim lngMultiTag12k As Long
        Dim lngMultiTag8k As Long
        Dim lngSingleTTSTag As Long
        Dim lngWrite As Long

        'Variables para el ReadBlockData
        Dim lngReadBlockData As Long
        Dim lngKillTag As Long
        Dim lngWriteUserData As Long
        Dim lngWriteMemory As Long
        Dim lngUnlockMemory As Long
        Dim lngLockMemory As Long
        Dim lngReadMemory As Long

        Dim strShiftedData As String


        'Obtener los datos del mscomm
        On Error Resume Next
        '    strData = MSComm1.Input
        strData = pstrData
        strDataS = strDataS & strData
        If strData = "" Then Exit Sub



        'Volver a desmenuzar
Regresar:


        '    txtData.SelStart = Len(txtData)
        'DoEvents()
        '    If Not InStr(1, strDataS, "UHF MODULE", vbTextCompare) = 0 Then
        If Not InStr(1, strDataS, "iiAWI", vbTextCompare) = 0 Then
            RaiseEvent peRespuesta(eTipoRespuesta.eeStatusCommand, "UHF MODULE")
            strDataS = ""
            Exit Sub
        End If




        'Verifcar que tipo de etiqueta esta al principio
        lngFirmware = InStr(1, strDataS, lfConvertirHexATxt("170000"))
        lngSingleTag12k = InStr(1, strDataS, lfConvertirHexATxt("162000"))
        lngSingleTag8k = InStr(1, strDataS, lfConvertirHexATxt("122000"))
        lngMultiTag8k = InStr(1, strDataS, lfConvertirHexATxt("12201E"))
        lngMultiTag12k = InStr(1, strDataS, lfConvertirHexATxt("16201E"))
        lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        lngWrite = InStr(1, strDataS, lfConvertirHexATxt("06FF03"))


        lngReadBlockData = InStr(1, strDataS, lfConvertirHexATxt("200D")) - 1
        lngKillTag = InStr(1, strDataS, lfConvertirHexATxt("06FF06"))
        lngWriteUserData = InStr(1, strDataS, lfConvertirHexATxt("06FF0F"))
        lngWriteMemory = InStr(1, strDataS, lfConvertirHexATxt("06FF5F"))
        lngUnlockMemory = InStr(1, strDataS, lfConvertirHexATxt("06FF35"))
        lngLockMemory = InStr(1, strDataS, lfConvertirHexATxt("06FF25"))

        lngReadMemory = InStr(1, strDataS, lfConvertirHexATxt("201D")) - 1


        'estas lineas por si son de otro firmware
        If lngSingleTag12k = 0 Then lngSingleTag12k = InStr(1, strDataS, lfConvertirHexATxt("152000"))
        If lngSingleTag8k = 0 Then lngSingleTag8k = InStr(1, strDataS, lfConvertirHexATxt("112000"))
        If lngMultiTag8k = 0 Then lngMultiTag8k = InStr(1, strDataS, lfConvertirHexATxt("11201E"))
        If lngMultiTag12k = 0 Then lngMultiTag12k = InStr(1, strDataS, lfConvertirHexATxt("15201E"))
        '    If lngSingleTTSTag = 0 Then lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))


        'Ir por la primera etiqueta
        If lngFirmware > 0 Then GoTo gtFirmware
        If lngSingleTag12k > 0 Then GoTo gtSingleTag12k
        If lngSingleTag8k > 0 Then GoTo gtSingleTag8k

        If lngMultiTag12k > 0 And lngMultiTag8k > 0 Then
            If lngMultiTag8k > lngMultiTag12k Then
                GoTo gtMultiTag12k
            Else
                GoTo gtMultiTag8k
            End If
        End If

        If lngMultiTag12k > 0 Then GoTo gtMultiTag12k
        If lngMultiTag8k > 0 Then GoTo gtMultiTag8k
        If lngSingleTTSTag > 0 Then GoTo gtSingleTTSTag
        If lngReadBlockData > 0 Then GoTo gtReadBlockData
        If lngKillTag > 0 Then GoTo gtKillTag
        If lngWriteUserData > 0 Then GoTo gtWriteUserData
        If lngWriteMemory > 0 Then GoTo gtWriteMemory
        If lngUnlockMemory > 0 Then GoTo gtUnlockMemory
        If lngLockMemory > 0 Then GoTo gtLockMemory
        If lngReadMemory > 0 Then GoTo gtReadMemory
        If lngWrite > 0 Then GoTo gtWrite


        If Strings.Right(strDataS, 2) = lfConvertirHexATxt("00FF") Then
            RaiseEvent peRespuesta(eTipoRespuesta.eeStatusCommand, Strings.Right(strDataS, 2))
            strDataS = ""
            Exit Sub
        End If

        If Strings.Right(strDataS, 1) = lfConvertirHexATxt("00") Or Strings.Right(strDataS, 1) = lfConvertirHexATxt("FF") Then
            RaiseEvent peRespuesta(eTipoRespuesta.eeStatusCommand, Strings.Right(strDataS, 1))
        End If
        '    strDataS = ""
        Exit Sub


gtFirmware:
        'Firmware
        '    If InStr(1, lfConvertirTxtAHex(strDataS), "5B34", vbTextCompare) > 0 Then
        If InStr(1, lfConvertirTxtAHex(strDataS), "170000", vbTextCompare) > 0 Then
            lngFirmware = InStr(1, strDataS, lfConvertirHexATxt("170000"), vbTextCompare)
            strData = strDataS
            strData = Mid(strDataS, lngFirmware, CInt("&H17")) 'CInt("&H" & lfConvertirTxtAHex(Left(strData, 1))))

            'verificar si la cadena esta correcta
            If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then Exit Sub
            strData = Strings.Right(strData, Len(strData) - 3)
            strData = Strings.Left(strData, Len(strData) - 2)

            RaiseEvent peRespuesta(eTipoRespuesta.eeFirmware, strData)
            strDataS = ""

        End If

        Exit Sub




gtSingleTag12k:


        lngSingleTag12k = InStr(1, strDataS, lfConvertirHexATxt("162000"))
        If lngSingleTag12k = 0 Then lngSingleTag12k = InStr(1, strDataS, lfConvertirHexATxt("152000"))

        strData = Mid(strDataS, lngSingleTag12k, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTag12k, 1))))
        '    If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then Exit Sub
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTag12k, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngSingleTag12k - 1) + Len(strData)))
        strData = Strings.Right(strData, Len(strData) - 5) '-4
        strData = Strings.Left(strData, 12) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLectura, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub





        Exit Sub


gtSingleTag8k:

        lngSingleTag8k = InStr(1, strDataS, lfConvertirHexATxt("122000"))
        If lngSingleTag8k = 0 Then lngSingleTag8k = InStr(1, strDataS, lfConvertirHexATxt("112000"))

        strData = Mid(strDataS, lngSingleTag8k, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTag8k, 1))))
        '    If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then Exit Sub
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTag8k, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngSingleTag8k - 1) + Len(strData)))
        strData = Strings.Right(strData, Len(strData) - 5) '-4
        strData = Strings.Left(strData, 8) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLectura, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub




gtMultiTag8k:


        lngMultiTag8k = InStr(1, strDataS, lfConvertirHexATxt("12201E"))
        If lngMultiTag8k = 0 Then lngMultiTag8k = InStr(1, strDataS, lfConvertirHexATxt("11201E"))

        strData = Mid(strDataS, lngMultiTag8k, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngMultiTag8k, 1))))
        '    If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then Exit Sub
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngMultiTag8k, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngMultiTag8k - 1) + Len(strData)))
        strData = Strings.Right(strData, Len(strData) - 5)
        strData = Strings.Left(strData, 8) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLectura, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub





gtMultiTag12k:


        lngMultiTag12k = InStr(1, strDataS, lfConvertirHexATxt("16201E"))
        If lngMultiTag12k = 0 Then lngMultiTag12k = InStr(1, strDataS, lfConvertirHexATxt("15201E"))

        strData = Mid(strDataS, lngMultiTag12k, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngMultiTag12k, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngMultiTag12k, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngMultiTag12k - 1) + Len(strData)))
        strData = Strings.Right(strData, Len(strData) - 5)
        strData = Strings.Left(strData, 12) '-5
        '    strData = Left(strData, Len(strData) - 4) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLectura, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub



gtSingleTTSTag:


        lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        If lngSingleTTSTag = 0 Then lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))

        strData = Mid(strDataS, lngSingleTTSTag, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTTSTag, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngSingleTTSTag, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngSingleTTSTag - 1) + Len(strData)))
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, 8) '-5
        '    strData = Left(strData, Len(strData) - 4) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLectura, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub



gtReadBlockData:


        '    lngReadBlockData = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        '    If lngSingleTTSTag = 0 Then lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        lngReadBlockData = lngReadBlockData


        strData = Mid(strDataS, lngReadBlockData, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngReadBlockData, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngReadBlockData, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '    Dim strShiftedData As String
        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngReadBlockData - 1) + Len(strData)))
        '    strData = Right(strData, Len(strData) - 3)
        '    strData = Left(strData, Len(strData) - 2) '-5
        strShiftedData = ShiftData(strData)
        RaiseEvent peRespuesta(eTipoRespuesta.eeReadBlockData, strShiftedData)

        'DoEvents()
        GoTo Regresar
        Exit Sub


gtKillTag:

        lngIPos = lngKillTag

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeKillTag, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub



gtWriteUserData:

        lngIPos = lngWriteUserData

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '06 FF 0F 00 XX XX – Write Success
        '06 FF 0F 10 XX XX or 06 FF 0F FF XX XX – Write Fail
        '06 FF 0F 80 XX XX – WriteTime-Out

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeWriteUserData, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub


gtWriteMemory:

        lngIPos = lngWriteMemory

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '06 FF 0F 00 XX XX – Write Success
        '06 FF 0F 10 XX XX or 06 FF 0F FF XX XX – Write Fail
        '06 FF 0F 80 XX XX – WriteTime-Out

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeWriteMemory, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub




gtUnlockMemory:

        lngIPos = lngUnlockMemory

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '06 FF 0F 00 XX XX – Write Success
        '06 FF 0F 10 XX XX or 06 FF 0F FF XX XX – Write Fail
        '06 FF 0F 80 XX XX – WriteTime-Out

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeUnlockMemory, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub




gtLockMemory:

        lngIPos = lngLockMemory

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '06 FF 0F 00 XX XX – Write Success
        '06 FF 0F 10 XX XX or 06 FF 0F FF XX XX – Write Fail
        '06 FF 0F 80 XX XX – WriteTime-Out

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeLockMemory, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub




gtReadMemory:


        '    lngReadBlockData = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        '    If lngSingleTTSTag = 0 Then lngSingleTTSTag = InStr(1, strDataS, lfConvertirHexATxt("0D110E"))
        lngReadMemory = lngReadMemory


        strData = Mid(strDataS, lngReadMemory, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngReadMemory, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngReadMemory, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If


        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngReadMemory - 1) + Len(strData)))
        '    strData = Right(strData, Len(strData) - 3)
        '    strData = Left(strData, Len(strData) - 2) '-5
        strShiftedData = ShiftData(strData)
        RaiseEvent peRespuesta(eTipoRespuesta.eeReadMemory, strShiftedData)

        'DoEvents()
        GoTo Regresar
        Exit Sub


gtWrite:


        lngIPos = lngWrite

        strData = Mid(strDataS, lngIPos, CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))))
        If Not CRC_16(lfConvertirTxtAHex(strData)) = "FFFF" Then
            'si la longitud del tag es menor del lo que indica el mismo tag, salir para esperar mas datos
            If Len(strData) < CDec("&H" & lfConvertirTxtAHex(Mid(strDataS, lngIPos, 1))) Then Exit Sub
            strDataS = Mid(strDataS, 2)
            GoTo Regresar
            Exit Sub
        End If

        '06 FF 0F 00 XX XX – Write Success
        '06 FF 0F 10 XX XX or 06 FF 0F FF XX XX – Write Fail
        '06 FF 0F 80 XX XX – WriteTime-Out

        strDataS = Strings.Right(strDataS, Len(strDataS) - ((lngIPos - 1) + Len(strData)))
        strData = strData
        strData = Strings.Right(strData, Len(strData) - 3)
        strData = Strings.Left(strData, Len(strData) - 2) '-5
        RaiseEvent peRespuesta(eTipoRespuesta.eeWrite, strData)

        'DoEvents()
        GoTo Regresar
        Exit Sub



    End Sub


    Public Function LShift(ByVal iVariable As Byte, ByVal iNumbits As Integer) As Integer
        LShift = iVariable * (2 ^ iNumbits)
        If LShift > CInt("&HFF") Then LShift = LShift - CInt("&HFF") - 1
    End Function
    Public Function RShift(ByVal iVariable As Integer, ByVal iNumbits As Integer) As Integer
        RShift = iVariable \ (2 ^ iNumbits)
    End Function


    '***********************************************************************************************************
    'Funcion ShiftData en C#
    '***********************************************************************************************************
    '
    '    public static string ShiftData(byte[] rspPkt)
    '    {
    '        if (rspPkt.Length <= 0) return "Empty byte array";
    '        string tmp = "";
    '        int len = (int)rspPkt[0];
    '        if (len = 0) temp = "Nothing to shift with";
    '        Else
    '        {
    '            byte[] outByte = new byte[len - 5];
    '            for ( int i = 0; i < outByte.Length; i++)
    '            {
    '                outByte[i] = rspPkt[i + 3];
    '                outByte[i] = (byte)(outByte[i] << 1);
    '                if ((rspPkt[i + 4] & 0x80) == 0x80) outByte[i] += 1;
    '            }
    '
    '            tmp = BitConverter.ToString(outByte); //tohexstring(outByte ).tostring
    '        }
    '        return tmp;
    '    }

    '***********************************************************************************************************
    'Funcion ShiftData en VB&
    '***********************************************************************************************************
    Public Function ShiftData(ByVal pstrByte As String) As String

        Dim strByte() As Byte
        Dim outByte() As Byte
        Dim i As Integer
        Dim strTemp As String
        Dim intLen As Integer


        If pstrByte = "" Then
            ShiftData = ""
            Exit Function
        End If

        ReDim strByte(Len(pstrByte) - 1)

        For i = 0 To Len(pstrByte) - 1
            strByte(i) = Asc(Mid(pstrByte, i + 1, 1))
        Next


        intLen = strByte(0)
        If intLen = 0 Then
            ShiftData = ""
            Exit Function
        End If
        ReDim outByte(intLen - 5)

        For i = 0 To UBound(outByte)
            'outByte[i] = rspPkt[i + 3];
            outByte(i) = strByte(i + 3)
            'outByte[i] = (byte)(outByte[i] << 1);
            outByte(i) = LShift(strByte(i + 3), 1)
            'if ((rspPkt[i + 4] & 0x80) == 0x80) outByte[i] += 1;
            If (strByte(i + 4)) >= CInt("&H80") Then outByte(i) = outByte(i) + 1
        Next


        'Convertir a cadena de caracteres ascii
        strTemp = ""
        For i = 0 To UBound(outByte) - 2
            strTemp = strTemp & Chr(outByte(i))
        Next

        'Regresar la cadena
        ShiftData = strTemp
    End Function

    Private Sub UserControl_Terminate()
        ' timer1.Enabled = False
    End Sub

    '  Private Sub UserControl_WriteProperties(ByVal PropBag As PropertyBag)
    '    MsgBox "Hola"
    'End Sub

    '**********************************************************************************************
    'Funcion para grabar un solo tag
    '**********************************************************************************************
    '' '' '' '' '' '' '' '' '' ''Public Sub pfWriteID(ByVal pbolLongSize As Boolean, ByVal pstrTag As String)
    '' '' '' '' '' '' '' '' '' ''    '     MsgBox("WRITE ID")
    '' '' '' '' '' '' '' '' '' ''    Dim sum As String
    '' '' '' '' '' '' '' '' '' ''    Dim enviar As String
    '' '' '' '' '' '' '' '' '' ''    '    Dim y As Long
    '' '' '' '' '' '' '' '' '' ''    '    Dim num As String
    '' '' '' '' '' '' '' '' '' ''    Dim hex2ascii As String



    '' '' '' '' '' '' '' '' '' ''    On Error Resume Next

    '' '' '' '' '' '' '' '' '' ''    'preparar las cadenas para el tamaño que tendra el tag
    '' '' '' '' '' '' '' '' '' ''    If pbolLongSize = False Then
    '' '' '' '' '' '' '' '' '' ''         pstrTag = pstrTag & String(8, Chr(0))
    '' '' '' '' '' '' '' '' '' ''        pstrTag = Left(pstrTag, 8)
    '' '' '' '' '' '' '' '' '' ''        pstrTag = lfConvertirTxtAHex(pstrTag)


    '' '' '' '' '' '' '' '' '' ''        sum = CRC_16("0E2003" & pstrTag & "00")
    '' '' '' '' '' '' '' '' '' ''        '        sum = CRC_16("0E2003")
    '' '' '' '' '' '' '' '' '' ''        enviar = "0E2003" & pstrTag & "00" & sum 'indicar que repita FF veces o hasta que se grabe correctamente
    '' '' '' '' '' '' '' '' '' ''    Else
    '' '' '' '' '' '' '' '' '' ''        pstrTag = pstrTag & String(12, Chr(0))
    '' '' '' '' '' '' '' '' '' ''        pstrTag = Left(pstrTag, 12)
    '' '' '' '' '' '' '' '' '' ''        pstrTag = lfConvertirTxtAHex(pstrTag)

    '' '' '' '' '' '' '' '' '' ''        sum = CRC_16("122003" & pstrTag & "00")
    '' '' '' '' '' '' '' '' '' ''        '        sum = CRC_16("122003")
    '' '' '' '' '' '' '' '' '' ''        enviar = "122003" & pstrTag & "00" & sum 'indicar que repita FF veces o hasta que se grabe correctamente
    '' '' '' '' '' '' '' '' '' ''    End If

    '' '' '' '' '' '' '' '' '' ''    Me.RBDMemoryBankID(4)


    '' '' '' '' '' '' '' '' '' ''    'Enviar la señal de lectura
    '' '' '' '' '' '' '' '' '' ''    hex2ascii = lfConvertirHexATxt(enviar)
    '' '' '' '' '' '' '' '' '' ''    '    bolEscritura = True
    '' '' '' '' '' '' '' '' '' ''    '    MSComm1.Output = hex2ascii
    '' '' '' '' '' '' '' '' '' ''    Call lfEnviarComando(hex2ascii)


    '' '' '' '' '' '' '' '' '' ''    DescError("")
    '' '' '' '' '' '' '' '' '' ''    If Err.Number = 0 Then Exit Sub
    '' '' '' '' '' '' '' '' '' ''    DescError(Err.Number & " - " & Err.Description)


    '' '' '' '' '' '' '' '' '' ''End Sub



    '**********************************************************************************************
    'Funcion para habilitar la lectura de un solo tag
    '**********************************************************************************************
    Public Sub pfReadBlockData(ByVal pMemoryBankID As Integer)
        '    MsgBox("READ BLOCK DATA")
        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String
        '  Dim strBankID As String


        On Error Resume Next


        'Crear la señal para activar la lectura
        '08201D020009 + crc

        Select Case pMemoryBankID
            Case 0 : strBankID = "00"
            Case 1 : strBankID = "01"
            Case 2 : strBankID = "02"
            Case 3 : strBankID = "03"
        End Select

        Me.RBDMemoryBankID(pMemoryBankID)
        'Me.RBDMemoryBankID = pMemoryBankID

        'read block data (0x0D)
        '06200D + MemoryBankID (2B) + CRC

        sum = CRC_16("06200D" & strBankID)
        enviar = "06200D" & strBankID & sum
        hex2ascii = lfConvertirHexATxt(enviar)


        '    sum = CRC_16("052000")
        '    enviar = "052000" + sum
        '    hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)


    End Sub

    '**********************************************************************************************
    'Funcion para habilitar la lectura de un solo tag
    '**********************************************************************************************
    Public Sub pfReadMemory(ByVal pMemoryBankID As Integer, ByVal pWordAddress As Integer, ByVal pWordCount As Integer)
        '   MsgBox("READ MEMORY")
        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String
        '     Dim strBankID As String
        Dim strWordAddresH As String
        Dim strWordCountH As String

        On Error Resume Next


        'ReadMemory (0x1D)
        '08201D 02 00 09 + crc
        '08201D + MemoryBank + WordAddress + WordCount + CRC

        Select Case pMemoryBankID
            Case 0 : strBankID = "00"
            Case 1 : strBankID = "01"
            Case 2 : strBankID = "02"
            Case 3 : strBankID = "03"
        End Select

        Me.RBDMemoryBankID(pMemoryBankID)


        strWordAddresH = gfASCII2Hex(Chr(pWordAddress))
        strWordCountH = gfASCII2Hex(Chr(pWordCount))


        sum = CRC_16("08201D" & strBankID & strWordAddresH & strWordCountH)
        enviar = "08201D" & strBankID & strWordAddresH & strWordCountH & sum
        hex2ascii = lfConvertirHexATxt(enviar)

        'Enviar la señal de lectura
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)


    End Sub


    Public Sub pfWriteID(ByVal pbolLongSize As Boolean, ByVal pstrTag As String)

        Dim sum As String
        Dim enviar As String
        '    Dim y As Long
        '    Dim num As String
        Dim hex2ascii As String



        On Error Resume Next

        'preparar las cadenas para el tamaño que tendra el tag
        If pbolLongSize = False Then
            pstrTag = pstrTag & New String(Chr(0), 8)
            pstrTag = Strings.Left(pstrTag, 8)
            pstrTag = lfConvertirTxtAHex(pstrTag)


            sum = CRC_16("0E2003" & pstrTag & "00")
            '        sum = CRC_16("0E2003")
            enviar = "0E2003" & pstrTag & "00" & sum 'indicar que repita FF veces o hasta que se grabe correctamente
        Else
            pstrTag = pstrTag & New String(Chr(0), 12)
            pstrTag = Strings.Left(pstrTag, 12)
            pstrTag = lfConvertirTxtAHex(pstrTag)

            sum = CRC_16("122003" & pstrTag & "00")
            '        sum = CRC_16("122003")
            enviar = "122003" & pstrTag & "00" & sum 'indicar que repita FF veces o hasta que se grabe correctamente
        End If

        RBDMemoryBankID(4)


        'Enviar la señal de lectura
        hex2ascii = lfConvertirHexATxt(enviar)
        '    bolEscritura = True
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)


    End Sub


    '**********************************************************************************************
    'Funcion para grabar un solo tag
    '**********************************************************************************************
    Public Sub pfWriteUserData(ByVal pstrUserData As String)

        Dim sum As String
        Dim enviar As String
        '    Dim y As Long
        '    Dim num As String
        Dim hex2ascii As String



        On Error Resume Next
        If pstrUserData = "" Then Exit Sub

        Dim strNN As String
        Dim strCommand As String
        Dim strWordID As String
        Dim strDataWords As String
        Dim strTryTimes As String
        Dim strCRC As String


        strNN = "00"
        strCommand = "200F"
        strWordID = "00"
        strDataWords = lfConvertirTxtAHex(pstrUserData)
        strTryTimes = "00"
        strCRC = "0000"

        sum = strNN & strCommand & strWordID & strDataWords & strTryTimes & strCRC
        strNN = lfConvertirTxtAHex(Chr(Len(sum) / 2))
        enviar = strNN & strCommand & strWordID & strDataWords & strTryTimes
        sum = CRC_16(enviar)
        enviar = enviar & sum

        'Enviar la señal de lectura
        hex2ascii = lfConvertirHexATxt(enviar)
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub


    '**********************************************************************************************
    'Funcion para grabar un solo tag
    '**********************************************************************************************
    Public Sub pfWriteMemory(ByVal pMemoryBankID As Integer, ByVal pstrUserData As String)

        Dim sum As String
        Dim enviar As String
        '    Dim y As Long
        '    Dim num As String
        Dim hex2ascii As String



        On Error Resume Next
        If pstrUserData = "" Then Exit Sub

        Dim strNN As String
        Dim strCommand As String
        Dim strWordID As String
        Dim strWordCount As String
        Dim strDataWords As String
        Dim strTryTimes As String
        Dim strCRC As String

        Select Case pMemoryBankID
            Case 0 : strBankID = "00"
            Case 1 : strBankID = "01"
            Case 2 : strBankID = "02"
            Case 3 : strBankID = "03"
        End Select

        Me.RBDMemoryBankID(pMemoryBankID)

        'NN 20 5F MemoryBank
        'WordID WordCount
        'DataWords TryTimes
        'xx xx

        'si los datos no son multiplos de dos agregar un character nulo
        If Not Len(pstrUserData) Mod 2 = 0 Then pstrUserData = pstrUserData & Chr(0)

        strNN = "00"
        strCommand = "205F"
        strBankID = strBankID
        strWordID = "00"
        strWordCount = lfConvertirTxtAHex(Chr(Len(pstrUserData) / 2)) '"00"   '16 bit words
        strDataWords = lfConvertirTxtAHex(pstrUserData) '16 bit words
        strTryTimes = "00"
        strCRC = "0000"

        sum = strNN & strCommand & strBankID & strWordID & strWordCount & strDataWords & strTryTimes & strCRC
        strNN = lfConvertirTxtAHex(Chr(Len(sum) / 2))
        enviar = strNN & strCommand & strBankID & strWordID & strWordCount & strDataWords & strTryTimes
        sum = CRC_16(enviar)
        enviar = enviar & sum

        'Enviar la señal de lectura
        hex2ascii = lfConvertirHexATxt(enviar)
        '    MSComm1.Output = hex2ascii
        Call lfEnviarComando(hex2ascii)

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub



    '**********************************************************************************************
    'Funcion para grabar un solo tag
    '**********************************************************************************************




    '***********************************************************************************************************************
    'Funcion que envia el comando indicado ya sea al Winsock o al MSComm, dependiendo de a que control
    'esta conectado
    '***********************************************************************************************************************
    Private Sub lfEnviarComando(ByVal pstrComando As String)


        On Error Resume Next
        Dim btData() As Byte

        If mvarbolSerial = True Then
            'btData = gfHex2ByteArray(pstrComando)
            'enviar el comando 
            'SerialPort2.Write(btData, 0, btData.Length)
            SerialPort2.Write(pstrComando)
        Else
            Winsock1.SendData(pstrComando)
        End If


        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub

    Public Function gfHex2ByteArray(ByVal pstrHexString As String) As Byte()

        Dim btData(0) As Byte
        Dim i As Integer
        Dim sTemp As String
        Dim sHexTemp As String
        Dim sHexChar As String

        sHexTemp = pstrHexString
        sTemp = ""
        i = 0
        'ReDim btData(i)

        While Not sHexTemp = ""
            ReDim Preserve btData(i)
            sHexChar = Strings.Left(sHexTemp, 2)
            sHexTemp = Mid(sHexTemp, 3)
            btData(i) = CInt("&H" & sHexChar)
            i += 1
        End While

        Return btData

    End Function

    'Private Sub Winsock1_Error(ByVal Number As Integer, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, CancelDisplay As Boolean)
    '    MsgBox Description, vbCritical, Number
    'End Sub



    '**********************************************************************************************
    'Funcion para leer el firmware
    '**********************************************************************************************
    Public Sub pfRelevador(ByVal pbolActivar As Boolean)

        Dim sum As String
        Dim enviar As String
        Dim hex2ascii As String

        On Error Resume Next

        'Enviar la señal de lectura
        If pbolActivar = True Then
            Call lfEnviarComando("#OA#")
        Else
            Call lfEnviarComando("#CA#")
        End If

        DescError("")
        If Err.Number = 0 Then Exit Sub
        DescError(Err.Number & " - " & Err.Description)

    End Sub

    Public Function pfStatus() As Integer
        '''''  pfStatus = winsock1.State
    End Function


    Public Function gfASCII2Hex(ByVal pstrASCII As String, Optional ByVal pCharSep As String = "") As String

        Dim i As Integer
        Dim sChar As String
        Dim sTemp As String
        Dim sResu As String = ""

        For i = 0 To Len(pstrASCII) - 1
            sChar = Mid(pstrASCII, i + 1, 1)
            '            sChar = pstrASCII.Chars(i)
            sTemp = "0" & Hex(Asc(sChar))
            sTemp = Strings.Right(sTemp, 2) & pCharSep
            sResu = sResu + sTemp
            'sResu = "TAG001"
        Next

        gfASCII2Hex = sResu

    End Function


    Private Sub Winsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles Winsock1.DataArrival
        Dim strData As String = ""
        On Error Resume Next
        'Obtener los datos y procesarlos
        Call Winsock1.GetData(strData)
        If strData = "" Then Exit Sub

        'Ejecutar evento de log
        'RaiseEvent peRespuesta(eTipoRespuesta.eeLog, strData)
        'Revisar los datos
        Call plExtraerTags(strData)
    End Sub

    Private Sub SerialPort2_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        Dim sData As String
        Try
            sData = SerialPort2.ReadExisting()
            If sData = "" Then Exit Sub
            Call plExtraerTags(sData)
        Catch ex As Exception
        End Try
    End Sub

End Class

