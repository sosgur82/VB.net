Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "비밀번호 입력 프로그램"
        Label1.Text = "UserName"
        Label2.Text = "PassWord"
        Label1.AutoSize = True
        Label2.AutoSize = True
        TextBox2.PasswordChar = "*"
        Button1.Text = "Login"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "john" Then
            If TextBox2.Text = "john" Then
                MsgBox("암호가 일치합니다.", MsgBoxStyle.OkOnly, "암호 일치")
            Else
                MsgBox("암호가 일치하지 않습니다.", MsgBoxStyle.OkOnly, "암호 불일치")
            End If
        ElseIf TextBox1.Text = "jane" Then
            If TextBox2.Text = "jane" Then
                MsgBox("암호가 일치합니다.", MsgBoxStyle.OkOnly, "암호 일치")
            Else
                MsgBox("암호가 일치하지 않습니다.", MsgBoxStyle.OkOnly, "암호 불일치")
            End If
        Else
            MsgBox("등록되지 않은 사용자입니다.", MsgBoxStyle.OkOnly, "등록확인")
        End If
    End Sub
End Class
