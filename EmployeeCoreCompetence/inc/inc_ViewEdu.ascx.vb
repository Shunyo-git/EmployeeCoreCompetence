Imports EmployeeCoreCompetence.clsConn
Imports System.Data.SqlClient
Public Class inc_ViewEdu
    Inherits System.Web.UI.UserControl

#Region " Web Form �]�p�u�㲣�ͪ��{���X "

    '���� Web Form �]�p�u��һݪ��I�s�C
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lblSchool As System.Web.UI.WebControls.Label
    Protected WithEvents lblClass As System.Web.UI.WebControls.Label

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
        getEduInfo(userID)
        getClassInfo(userID)
    End Sub
    Private Sub getEduInfo(ByVal intUserID As Integer)
        Dim strSQL As String = " SELECT         HsinyiUser.User_ID, HsinyiUser.UserName, w00176.T_00637 + ' > ' + " & _
                                "                           w00179.T_00641 as SchoolName, w00179.T_00640, w00179.T_00644, w00179.D_00000 " & _
                                " FROM             w00179 INNER JOIN " & _
                                "                           HsinyiUser ON w00179.T_00644 = HsinyiUser.User_ID INNER JOIN " & _
                                "                           w00176 ON w00179.T_00640 = w00176.D_00000 " & _
                                " WHERE         (w00179.D_00007 = 0  OR " & _
                                "                            w00179.D_00007 IS NULL) AND HsinyiUser.User_ID = '" & intUserID & "'"

        Dim Conn As clsConn = New clsConn

        Try
            Dim cmd As SqlCommand = New SqlCommand(strSQL, Conn.OpenConnection)

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader()

            Do While dr.Read
                lblSchool.Text += dr("SchoolName") & "<BR>"
            Loop


        Catch ex As Exception
            Response.Write(ex.Message & "<BR>" & strSQL)
        Finally
            Conn.CloseConnection()
        End Try

    End Sub
    Private Sub getClassInfo(ByVal intUserID As Integer)
        Dim strSQL As String = " SELECT         w00180.D_00000, w00180.T_00644, w00180.T_00642, " & _
"                           w00177.T_00638 + ' > ' + w00180.T_00643 AS class, HsinyiUser.UserName,  " & _
"                           HsinyiUser.User_ID " & _
" FROM             w00180 INNER JOIN " & _
"                           HsinyiUser ON w00180.T_00644 = HsinyiUser.User_ID INNER JOIN " & _
"                           w00177 ON w00180.T_00642 = w00177.D_00000 " & _
" WHERE         (w00180.D_00007 = 0 OR " & _
"                           w00180.D_00007 IS NULL) AND (HsinyiUser.User_ID = '" & intUserID & "')"

        Dim Conn As clsConn = New clsConn

        Try
            Dim cmd As SqlCommand = New SqlCommand(strSQL, Conn.OpenConnection)

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader()

            Do While dr.Read
                lblClass.Text += dr("class") & "<BR>"
            Loop


        Catch ex As Exception
            Response.Write(ex.Message & "<BR>" & strSQL)
        Finally
            Conn.CloseConnection()
        End Try

    End Sub


    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
