Module Module1
    
    Sub Main()
        Dim A(,) As Integer = {{3, 2}, {0, 3}, {1, 4}}
        'Dim B(,) As Integer = {{1, 8}, {6, 3}, {0, 4}}


        A(0, 0) = 3 : A(0, 1) = 2
        A(1, 0) = 0 : A(1, 1) = 3
        A(2, 0) = 1 : A(2, 1) = 4
        Console.WriteLine()
        Console.ReadLine()

    End Sub
End Module
