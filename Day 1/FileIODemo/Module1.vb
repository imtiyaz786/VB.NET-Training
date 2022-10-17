Imports System.IO

Module Module1

    Sub Main()

        Dim doMore As Boolean = True

        While doMore
            Console.WriteLine("Enter a choice")
            Console.WriteLine("1. Write a new file")
            Console.WriteLine("2. Read from a file")
            Console.WriteLine("3. Exit")

            Dim choice As Integer = Console.ReadLine()
            If choice = 1 Then

#Region "Write to File"
                Dim guestName As String
                Console.WriteLine("Please enter your name")
                guestName = Console.ReadLine()

                Dim myfile As New FileStream(guestName & ".txt", FileMode.Create, FileAccess.Write)
                Dim writer As New StreamWriter(myfile)

                writer.WriteLine("hello, my name is " & guestName)

                Console.WriteLine("you are from which city?")
                Dim city As String = Console.ReadLine()
                writer.WriteLine("i am from " & city)

                Console.WriteLine("what do you work as?")
                Dim work As String = Console.ReadLine()
                writer.WriteLine("i am a " & work)

                Console.WriteLine("what do you love?")
                Dim love As String = Console.ReadLine()
                writer.WriteLine("i love " & love)

                writer.WriteLine("i am passionate about devops and open-source")

                writer.Close()
                myfile.Close()

                Console.WriteLine("content written to file.")
#End Region
            ElseIf choice = 2 Then
#Region "Read File"
                Console.WriteLine("Please enter a name to open the file")
                Dim user As String = Console.ReadLine()
                Dim myFile As New FileStream(user & ".txt", FileMode.Open, FileAccess.Read)
                Dim reader As New StreamReader(myFile)

                Console.WriteLine(reader.ReadToEnd())

#End Region
            Else
                Console.WriteLine("Thank you")
                doMore = False

            End If

        End While

        Console.ReadLine()

    End Sub

End Module
