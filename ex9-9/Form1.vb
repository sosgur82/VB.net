Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "계산기 프로그램"
        Label1.Text = "?"
        Label2.Text = "="
        Button1.Text = "+"
        Button2.Text = "-"
        Button3.Text = "*"
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox3.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intResult As Integer
        Label1.Text = "+"
        intResult = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = intResult
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intResult As Integer
        Label1.Text = "-"
        intResult = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = intResult
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intResult As Integer
        Label1.Text = "*"
        intResult = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = intResult
    End Sub
End Class
