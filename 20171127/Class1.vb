Public Class Class1

    Public intPlus As Integer
    Public intMinus As Integer
    Public intMulti As Integer
    Public intDivision As Integer

    Public Sub Calc_Plus(ByVal iValue1 As Integer, ByVal iValue2 As Integer)
        intPlus = iValue1 + iValue2
    End Sub

    Public Sub Calc_Minus(ByVal iValue1 As Integer, ByVal iValue2 As Integer)
        intMinus = iValue1 - iValue2
    End Sub

    Public Sub Calc_Multi(ByVal iValue1 As Integer, ByVal iValue2 As Integer)
        intMulti = iValue1 * iValue2
    End Sub

    Public Sub Calc_Division(ByVal iValue1 As Integer, ByVal iValue2 As Integer)
        intDivision = iValue1 / iValue2
    End Sub
End Class
