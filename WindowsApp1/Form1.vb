Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Url_MouseEnter(sender As Object, e As EventArgs) Handles url.MouseEnter
        If url.Text = "Insert URL address here" Then
            url.Text = ""
        End If

    End Sub

    Private Sub Url_MouseLeave(sender As Object, e As EventArgs) Handles url.MouseLeave
        If url.Text = "" Then
            url.Text = "Insert URL address here"
            url.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub Url_KeyDown(sender As Object, e As KeyEventArgs) Handles url.KeyDown
        If url.Text = "Insert URL address here" Then
            url.Text = ""
        End If
        url.ForeColor = Color.FromArgb(0, 192, 192)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim cd As String = My.Computer.FileSystem.CurrentDirectory
        If url.Text = "" Or url.Text = "Insert URL address here" Then
            MsgBox("URL link can't be blank")
            Exit Sub
        End If
        Process.Start("cmd", "/k " + "color 4a & title YTB downloader by Marchiz &" + "cd " + cd + "& youtube-dl " + url.Text)
        url.Text = "Insert URL address here"
        url.ForeColor = Color.Gray
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnExit.BackColor = Color.Transparent
    End Sub

End Class
