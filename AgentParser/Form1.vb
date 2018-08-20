
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)



    End Sub

    Private Sub AgentButton_Click(sender As Object, e As EventArgs) Handles AgentButton.Click

        If OpenFileDialogAgentResult.ShowDialog = DialogResult.OK Then
            Dim path As String = OpenFileDialogAgentResult.FileName
            AgentText.Text = path
            Try
                Dim length As String = File.ReadAllText(path)
                Dim jobsid As New List(Of String)()
                For Each i As Match In Regex.Matches(length, "[JobId]+[:][[:space:]][0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}")
                    jobsid.Add(i.Value)
                Next
            Catch ex As Exception

            End Try

        End If



    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click

        If OpenFileDialogAgentResult.ShowDialog = DialogResult.OK Then
            Dim path As String = OpenFileDialogAgentResult.FileName
            ResultText.Text = path
            Try
                Dim length As String = File.ReadAllText(path)

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click





    End Sub
End Class
