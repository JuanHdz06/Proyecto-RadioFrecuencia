Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim dts As New vusuario
            Dim dts2 As New vusuario
            Dim funciones As New fusuario

            dts.gusuario = txtUsuario.Text
            dts.gpassword = txtContrasenia.Text
            dts.gdtipo = "1"

            dts2.gusuario = txtUsuario.Text
            dts2.gpassword = txtContrasenia.Text
            dts2.gdtipo = "2"


            If funciones.validarusuario(dts) = True Then

                MessageBox.Show("Bienvenido: " + txtUsuario.Text, "Usuario Valido")
                Dim fr As New Principal

                Me.Hide()
                fr.Show()

            ElseIf funciones.validarusuario(dts2) = True Then
                MessageBox.Show("Bienvenido: " + txtUsuario.Text, "Usuario Valido")
                Dim fr2 As New Principal


                Me.Hide()
                fr2.Show()
                fr2.MetroTabPage2.Dispose()
                fr2.MetroTabPage7.Dispose()
                fr2.MetroTabPage3.Dispose()
                fr2.Button6.Visible = False
                fr2.Button7.Visible = False
                fr2.Button8.Visible = False

            Else
                MessageBox.Show("Datos Incorrectos", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.txtUsuario.Clear()
                Me.txtContrasenia.Clear()
                Me.txtUsuario.Focus()

            End If
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
