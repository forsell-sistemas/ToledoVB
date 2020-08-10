Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Configuration

Public Class Form1
    Private RxString As String
    Dim count As Integer
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        SerialPort1.Open()
        MsgBox("porta abriu")
        If SerialPort1.IsOpen Then
            Inicio.Enabled = False
            Parar.Enabled = True
            transferir.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLer_Click()

        SerialPort1 = New SerialPort
        SerialPort1.BaudRate = 4800
        SerialPort1.PortName = "COM14"
        SerialPort1.RtsEnable = True

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Inicio.Enabled = True
            Parar.Enabled = False
        End If

        SerialPort1.PortName = ConfigurationManager.AppSettings("PortaSerial")
        SerialPort1.BaudRate = 4800
        SerialPort1.DataBits = 8
        SerialPort1.DtrEnable = True
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 7
        SerialPort1.NewLine = Environment.NewLine
        SerialPort1.ReadTimeout = 500
        SerialPort1.WriteTimeout = 500
        MsgBox("Load")
        count = 0
    End Sub

    Private Sub btnLer_Click()



        Dim fluxoTexto As IO.StreamReader

        Dim linhaTexto As String
        Dim caminho As String = "D:\source\TOLEDOVB\TOLEDO_STRING_PESO.txt"


        If IO.File.Exists(caminho) Then

            fluxoTexto = New IO.StreamReader(caminho)

            linhaTexto = fluxoTexto.ReadLine

            Dim status As String = String.Empty

            While linhaTexto <> Nothing
                If Len(linhaTexto.Trim) > 1 Then
                    If linhaTexto.Contains(ChrW(2)) Then
                        linhaTexto = linhaTexto.Replace(ChrW(2), "@")
                        If Len(linhaTexto) > 4 Then
                            status = "INSTÁVEL: "
                            If Mid(linhaTexto.Replace(ChrW(2), "@"), 3, 1) = "0" Then status = "ESTÁVEL: "
                            linhaTexto = linhaTexto.Remove(0, 4)
                            If Len(linhaTexto) > 6 Then
                                linhaTexto = linhaTexto.Remove(6).Replace(" ", "0")
                                TextBox1.Text += status & linhaTexto & vbCrLf
                            End If
                        End If
                    End If
                End If
                linhaTexto = fluxoTexto.ReadLine
            End While

            fluxoTexto.Close()

        Else

            MessageBox.Show("Arquivo não existe")

        End If

    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim peso As String = SerialPort1.ReadExisting()
        Dim status As String = "INSTÁVEL: "
        If Len(peso.Trim) > 1 Then
            If peso.Contains(ChrW(2)) Then
                peso = peso.Replace(ChrW(2), "@")
                If Len(peso) > 4 Then
                    If Mid(peso.Replace(ChrW(2), "@"), 3, 1) = "0" Then status = "ESTÁVEL: "
                    peso = peso.Remove(0, 4)
                    If Len(peso) > 6 Then
                        peso = peso.Remove(6).Replace(" ", "0")
                        TextBox1.Text += status & peso & vbCrLf
                        Saida_Tela.Text = peso
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Parar_Click(sender As Object, e As EventArgs) Handles Parar.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Inicio.Enabled = True
            Parar.Enabled = False
            transferir.Enabled = False
            Saida_Tela.Text = "Sem Leitura"
        End If
    End Sub

    'Private Sub Saida_Tela_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Saida_Tela.TextChanged
    '    If Not SerialPort1.IsOpen Then Return
    '    Dim buff As Char() = New Char(0) {}
    '    buff(0) = e.KeyChar
    '    SerialPort1.Write(buff, 0, 1)
    '    e.Handled = True
    'End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub transferir_Click(sender As Object, e As EventArgs) Handles transferir.Click
        'Dim currentProcess As Process = Process.GetCurrentProcess()
        'Dim processes As Process() = Process.GetProcessesByName("saplogon")

        'For Each p As Process In processes
        '    Dim pFoundWindow As IntPtr = p.MainWindowHandle
        '    SetForegroundWindow(pFoundWindow)
        '    SendKeys.SendWait(RxString)
        'Next
    End Sub
End Class
