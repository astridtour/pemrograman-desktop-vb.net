Module myfunctions

    Function findmax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        'local variabel declarasion */
        Dim result As Integer
        If (num1 < num2) Then
            result = num1
        Else
            result = num2

        End If
        findmax = result
    End Function

    Sub Main()
        Dim a As Integer = 100
        Dim b As Integer = 200
        Dim res As Integer
        res = findmax(a, b)
        Console.WriteLine("max value is : {0}", res)
        Console.WriteLine()
        Console.ReadKey()
    End Sub

End Module
