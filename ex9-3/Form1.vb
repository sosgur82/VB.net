Public Class Form1
    Public intNumver As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intNumver = intNumver + 1
        Me.Text = Str(intNumver) + "번 클릭"
        Button1.Text = intNumver
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intNumver = 0
        Me.Text = Str(intNumver) + "번 클릭"
        Button1.Text = Str(intNumver) + "번 클릭"
    End Sub
End Class
