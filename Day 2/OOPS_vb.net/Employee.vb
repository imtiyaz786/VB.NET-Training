Public Class Employee

    Private empNo As Integer
    Public Property EmployeeNumber() As Integer
        Get
            Return empNo
        End Get
        Set(value As Integer)
            empNo = value
        End Set
    End Property

    Private empName As String
    Public Property EmployeeName() As String
        Get
            Return empName
        End Get
        Set(value As String)
            empName = value
        End Set
    End Property

    Private empDesignation As String
    Public Property EmployeeDesignation() As String
        Get
            Return empDesignation
        End Get
        Set(value As String)
            empDesignation = value
        End Set
    End Property

    Private empSalary As Integer
    Public Property EmployeeSalary() As Integer
        Get
            Return empSalary
        End Get
        Set(value As Integer)
            empSalary = value
        End Set
    End Property

    Private empAvailableLeaves As Integer
    Public Property EmployeeAvailableLeaves() As Integer
        Get
            Return empAvailableLeaves
        End Get
        Set(value As Integer)
            empAvailableLeaves = value
        End Set
    End Property

    Function Bonus(percentage As Integer) As Double
        Dim bonusResult As Integer = EmployeeSalary * percentage / 100
        Return bonusResult
    End Function

    Function ApplyLeave(days As Integer) As Integer
        EmployeeAvailableLeaves -= days
        Return EmployeeAvailableLeaves
    End Function

End Class
