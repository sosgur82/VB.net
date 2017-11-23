Module Module1

    Sub Main()
        Dim intValue1, intvalue2 As Integer

        intValue1 = 10
        intvalue2 = 20

        Console.WriteLine()
        Console.WriteLine("call by Value")
        Console.WriteLine("Value1 = {0}, Value = {1}", intValue1, intvalue2)

        Swap(intValue1, intvalue2)

        Console.WriteLine("After swap")
        Console.WriteLine("Value1 = {0}, Value = {1}", intValue1, intvalue2)
    End Sub

    Sub Swap(ByVal value1 As Integer, ByVal value2 As Integer)

        Dim intTemp As Integer

        intTemp = value1
        value1 = value2
        value2 = intTemp
    End Sub

End Module
