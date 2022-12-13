Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sentence As String = sentence_1.Text
        Dim word As String = sentence_2.Text
        sentence = sentence.Replace("___", word)
        resultss.Text = sentence
    End Sub
End Class
