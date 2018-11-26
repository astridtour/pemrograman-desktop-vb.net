Module Module1

    Sub Main()
        'calling pangkat dengan method
        Console.WriteLine(2 ^ 5)
        Console.WriteLine(2 ^ 4)
        Console.WriteLine(2 ^ 3)
        Console.WriteLine(2 ^ 2)
        Console.WriteLine(2 ^ 1)
        Console.WriteLine(2 ^ 0)
        For i As Integer = 0 To 5 Step 1
            Console.WriteLine(CStr(Pangkat(2, i)))
        Next
        Console.WriteLine()
        Console.ReadKey()
    End Subm,n m

    Function Pangkat(ByVal y As Integer, ByVal x As Integer) As Long
        Dim hasil As Long = 1
        If (x > 0) Then
            hasil = y * Pangkat(y, x - 1)
        End If
        Return hasil
    End Function

    'Function pangkat(ByVal y As Integer, ByVal x As Integer) As Long
    '    x = 1
    '    For i = 1 To 5 Step 1

    '    Next
    '        If x > 0 Then
    '            x = y * pangkat(y, x - 1)
    '        End If

    '        Console.ReadLine()
    '        Console.ReadKey()

    '        Return x
    'End Function

End Module
