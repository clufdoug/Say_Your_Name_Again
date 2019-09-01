Module Module1

    Sub Main()

        Do
            Console.WriteLine("What is your name?")
            Console.Write("Type your first name ")
            Dim firstname As String
            firstname = Console.ReadLine()

            Dim response As String = ""
            If firstname = "Emily" Then
                response = "Hello Emily, Your hair looks nice"
            ElseIf firstname = "Joe" Then
                response = "Dammit Joe, Tie your shoes!!"
            ElseIf firstname = "Doug" Then
                response = "Doug is a steely-eyed missle man."
            End If

            Console.WriteLine(response)
        Loop Until firstname = "no"

    End Sub

End Module
