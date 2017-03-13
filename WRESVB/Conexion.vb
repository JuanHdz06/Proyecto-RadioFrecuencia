Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Conexion
    Protected cnn As New SqlConnection 'creamos una variable para establecer la conexion con la base de datos
    'creamos la funcion para conectar con la base de datos
    'Public id_estante As Integer
    Protected Function conectado()
        Try
            'creamos la cadena de conexion
            ' cnn = New SqlConnection("data source=67.222.152.190,6555;initial catalog=RADIOFRECUENCIA;integrated security=true")
            cnn = New SqlConnection("Data Source=DESKTOP-GSP43FD;Initial Catalog=Radiofrecuency; Integrated security=True;")

            'abrimos la conexion
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'creamos la funcion para desconectar con la base de datos
    Protected Function desconectado()
        Try
            'si la conexion esta abierta entonces la cerramos
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                'en caso contrario esta cerrada entonces no hacemos nada
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
