Imports EmployeeCoreCompetence.clsConn
Imports System.Data.SqlClient
Public Class inc_ViewCareer
    Inherits System.Web.UI.UserControl

#Region " Web Form �]�p�u�㲣�ͪ��{���X "

    '���� Web Form �]�p�u��һݪ��I�s�C
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

    '�`�N: �U�C�w�d��m�ŧi�O Web Form �]�p�u��ݭn�����ءC
    '�ФŧR���β��ʥ��C
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: ���� Web Form �]�p�u��һݪ���k�I�s
        '�ФŨϥε{���X�s�边�i��ק�C
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�b�o�̩�m�ϥΪ̵{���X�H��l�ƺ���
        Dim userID As Integer = 0
        If IsNumeric(Request("userID")) Then
            userID = Request("userID")
        End If
        getCareerInfo(userID)

    End Sub
    Private Sub getCareerInfo(ByVal intUserID As Integer)
        Dim strSQL As String = " SELECT          D_00000, T_00721, T_00678, T_00040,  RTRIM(YEAR(T_00679)) " & _
                                "   + '/' + RTRIM(MONTH(T_00679)) + '/' + RTRIM(DAY(T_00679)) AS T_00679 , RTRIM(YEAR(T_00680)) " & _
                          "+ '/' + RTRIM(MONTH(T_00680)) + '/' + RTRIM(DAY(T_00680)) AS  T_00680, DATEDIFF([month], " & _
                                " T_00679, T_00680) / 12 AS years ,T_00898" & _
                                " FROM              w00233 " & _
                                " WHERE         ( D_00007 = 0  OR " & _
                                "                             D_00007 IS NULL) AND T_00721 = '" & intUserID & "' " & _
                                " ORDER BY T_00679 DESC"

        Dim Conn As clsConn = New clsConn

        Try
            Dim cmd As SqlCommand = New SqlCommand(strSQL, Conn.OpenConnection)

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader()

            DataGrid1.DataSource = dr
            DataGrid1.DataBind()

        Catch ex As Exception
            Response.Write(ex.Message & "<BR>" & strSQL)
        Finally
            Conn.CloseConnection()
        End Try

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

    End Sub
End Class
