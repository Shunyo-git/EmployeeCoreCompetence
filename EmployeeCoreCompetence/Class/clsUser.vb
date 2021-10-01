Public Class clsUser
    Inherits clsConn


    Private m_Name As String
    Private m_UserID As Integer
    Private m_isManager As Boolean
    Private m_UserAccount As String
    Private m_isLimit As Boolean
    Private m_Title As String





    Public ReadOnly Property Name() As String
        Get
            Return m_Name
        End Get

    End Property

    Public Property UserID() As Integer
        Get
            Return m_UserID
        End Get
        Set(ByVal Value As Integer)
            m_UserID = Value
        End Set
    End Property
    Public ReadOnly Property UserAccount() As String
        Get
            Return m_UserAccount
        End Get

    End Property
    Public ReadOnly Property isManager() As Boolean
        Get
            Return m_isManager
        End Get

    End Property
    Public ReadOnly Property isLimit() As Boolean
        Get
            Return m_isLimit
        End Get

    End Property


    Function getUserName() As String
        Return 0
    End Function
    Function getUserAccount() As String
        Return 0
    End Function

    Function chkManager() As Boolean
        Return 0
    End Function

    Function chkLimit() As Boolean
        Return 0
    End Function




    Public ReadOnly Property Title() As String
        Get
            Return m_Title
        End Get

    End Property
End Class
