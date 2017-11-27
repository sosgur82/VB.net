Module Module1

    Sub Main()
        Dim clsStudent(2) As StudentClass
        Dim tmpStudent As New StudentClass
        Dim intCount As Integer

        For intCount = 0 To 2
            clsStudent(intCount) = New StudentClass()
        Next
        clsStudent(0).strStudentName = "홍길동"
        clsStudent(0).intMathScore = 90
        clsStudent(0).intEngScore = 85

        clsStudent(1).strStudentName = "김동수"
        clsStudent(1).intMathScore = 70
        clsStudent(1).intEngScore = 80

        clsStudent(2).strStudentName = "이만수"
        clsStudent(2).intMathScore = 60
        clsStudent(2).intEngScore = 60

        Console.WriteLine()
        Console.WriteLine("학생 성적")
        Console.WriteLine()

        For Each tmpStudent In clsStudent
            tmpStudent.Calc_Average()
            tmpStudent.Print_Score()
        Next
    End Sub

End Module
