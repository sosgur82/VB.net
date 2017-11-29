Public Class Student
    Public strName As String
    Public strKor As String
    Public strMath As String
    Public strEng As String
    Public sngAver As Single

    Public Sub New(name As String, kor As String, math As String, Eng As String)
        strName = name
        strKor = kor
        strMath = math
        strEng = Eng
        sngAver = 0.0
    End Sub

    Public Function GradeToScore(grade As String) As Single
        Select Case grade
            Case "A+"
                GradeToScore = 4.5
            Case "A"
                GradeToScore = 4.0
            Case "B+"
                GradeToScore = 3.5
            Case "B"
                GradeToScore = 3.0
            Case "C+"
                GradeToScore = 2.5
            Case "C"
                GradeToScore = 2.0
            Case "D+"
                GradeToScore = 1.5
            Case "D"
                GradeToScore = 1.0
            Case "F"
                GradeToScore = 0
            Case Else
                Console.WriteLine("정확한 학점이 아닙니다.")
                GradeToScore = 0
        End Select
    End Function

    Public Sub CalcScore()
        sngAver = (GradeToScore(strKor) + GradeToScore(strMath) + GradeToScore(strEng)) / 3
    End Sub

    Public Sub PrintScore()
        CalcScore()
        Console.WriteLine()
        Console.WriteLine("이름 : {0}", strName)
        Console.WriteLine("국어 : {0}", strKor)
        Console.WriteLine("수학 : {0}", strMath)
        Console.WriteLine("영어 : {0}", strEng)
        Console.WriteLine("평균 학점 : {0}", sngAver)
    End Sub

End Class