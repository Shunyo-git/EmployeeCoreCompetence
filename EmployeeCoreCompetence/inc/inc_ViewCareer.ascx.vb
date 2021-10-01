Imports EmployeeCoreCompetence.clsConn
Imports System.Data.SqlClient
Public Class inc_ViewCareer
    Inherits System.Web.UI.UserControl

#Region " Web Form 設計工具產生的程式碼 "

    '此為 Web Form 設計工具所需的呼叫。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

    '注意: 下列預留位置宣告是 Web Form 設計工具需要的項目。
    '請勿刪除或移動它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此為 Web Form 設計工具所需的方法呼叫
        '請勿使用程式碼編輯器進行修改。
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在這裡放置使用者程式碼以初始化網頁
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
