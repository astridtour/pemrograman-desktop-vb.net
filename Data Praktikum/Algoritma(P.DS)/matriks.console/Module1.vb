Module Module1

    Sub Main()
        Dim A(,) As Integer = {{1, 2}, {3, 5}}
        Dim m As Integer = 2, n As Integer = 2
        Dim At(m, n) As Integer
        Console.WriteLine(Strings.Format("{ 0}", "Matriks A"))
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                Console.Write(A(i - 1, j - 1))
                Console.Write(Space(2))
            Next
            Console.WriteLine()
        Next

        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                At(j - 1, i - 1) = A(i - 1, j - 1)
            Next
        Next

        Console.WriteLine(Strings.Format("{ 0}", "Transposisi Matriks A"))
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                Console.Write(At(i - 1, j - 1))
                Console.Write(Space(2))
            Next
            Console.WriteLine()
        Next
        Dim B(m, n) As Integer
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                B(i - 1, j - 1) = 0
                For k As Integer = 1 To n Step 1
                    B(i - 1, j - 1) = B(i - 1, j - 1) + (A(i - 1, k - 1) * At(k - 1, j - 1))
                Next
            Next
        Next

        Console.WriteLine(Strings.Format("{ 0}", "B= A x At"))
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                Console.Write(B(i - 1, j - 1))
                Console.Write(Space(3))
            Next
            Console.WriteLine()
        Next
        Dim C(m, n) As Integer
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                C(i - 1, j - 1) = 0
                For k As Integer = 1 To n Step 1
                    C(i - 1, j - 1) = C(i - 1, j - 1) + (A(i - 1, k - 1) + At(k - 1, j - 1))
                Next
            Next
        Next

        Console.WriteLine(Strings.Format("{ 0}", "C= A + At"))
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                Console.Write(B(i, j) + (At(i, j)))
                Console.Write(Space(3))
            Next
            Console.WriteLine()
        Next
        Dim D(m, n) As Integer
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                D(i - 1, j - 1) = 0
                For k As Integer = 1 To n Step 1
                    D(i - 1, j - 1) = D(i - 1, j - 1) - (A(i - 1, k - 1) - At(k - 1, j - 1))
                Next
            Next
        Next

        Console.WriteLine(Strings.Format("{ 0}", "D= A - At"))
        For i As Integer = 1 To m Step 1
            For j As Integer = 1 To n Step 1
                Console.Write(B(i, j) - (At(i, j)))
                Console.Write(Space(3))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub
End Module
