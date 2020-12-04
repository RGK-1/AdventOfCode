Imports System.IO

Module Day2
    Sub Main()
        Using sr As StreamReader = New StreamReader("inputday2.txt")
            Dim Line As String


            Dim Array1 As ArrayList = New ArrayList




            Line = sr.ReadLine()
            While Line <> Nothing

                Console.WriteLine(Line)
                Line = sr.ReadLine
                Array1.Add(Line)



            End While
            'Console.WriteLine()
            Console.ReadLine()

            'Array1.Add(Line.Split(" "c))
            Dim PwArray As ArrayList = New ArrayList
            Dim NoCharac As ArrayList = New ArrayList
            Dim TempArray As ArrayList = New ArrayList
            Dim Array2 As ArrayList = New ArrayList
            'PwArray.Add(Line.Split(""c))
            'PwArray.Add(Line.Split(":"c))
            'NoCharac.Add(Line.Split("-"c))
            For i = 0 To Array1.Count - 1

                'Array2.Add(Array1(i).Split(":"))
                Array2(i) = Array1(i).Split(":")
                Console.WriteLine(Array2(i))
            Next


        End Using

    End Sub


End Module
