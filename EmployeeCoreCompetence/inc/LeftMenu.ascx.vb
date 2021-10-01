Public Class LeftMenu
    Inherits System.Web.UI.UserControl

#Region " Web Form 設計工具產生的程式碼 "

    '此為 Web Form 設計工具所需的呼叫。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnHelp As System.Web.UI.WebControls.Button
    Protected WithEvents btnManagerCpt As System.Web.UI.WebControls.Button
    Protected WithEvents btnEditInfo As System.Web.UI.WebControls.Button
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents btnMain As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel


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
        If InStr(Request.ServerVariables("SCRIPT_NAME"), "index.aspx") > 0 Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("index.aspx")
    End Sub
End Class
