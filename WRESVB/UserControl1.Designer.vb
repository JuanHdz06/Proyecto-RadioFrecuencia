<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.Winsock1 = New AxMSWinsockLib.AxWinsock
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Winsock1
        '
        Me.Winsock1.Enabled = True
        Me.Winsock1.Location = New System.Drawing.Point(40, 35)
        Me.Winsock1.Name = "Winsock1"
        Me.Winsock1.OcxState = CType(resources.GetObject("Winsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock1.Size = New System.Drawing.Size(28, 28)
        Me.Winsock1.TabIndex = 0
        '
        'SerialPort2
        '
        Me.SerialPort2.DtrEnable = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Winsock1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(217, 139)
        CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Winsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort

End Class
