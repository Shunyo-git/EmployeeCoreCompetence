<%@ Page Language="vb" trace="false" AutoEventWireup="false" Codebehind="index.aspx.vb" Inherits="EmployeeCoreCompetence.index"%>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="inc/LeftMenu.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>index</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Css/ECC.css" type="text/css" rel="stylesheet">
		<LINK href="Css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="Css/menu.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="新細明體">
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="750" border="0">
					<TR>
						<TD style="WIDTH: 113px; HEIGHT: 45px"></TD>
						<TD style="WIDTH: 555px; HEIGHT: 45px" class="small">搜尋項目：<asp:dropdownlist id="SearchList" runat="server" CssClass="box2"></asp:dropdownlist>，關鍵字：
							<asp:textbox id="txtKeyword" runat="server" CssClass="box"></asp:textbox>&nbsp;<asp:button id="btnGoSarch" runat="server" Text="搜尋"></asp:button><asp:requiredfieldvalidator id="txtValidator1" runat="server" Display="Dynamic" ControlToValidate="txtKeyword"
								ErrorMessage="請輸入關鍵字">
								<img src="images/err.bmp">請輸入關鍵字</asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="SearchList" ErrorMessage="請選擇項目"
								InitialValue="0">
								<img src="images/err.bmp">請選擇項目</asp:requiredfieldvalidator><asp:button id="btnShowAll" runat="server" Text="顯示全部" Visible="False" CausesValidation="False"></asp:button></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 113px; HEIGHT: 16px" vAlign="top"></TD>
						<TD style="WIDTH: 555px; HEIGHT: 16px" vAlign="top" align="center"></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 113px" vAlign="top"><uc1:leftmenu id="LeftMenu1" runat="server"></uc1:leftmenu>
						</TD>
						<TD vAlign="top" align="left">
							<asp:datagrid id="DataGrid1" runat="server" AllowSorting="True" AutoGenerateColumns="False" AllowPaging="True"
								CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CC9966"
								Width="600px" OnSortCommand="Sort_Grid">
								<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#EEEEEE"></AlternatingItemStyle>
								<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
								<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="編號" SortExpression="編號" ReadOnly="True" HeaderText="編號">
										<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="單位" SortExpression="單位" ReadOnly="True" HeaderText="單位">
										<HeaderStyle Width="150px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="姓名" SortExpression="姓名" ReadOnly="True" HeaderText="姓名">
										<HeaderStyle Width="80px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="職稱" SortExpression="職稱" ReadOnly="True" HeaderText="職稱">
										<HeaderStyle Width="150px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Email帳號" SortExpression="Email帳號" ReadOnly="True" HeaderText="Email帳號">
										<HeaderStyle Width="70px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:HyperLinkColumn Text="檢視" DataNavigateUrlField="編號" DataNavigateUrlFormatString="ECC_info.aspx?userID={0}"
										HeaderText="功能">
										<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center"></ItemStyle>
									</asp:HyperLinkColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Right" ForeColor="#330099" BackColor="#FFFFCC" PageButtonCount="5"
									Mode="NumericPages"></PagerStyle>
							</asp:datagrid></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
