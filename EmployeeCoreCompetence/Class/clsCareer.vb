Public Class clsCareer
    Inherits clsConn

    Private m_resut As Data.DataSet





    Private m_isWebShow As Boolean


    Public Property isWebShow() As Boolean
        Get
            Return m_isWebShow
        End Get
        Set(ByVal Value As Boolean)
            m_isWebShow = Value
        End Set
    End Property

    Function getUserCareer(ByVal intUserID) As Data.DataSet
        Return m_resut
    End Function


    Sub New()

        m_isWebShow = True

    End Sub

    Enum CareerWebShow
        IsWebShow = True
        IsNotWebShow = False
    End Enum
End Class
