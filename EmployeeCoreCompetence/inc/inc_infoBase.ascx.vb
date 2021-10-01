Imports EmployeeCoreCompetence.clsConn
Imports System.Data.SqlClient
Public Class infoBase
    Inherits System.Web.UI.UserControl

#Region " Web Form 設計工具產生的程式碼 "

    '此為 Web Form 設計工具所需的呼叫。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblName As System.Web.UI.WebControls.Label
    Protected WithEvents lblDept As System.Web.UI.WebControls.Label
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lblEmail As System.Web.UI.WebControls.Label

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
        getInfoBase(userID)
    End Sub
    Private Sub getInfoBase(ByVal intUserID As Integer)
        Dim strSQL As String = "select  D_00000  ,T_00039 ,T_00040 ,T_00038  ,T_00639    from view_w00178 where (D_00007=0 or D_00007 is Null)  AND D_00000 = '" & intUserID & "'"

        Dim Conn As clsConn = New clsConn

        Try
            Dim cmd As SqlCommand = New SqlCommand(strSQL, Conn.OpenConnection)

            Dim dr As SqlDataReader
 
            dr = cmd.ExecuteReader()
 
            If dr.Read Then

                lblName.Text = dr("T_00038")
                lblDept.Text = dr("T_00039")
                lblTitle.Text = dr("T_00040")
                lblEmail.Text = dr("T_00639") & "@hsin-yi.org.tw"

            End If
        Catch ex As Exception
            Response.Write(ex.Message & "<BR>" & strSQL)
        End Try
        Conn.CloseConnection()
    End Sub
End Class
