Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "명령어 버튼 프로그램"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static intNumber As Integer
        Button1.Text = intNumber
        intNumber = intNumber + 1
    End Sub
End Class
