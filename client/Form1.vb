Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "config.txt"
        Dim ip As String = ""
        Dim port As String = ""
        For Each line As String In File.ReadAllLines(filePath)
            If line.StartsWith("IP=") Then
                ip = line.Substring(3)
            ElseIf line.StartsWith("Port=") Then
                port = line.Substring(5)
            End If
        Next

        Dim url As String = "http://" & ip & ":" & port & "/"
        WebBrowser1.Navigate(url)
    End Sub
    Dim browserHistory As New List(Of String)

    ' Add URLs to history when navigating
    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        Dim currentUrl As String = WebBrowser1.Url.ToString()
        Dim uriObj As New Uri(currentUrl)

        ' Store full URL for navigation
        browserHistory.Add(currentUrl)

        ' Show only the folder path in the history list
        Dim displayUrl As String = uriObj.AbsolutePath
        lstHistory.Items.Add(displayUrl)
    End Sub

    ' Handle double‑click on history item
    Private Sub lstHistory_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstHistory.MouseDoubleClick
        If lstHistory.SelectedIndex <> -1 Then
            ' Get full URL from history list
            Dim fullUrl As String = browserHistory(lstHistory.SelectedIndex)
            WebBrowser1.Navigate(fullUrl)
        End If
    End Sub

    ' Track progress while page loads
    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) _
    Handles WebBrowser1.ProgressChanged

        Try
            If e.MaximumProgress > 0 Then
                Dim progress As Integer = CInt((e.CurrentProgress * 100) / e.MaximumProgress)
                If progress >= ProgressBar1.Minimum And progress <= ProgressBar1.Maximum Then
                    ProgressBar1.Value = progress
                End If
            End If
        Catch ex As Exception
            ' Ignore errors if progress goes out of range
        End Try
    End Sub

    ' When page finishes loading
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) _
    Handles WebBrowser1.DocumentCompleted

        ' Show 100% first
        ProgressBar1.Value = ProgressBar1.Maximum

        ' Start timer to reset back to 0%
        Timer1.Start()
    End Sub

    ' Timer tick resets the ProgressBar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 0
        Timer1.Stop()
    End Sub
End Class
