Module Module1
    Sub Main()

        'variables can store only a single value, however if we need to store more values of simililar type, we need to use Collection
        'with collection, u can store multiple value in a single variable, and that variable will allow you to perform sort, filter, group etc..

        'Types of collection:
        'Array -- it can store only 1 single data type
        'ArrayList -- 
        'List -- generic data collection supported by all the framework, Java, .net, etc..
        'Dictionary
        'Hashtable

#Region "String Array"
        'Dim myFriendsList(10) As String
        'myFriendsList(0) = "Manoj0"
        'myFriendsList(1) = "Manoj1"
        'myFriendsList(2) = "Manoj2"
        'myFriendsList(3) = "Manoj3"
        'myFriendsList(4) = "Manoj4"
        'myFriendsList(5) = "Manoj5"
        'myFriendsList(6) = "Manoj6"
        'myFriendsList(7) = "Manoj7"
        'myFriendsList(8) = "Manoj8"
        'myFriendsList(9) = "Manoj9"

        'Console.WriteLine(myFriendsList(6))

        'For Each item In myFriendsList
        '    Console.WriteLine(item)
        'Next
#End Region
#Region "Integer Array & Operations"
        'Dim favNumbers(10) As Integer

        'For index = 0 To 9
        '    Console.WriteLine("Please enter number")
        '    favNumbers(index) = Console.ReadLine()
        'Next

        'Dim total As Integer
        'Dim evenNumbers As Integer
        'Dim oddNumbers As Integer

        'For index = 0 To 9
        '    If favnumbers(index) Mod 2 = 0 Then
        '        evenNumbers += 1
        '    Else
        '        oddNumbers += 1

        '    End If
        '    total += favnumbers(index)
        'Next

        'Console.WriteLine("sum of all the numbers: " & total)
        'Console.WriteLine("even numbers: " & evenNumbers)
        'Console.WriteLine("odd numberss: " & oddnumbers)
#End Region
#Region "ArrayList"
        'Dim arrList As New ArrayList From {
        '    101,
        '    "Imtiyaz",
        '    20000.982
        '}
        'For Each item In arrList
        '    Console.WriteLine(item)
        'Next
#End Region
#Region "List"
        'Dim guestList As New List(Of String)
        'guestList.Add("Guest1")
        'guestList.Add("Guest2")
        'guestList.Add("Guest3")
        'guestList.Add("Guest4")
        'guestList.Add("Guest5")
        'guestList.Add("Guest6")
        'guestList.Add("Guest7")
        'guestList.Add("Guest8")
        'guestList.Add("Guest9")
        'guestList.Add("Guest10")
        'guestList.Add("Guest11")

        'For Each item In guestList
        '    Console.WriteLine(item)
        'Next
#End Region
#Region "Dictionary"
        'Dim dict As New Dictionary(Of Integer, String) From {
        '    {101, "Imtiyaz"},
        '    {102, "MJ"},
        '    {103, "Abhinav"},
        '    {104, "Venugopal"}
        '}

        'For Each item In dict
        '    Console.WriteLine(item.Key & " :  " & item.Value)
        'Next
#End Region

        Console.ReadLine()

    End Sub

End Module
