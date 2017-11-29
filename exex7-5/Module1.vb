Module Module1

    Sub Main()
        Dim studentScore(2) As Student
        Dim intCount As Integer

        studentScore(0) = New Student("홍길동", "B+", "A+", "B+")
        studentScore(1) = New Student("김영희", "A", "A+", "B+")
        studentScore(2) = New Student("김철수", "A+", "B", "C")

        For intCount = 0 To 2
            studentScore(intCount).PrintScore()
        Next

    End Sub

End Module