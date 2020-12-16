Imports System.IO


Module Day3
    Sub Main()
        
        Using sr As StreamReader = New StreamReader("inputday3.txt")
            Dim Line As String

            Dim Array1 As ArrayList = New ArrayList
            Dim Charnumb As Integer = 0
            'Dim ch1 As Integer = 0 

            Dim Down As Integer = 0
            Dim Across As Integer =0
            Dim Tree As Integer = 0

            'Dim Lines As Integer = 0
            Line = sr.ReadLine()
            While Line <> Nothing
                Console.WriteLine(Line)
                Array1.Add(Line)

                Line = sr.ReadLine


            End While
            While Down <> 323
                If Across > 31 Then
                    Across = Across - 30
                End If
                Dim ch1 As Char = Array1(Down).Chars(Across)
                If ch1 = ("#") Then
                    Tree += 1
                End If
                Across += 3
                Down += 1
            End While
            Console.WriteLine(Tree)
            Console.ReadLine()

        End Using
    End Sub
End Module
