Public Class StudentClass

    Public strStudentName As String
    Public intMathScore As Integer
    Public intEngScore As Integer
    Public dblAverageScore As Double

    Public Sub Calc_Average()

        dblAverageScore = (intMathScore + intEngScore) / 2
    End Sub

    Public Sub Print_Score()
        Console.WriteLine("{0} 학생", strStudentName)
        Console.WriteLine("수학점수 = {0}", intMathScore)
        Console.WriteLine("영어 점수 = {0}", intEngScore)
        Console.WriteLine("평균 점수 = {0}", dblAverageScore)
        Console.WriteLine()
    End Sub
End Class
