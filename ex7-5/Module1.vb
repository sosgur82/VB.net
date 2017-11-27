Module Module1

    Sub Main()

        Dim clsStudent(2) As StudentAverage
        Dim tmpStudent As New StudentAverage

        clsStudent(0) = New StudentClass("홍길동", 90, 85)
        clsStudent(1) = New StudentClass("김동수", 70, 80)
        clsStudent(2) = New StudentClass("이만수", 60, 60)

        Console.WriteLine()
        Console.WriteLine("학생 성적")
        Console.WriteLine()

        For Each tmpStudent In clsStudent
            tmpStudent.PrintScore()
        Next
    End Sub

End Module
