Public Class StudentClass

    Public strStudentName As String
    Public intMathScore As Integer
    Public intEngScore As Integer

    Public Sub New()
        strStudentName = ""
        intMathScore = 0
        intEngScore = 0
    End Sub

    Public Sub New(ByVal strName As String, ByVal intMScore As Integer, ByVal intEScore As Integer)
        strStudentName = strName
        intMathScore = intMScore
        intEngScore = intEScore
    End Sub

    Public Overridable Sub PrintScore()
        Console.WriteLine("{0} 학생", strStudentName)
        Console.WriteLine("수학점수 = {0}", intMathScore)
        Console.WriteLine("영어 점수 = {0}", intEngScore)
        Console.WriteLine()
    End Sub

End Class

Public Class StudentAverage
    Inherits StudentClass

    Public dblAverageScore As Double

    Public Sub New()
        strStudentName = ""
        intMathScore = 0
        intEngScore = 0
        dblAverageScore = 0
    End Sub

    Public Sub New(ByVal strName As String, ByVal intMScore As Integer, intEScore As Integer)

        strStudentName = strName
        intMathScore = intMScore
        intEngScore = intEScore
        dblAverageScore = (intMathScore + intEScore) / 2

    End Sub

    Public Overrides Sub PrintScore()
        Console.WriteLine("{0} 학생", strStudentName)
        Console.WriteLine("수학점수 = {0}", intMathScore)
        Console.WriteLine("영어 점수 = {0}", intEngScore)
        Console.WriteLine("평균 점수 = {0}", dblAverageScore)
        Console.WriteLine()
    End Sub

End Class
