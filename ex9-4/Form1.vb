Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.ImageIndex = 0 Then
            Button1.ImageIndex = 1
            Button1.Text = "컨텐더2"
        Else
            Button1.ImageIndex = 0
            Button1.Text = "컨텐더1"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "이미지 버튼 프로그램"
    End Sub
End Class
