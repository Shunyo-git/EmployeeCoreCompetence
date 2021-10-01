Public Class clsCompetence
    Inherits clsConn

    Private m_resut As Data.DataSet





    Private m_isApprove As Boolean


    Public Property isApprove() As Boolean
        Get
            Return m_isApprove
        End Get
        Set(ByVal Value As Boolean)
            m_isApprove = Value
        End Set
    End Property

    Function getUserCpt(ByVal intUserID) As Data.DataSet
        Return m_resut
    End Function

    Enum CptApprove
        IsApprove = True
        IsNotApprove = False
    End Enum
End Class
