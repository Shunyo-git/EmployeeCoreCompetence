Imports EmployeeCoreCompetence.clsConn
Imports System.Data.SqlClient
Public Class index
    Inherits System.Web.UI.Page

#Region " Web Form 設計工具產生的程式碼 "

    '此為 Web Form 設計工具所需的呼叫。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SearchList As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtKeyword As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnGoSarch As System.Web.UI.WebControls.Button
    Protected WithEvents txtValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents btnShowAll As System.Web.UI.WebControls.Button

    '注意: 下列預留位置宣告是 Web Form 設計工具需要的項目。
    '請勿刪除或移動它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此為 Web Form 設計工具所需的方法呼叫
        '請勿使用程式碼編輯器進行修改。
        InitializeComponent()
    End Sub

#End Region


    Private SearchSelectedID As Integer = 0




    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在這裡放置使用者程式碼以初始化網頁
 
        If Not IsPostBack Then
            'If SortExpression = "" Then
            '    SortExpression = "單位"
            '    Session("OldSortExpression") = SortExpression
            'End If

            If DataGrid1.Attributes("SortExpression") Is Nothing Then
                DataGrid1.Attributes("SortExpression") = "單位"
                DataGrid1.Attributes("SortDirection") = "ASC"
            End If

            getGridList(0)
            getSearchList()
            Session("SearchID") = SearchSelectedID
        End If

    End Sub

    Sub Sort_Grid(ByVal sender As Object, ByVal e As DataGridSortCommandEventArgs)
        Dim SortExpression As String = e.SortExpression.ToString()
        Dim sortDirection As String = "ASC"
        If SortExpression.Equals(DataGrid1.Attributes("SortExpression").ToString) Then
            If DataGrid1.Attributes("SortDirection").ToString.StartsWith("ASC") Then
                sortDirection = "DESC"
            Else
                sortDirection = "ASC"
            End If
        End If
        DataGrid1.Attributes("SortExpression") = SortExpression
        DataGrid1.Attributes("SortDirection") = sortDirection
        DataGrid1.CurrentPageIndex = 0
        getGridList(Session("SearchID"))
    End Sub 'Sort_Grid


    Private Sub getSearchList()
        SearchList.Items.Add("姓名")
        SearchList.Items.Item(0).Value = SearchItem.Name
        SearchList.Items.Add("單位")
        SearchList.Items.Item(1).Value = SearchItem.Dept
        SearchList.Items.Add("職稱")
        SearchList.Items.Item(2).Value = SearchItem.Title
        SearchList.Items.Add("Email")
        SearchList.Items.Item(3).Value = SearchItem.Email
        SearchList.Items.Insert(0, "請選擇項目")
        SearchList.Items.Item(0).Value = 0
    End Sub
    Private Sub getGridList(ByVal intStateID)

        Dim strSQL As String = "select  D_00000 as 編號,T_00039 as [單位],T_00040 as [職稱],T_00038 as [姓名],T_00639 as [Email帳號]  from view_w00178 where (D_00007=0 or D_00007 is Null) order by  D_00000 desc"

        Dim Conn As SqlConnection = New SqlConnection(m_strConn)
        Dim ds As DataSet = New DataSet

        Try

            Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, Conn)
            da.Fill(ds, "view_w00178")

            Dim dv As DataView = New DataView
            dv.Table = ds.Tables("view_w00178")

            If intStateID > 0 Then
                Select Case intStateID
                    Case SearchItem.Dept
                        dv.RowFilter = "[單位] like '%" & txtKeyword.Text & "%'"
                    Case SearchItem.Email
                        dv.RowFilter = "[Email帳號] like '%" & txtKeyword.Text & "%'"
                    Case SearchItem.Name
                        dv.RowFilter = "[姓名] like '%" & txtKeyword.Text & "%'"
                    Case SearchItem.Title
                        dv.RowFilter = "[職稱] like '%" & txtKeyword.Text & "%'"
                End Select

                btnShowAll.Visible = True
            End If

            Dim sortExpress As String = DataGrid1.Attributes("SortExpression").ToString
            Dim sortDirection As String = DataGrid1.Attributes("SortDirection").ToString
            dv.Sort = sortExpress + " " + sortDirection

            'If IsPostBack Then
            '    If String.Equals(SortExpression, Session("OldSortExpression")) Then

            '        If InStr(Session("OldSortExpression"), "DESC") Then
            '            SortExpression = Session("OldSortExpression") & " ASC"
            '        Else
            '            SortExpression = Session("OldSortExpression") & " DESC"
            '        End If

            '    End If
            'End If

            ' dv.Sort = SortExpression
            ' Session("OldSortExpression") = SortExpression

            If Session("SearchID") <> intStateID Then
                DataGrid1.CurrentPageIndex = 0
                Session("SearchID") = intStateID
            End If

            DataGrid1.DataSource = dv
            DataGrid1.DataBind()


        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            Conn.Close()
            Conn.Dispose()
        End Try


    End Sub


    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged
        DataGrid1.CurrentPageIndex = e.NewPageIndex

        getGridList(Session("SearchID"))

    End Sub



    Private Sub btnGoSarch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoSarch.Click
        If Page.IsValid Then
            SearchSelectedID = Integer.Parse(SearchList.SelectedValue)
            getGridList(SearchSelectedID)
            DataGrid1.CurrentPageIndex = 0
        End If

    End Sub


    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getGridList(0)
        DataGrid1.CurrentPageIndex = 0
        btnShowAll.Visible = False
    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged
        'DataGrid1.Columns(n).Visible = False
    End Sub
End Class
