Imports System.IO
Imports System.Xml.Serialization

Module Module1

    Sub Main()

        Dim continueProcess As Boolean = True
        While continueProcess

            Console.WriteLine("-------- Welcome to Banking System ----------")
            Console.WriteLine("1. Create a New Account")
            Console.WriteLine("2. View Account Details")
            Console.WriteLine("3. Withdraw")
            Console.WriteLine("4. Deposit")
            Console.WriteLine("5. Transfer")
            Console.WriteLine("6. Exit")

            Dim choice As Integer = Console.ReadLine()
            If choice = 1 Then
#Region "Serialization"
                'Step 1. Create a New object And assign the properties
                Dim accObj = New Accounts()

                Console.WriteLine("Enter Account Number")
                accObj.AccNo = Console.ReadLine()
                Console.WriteLine("Enter Account Name")
                accObj.AccountName = Console.ReadLine()
                Console.WriteLine("Enter Account Balance")
                accObj.AccBalance = Console.ReadLine()
                Console.WriteLine("Is the active or not?")
                accObj.AccIsActive = Console.ReadLine()

                'Step 2. We need a new file object, as we want to save the object to file
                Dim myFile As New FileStream(accObj.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                'Step 3. Create a new object of XMLSerializer
                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, accObj)
                myFile.Close()

                Console.WriteLine("Object Serialized - saved to disk.")

#End Region
            ElseIf choice = 2 Then
#Region "Deserialization"

                'FileStream object with read
                Console.WriteLine("Enter your Account Number")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)

                'XML Serializer Object
                Dim getAccount As New XmlSerializer(GetType(Accounts))

                'Use Deserialize method of XmlSerializer
                Dim acc As Accounts 'this is not a new Account - we did not use New Keyword
                acc = getAccount.Deserialize(file)

                Console.WriteLine("Account Number    : " & acc.AccNo)
                Console.WriteLine("Account Name      : " & acc.AccountName)
                Console.WriteLine("Account Balance   : " & acc.AccBalance)
                Console.WriteLine("Is Account Active?: " & acc.AccIsActive)

                file.Close()

#End Region
            ElseIf choice = 3 Then
#Region "Withdraw Amount"
                Console.WriteLine("Enter your account no")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)

                Dim getAccount As New XmlSerializer(GetType(Accounts))
                Dim acc As Accounts
                acc = getAccount.Deserialize(file)
                file.Close()
                Console.WriteLine("Enter amount to withdraw")
                Dim amount As Integer = Console.ReadLine()

                acc.Withdraw(amount)
                Console.WriteLine("Withdrawl successful - Balance: " & acc.AccBalance)

                Dim myFile As New FileStream(acc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, acc)
                myFile.Close()

#End Region
            ElseIf choice = 4 Then
#Region "Deposit Amount"
                Console.WriteLine("Enter your account no")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)

                Dim getAccount As New XmlSerializer(GetType(Accounts))
                Dim acc As Accounts
                acc = getAccount.Deserialize(file)
                file.Close()
                Console.WriteLine("Enter amount to deposit")
                Dim amount As Integer = Console.ReadLine()

                acc.Deposit(amount)
                Console.WriteLine("Deposit successful + Balance: " & acc.AccBalance)

                Dim myFile As New FileStream(acc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, acc)
                myFile.Close()
#End Region
            ElseIf choice = 5 Then
#Region "Transfer Amount"
                Console.WriteLine("Enter your account no")
                Dim accNo As Integer = Console.ReadLine()
                Dim file As New FileStream(accNo & ".xml", FileMode.Open, FileAccess.Read)

                Dim getAccount As New XmlSerializer(GetType(Accounts))
                Dim acc As Accounts
                acc = getAccount.Deserialize(file)
                file.Close()

                Console.WriteLine("Enter target account number")
                Dim targetAccNo = Console.ReadLine()
                Dim targetFile As New FileStream(targetAccNo & ".xml", FileMode.Open, FileAccess.Read)

                Dim getTargetAccount As New XmlSerializer(GetType(Accounts))
                Dim targetAcc As Accounts
                targetAcc = getAccount.Deserialize(targetFile)
                targetFile.Close()

                Console.WriteLine("Enter amount to transfer")
                Dim amountTransfer As Integer = Console.ReadLine()

                acc.Transfer(amountTransfer, targetAcc)

                Console.WriteLine("Transferred amount successful - Balance: " & acc.AccBalance)
                Console.WriteLine("Transferred amount successful + Balance: " & targetAcc.AccBalance)

                Dim myFile As New FileStream(acc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                Dim xml As New XmlSerializer(GetType(Accounts))
                xml.Serialize(myFile, acc)
                myFile.Close()

                Dim myTargetFile As New FileStream(targetAcc.AccNo & ".xml", FileMode.Create, FileAccess.Write)

                Dim xmlTarget As New XmlSerializer(GetType(Accounts))
                xmlTarget.Serialize(myTargetFile, targetAcc)
                myTargetFile.Close()


#End Region
            ElseIf choice = 6 Then
#Region "Exit"
                continueProcess = False
                Console.WriteLine("Thank you for banking with us!")
#End Region
            End If
            Console.WriteLine("                  ")
            Console.WriteLine("                  ")
            Console.WriteLine("                  ")

            Console.WriteLine("Press enter to continue")
            Console.ReadLine()
            'Console.Clear()

        End While

    End Sub

End Module
