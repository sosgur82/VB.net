Public Class Form1
    Public intFontSize As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "폰트 크기 조절"
        Button1.Text = "크기 증가"
        Button2.Text = "크기 감소"
        intFontSize = 10
        Label1.AutoSize = True
        Dim changeFont As New Font("굴림", intFontSize, FontStyle.Regular)
        Label1.Font = changeFont
        Label1.Text = "폰트크기" + Str(intFontSize)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If intFontSize < 30 Then
            intFontSize += 1
            Dim changeFont As New Font("굴림", intFontSize, FontStyle.Regular)
            Label1.Font = changeFont
            Label1.Text = "폰트 크기" + Str(intFontSize)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If intFontSize > 10 Then
            intFontSize -= 1
            Dim changeFont As New Font("굴림", intFontSize, FontStyle.Regular)
            Label1.Font = changeFont
            Label1.Text = "폰트 크기" + Str(intFontSize)
        End If
    End Sub
End Class
