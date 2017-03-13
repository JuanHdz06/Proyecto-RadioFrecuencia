Public Class vusuario
    Dim id_usuario As Integer
    Dim nombre, password, usuario As String


    Public Property gidusuario
        Get
            Return id_usuario
        End Get
        Set(ByVal value)
            id_usuario = value
        End Set
    End Property
    Public Property gusuario
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Property gdtipo
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(ByVal id_usuario As Integer, ByVal nombre As String, ByVal usuario As String, ByVal password As String)
        gidusuario = id_usuario
        gusuario = nombre
        gpassword = password
        gdtipo = usuario


    End Sub
End Class
