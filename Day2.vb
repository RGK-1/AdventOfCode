Imports System.IO

Module Day2
    Sub Main()
        Using sr As StreamReader = New StreamReader("inputday2.txt")
            Dim Line As String


            Dim Array1 As ArrayList = New ArrayList
            Dim Array3() As String
            Dim letter1(0) As String
            Dim NumberNoSplit(0) As String
            Dim NumberSplit() As String
            Dim pw(0) As String
            Dim k As Integer = 0
            Dim l As Integer = 0
            Dim m As Integer = 0

            Line = sr.ReadLine()

            While Line <> Nothing

                'Console.WriteLine(Line)
                Line = sr.ReadLine
                Array1.Add(Line)

                'Console.WriteLine(Array1(i))


            End While
            Dim Array2(1) As String

            For Each i In Array1
                If i = Nothing Then
                    Exit For
                End If


                'Console.WriteLine(i)

                Array2 = i.Split(": ")
                'Console.WriteLine(Array2(0))

                Array3 = Array2(0).Split(" ")
                'Array3 = Array2(1).Split(" ")

                'Console.WriteLine(Array3(0))

                letter1(0) = (Array3(1))
                'Console.WriteLine(letter1(0))
                'k = k + 1
                NumberNoSplit(0) = Array3(0)

                NumberSplit = NumberNoSplit(0).Split("-")
                ' l = l + 1
                Dim Number1 As Integer = NumberSplit(0)
                Dim Number2 As Integer = NumberSplit(1)
                pw(0) = Array2(1)
                'Console.WriteLine(Number1)
                'Console.WriteLine(Number2)


                'm = m + 1
                Dim Count As Integer = 0
                Count = CountCharacter(pw(0), letter1(0))
                Console.WriteLine(Count)
                If Count > Number1 And Count < Number2 Then
                    Console.WriteLine()
                End If
            Next





            Dim TempArray As ArrayList = New ArrayList





            'Console.WriteLine("Hello split")
            'Console.WriteLine(Array2(2))
            Console.ReadLine()

        End Using

    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

End Module
