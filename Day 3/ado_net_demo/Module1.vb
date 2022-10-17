Imports System.Data.SqlClient
Module Module1
    Sub Main()
#Region "Execute Non Query"



#End Region

        Dim continueOperations As Boolean = True

        While continueOperations

            Dim con As New SqlConnection("server=LTIN303717;database=bankingDB_VB; integrated security=true")
            Dim cmd_checkLogin As New SqlCommand("Select count(*) from loginInfo where userName = @uName and password = @pwd", con)

            Console.WriteLine("Enter User Name")
            Dim userName As String = Console.ReadLine()

            Console.WriteLine("Enter password")
            Dim pasword As String = Console.ReadLine()

            cmd_checkLogin.Parameters.AddWithValue("@uName", userName)
            cmd_checkLogin.Parameters.AddWithValue("@pwd", pasword)

            con.Open()

            Dim result As Integer = cmd_checkLogin.ExecuteScalar()

            If result = 1 Then

                Console.Clear()
                Console.WriteLine("Welcome " & userName)
                Console.WriteLine("1. Check Account Details")
                Console.WriteLine("2. Create New Account")
                Console.WriteLine("3. Delete Account")
                Console.WriteLine("4. Update Account")
                Console.WriteLine("5. Summary")
                Console.WriteLine("6. Exit")

                Dim choice As Integer = Console.ReadLine()

                If choice = 1 Then
#Region "Reader- Execute Reader"

                    Dim cmd_readAccount As New SqlCommand("select * from Accounts where accNo = @accNo", con)

                    Console.WriteLine("Enter Account Number")
                    Dim accNo As Integer = Console.ReadLine()

                    cmd_readAccount.Parameters.AddWithValue("@accNo", accNo)
                    Dim read As SqlDataReader = cmd_readAccount.ExecuteReader()

                    If read.Read() Then
                        Console.WriteLine("Account Number  : " & read(0))
                        Console.WriteLine("Account Name    : " & read(1))
                        Console.WriteLine("Account Type    : " & read(2))
                        Console.WriteLine("Account Balance : " & read(3))
                        Console.WriteLine("Account IsActive: " & read(4))
                    Else
                        Console.WriteLine("Invalid Account Number")
                    End If

#End Region
                ElseIf choice = 2 Then
#Region "Create New Account"

                    Dim cmd_insert As New SqlCommand("insert into Accounts values(@accNo, @accName, @accType, @accBalance, @accIsActive)", con)

                    Console.WriteLine("Enter Account Number")
                    Dim accNo As Integer = Console.ReadLine()

                    Console.WriteLine("Enter Account Name")
                    Dim accName As String = Console.ReadLine()

                    Console.WriteLine("Enter Account Type")
                    Dim accType As String = Console.ReadLine()

                    Console.WriteLine("Enter Account Balance")
                    Dim accBalance As Double = Console.ReadLine()

                    Console.WriteLine("Is Account Active? 0 for Yes 1 for No")
                    Dim accIsActive As Boolean = Console.ReadLine()

                    cmd_insert.Parameters.AddWithValue("@accNo", accNo)
                    cmd_insert.Parameters.AddWithValue("@accName", accName)
                    cmd_insert.Parameters.AddWithValue("@accType", accType)
                    cmd_insert.Parameters.AddWithValue("@accBalance", accBalance)
                    cmd_insert.Parameters.AddWithValue("@accIsActive", accIsActive)
                    cmd_insert.ExecuteNonQuery()

                    Console.WriteLine("Account created successfully!")

#End Region
                ElseIf choice = 3 Then
#Region "Delete Account"

                    Console.WriteLine("Enter Account Number to delete")
                    Dim accNo As Integer = Console.ReadLine()

                    Dim cmd_delete As New SqlCommand("delete from Accounts where accNo = @accNo", con)
                    cmd_delete.Parameters.AddWithValue("@accNo", accNo)
                    result = cmd_delete.ExecuteNonQuery()

                    If result = 1 Then
                        Console.WriteLine("Account Deleted successfully!")
                    Else
                        Console.WriteLine("Invalid Account Number")
                    End If

#End Region
                ElseIf choice = 4 Then
#Region "Update Account"

                    Console.WriteLine("Enter Account Number to update")
                    Dim accNo As Integer = Console.ReadLine()

                    Console.WriteLine("Enter new Account Balance")
                    Dim accBalance As Double = Console.ReadLine()

                    Dim cmd_update As New SqlCommand("update Accounts set accBalance = @accBalance where accNo = @accNo", con)
                    cmd_update.Parameters.AddWithValue("@accNo", accNo)
                    cmd_update.Parameters.AddWithValue("@accBalance", accBalance)
                    result = cmd_update.ExecuteNonQuery()

                    If result = 1 Then
                        Console.WriteLine("Account Updated successfully!")
                    Else
                        Console.WriteLine("Invalid Account Number")
                    End If

#End Region
                ElseIf choice = 5 Then
#Region "Summary - Execute Scalar"

                    Dim cmd_count As New SqlCommand("select count(*) from accounts", con)
                    Dim cmd_sumbalance As New SqlCommand("select sum(accbalance) from accounts", con)
                    Dim cmd_minbalance As New SqlCommand("select min(accbalance) from accounts", con)
                    Dim cmd_maxbalance As New SqlCommand("select max(accbalance) from accounts", con)
                    Dim cmd_avgbalance As New SqlCommand("select avg(accbalance) from accounts", con)

                    Dim totalaccounts As Integer = cmd_count.ExecuteScalar()
                    Dim totalbalance As Integer = cmd_sumbalance.ExecuteScalar()
                    Dim minbalance As Integer = cmd_minbalance.ExecuteScalar()
                    Dim maxbalance As Integer = cmd_maxbalance.ExecuteScalar()
                    Dim avgbalance As Double = cmd_avgbalance.ExecuteScalar()

                    Console.WriteLine("total accounts : " & totalaccounts)
                    Console.WriteLine("total balance  : " & totalbalance)
                    Console.WriteLine("minimum balance: " & minbalance)
                    Console.WriteLine("maximum balance: " & maxbalance)
                    Console.WriteLine("average balance: " & avgbalance)

#End Region
                Else
                    Console.Clear()
                    continueOperations = False
                    Console.WriteLine("Thank you for banking with us!")

                End If
            Else
                Console.Clear()
                Console.WriteLine("Invalid Credential!")
            End If
            con.Close()
        End While

        Console.ReadLine()
    End Sub
End Module
