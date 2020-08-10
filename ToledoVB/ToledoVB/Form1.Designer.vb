<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Inicio = New System.Windows.Forms.Button()
        Me.Parar = New System.Windows.Forms.Button()
        Me.transferir = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Saida_Tela = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inicio
        '
        Me.Inicio.Location = New System.Drawing.Point(151, 3)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(75, 23)
        Me.Inicio.TabIndex = 1
        Me.Inicio.Text = "Inicio"
        Me.Inicio.UseVisualStyleBackColor = True
        '
        'Parar
        '
        Me.Parar.Location = New System.Drawing.Point(313, 3)
        Me.Parar.Name = "Parar"
        Me.Parar.Size = New System.Drawing.Size(75, 23)
        Me.Parar.TabIndex = 2
        Me.Parar.Text = "Parar"
        Me.Parar.UseVisualStyleBackColor = True
        '
        'transferir
        '
        Me.transferir.Location = New System.Drawing.Point(181, 105)
        Me.transferir.Name = "transferir"
        Me.transferir.Size = New System.Drawing.Size(186, 37)
        Me.transferir.TabIndex = 6
        Me.transferir.Text = "Transferir"
        Me.transferir.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(145, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 40)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Peso"
        '
        'Saida_Tela
        '
        Me.Saida_Tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saida_Tela.Location = New System.Drawing.Point(237, 51)
        Me.Saida_Tela.Name = "Saida_Tela"
        Me.Saida_Tela.Size = New System.Drawing.Size(160, 40)
        Me.Saida_Tela.TabIndex = 8
        Me.Saida_Tela.Text = "Sem Leitura"
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 4800
        Me.SerialPort1.PortName = "COM14"
        Me.SerialPort1.RtsEnable = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 153)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(550, 243)
        Me.TextBox1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Inicio)
        Me.Panel1.Controls.Add(Me.Parar)
        Me.Panel1.Controls.Add(Me.Saida_Tela)
        Me.Panel1.Controls.Add(Me.transferir)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 153)
        Me.Panel1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 396)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Inicio As Button
    Private WithEvents Parar As Button
    Private WithEvents transferir As Button
    Private WithEvents label1 As Label
    Private WithEvents Saida_Tela As Label
    Private WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
