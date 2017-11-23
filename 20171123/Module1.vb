Module Module1

    Sub Main()
        Dim intD As Integer
        intD = 5

        Console.WriteLine()
        Console.WriteLine("실 인수 : {0}", intD)
        GuGuDan(intD)
    End Sub

    Public Sub GuGuDan(intDan As Integer)
        Console.WriteLine("실 인수 : {0}", intDan)

        Dim intCount As Integer

        For intCount = 1 To 9
            Console.WriteLine("{0} * {1} = {2}", intDan, intCount, intDan * intCount)
        Next
    End Sub

End Module
