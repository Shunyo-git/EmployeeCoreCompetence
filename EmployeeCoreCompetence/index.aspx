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
			<FONT face="�s�ө���">
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="750" border="0">
					<TR>
						<TD style="WIDTH: 113px; HEIGHT: 45px"></TD>
						<TD style="WIDTH: 555px; HEIGHT: 45px" class="small">�j�M���ءG<asp:dropdownlist id="SearchList" runat="server" CssClass="box2"></asp:dropdownlist>�A����r�G
							<asp:textbox id="txtKeyword" runat="server" CssClass="box"></asp:textbox>&nbsp;<asp:button id="btnGoSarch" runat="server" Text="�j�M"></asp:button><asp:requiredfieldvalidator id="txtValidator1" runat="server" Display="Dynamic" ControlToValidate="txtKeyword"
								ErrorMessage="�п�J����r">
								<img src="images/err.bmp">�п�J����r</asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="SearchList" ErrorMessage="�п�ܶ���"
								InitialValue="0">
								<img src="images/err.bmp">�п�ܶ���</asp:requiredfieldvalidator><asp:button id="btnShowAll" runat="server" Text="��ܥ���" Visible="False" CausesValidation="False"></asp:button></TD>
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
									<asp:BoundColumn DataField="�s��" SortExpression="�s��" ReadOnly="True" HeaderText="�s��">
										<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="���" SortExpression="���" ReadOnly="True" HeaderText="���">
										<HeaderStyle Width="150px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="�m�W" SortExpression="�m�W" ReadOnly="True" HeaderText="�m�W">
										<HeaderStyle Width="80px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="¾��" SortExpression="¾��" ReadOnly="True" HeaderText="¾��">
										<HeaderStyle Width="150px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Email�b��" SortExpression="Email�b��" ReadOnly="True" HeaderText="Email�b��">
										<HeaderStyle Width="70px"></HeaderStyle>
									</asp:BoundColumn>
									<asp:HyperLinkColumn Text="�˵�" DataNavigateUrlField="�s��" DataNavigateUrlFormatString="ECC_info.aspx?userID={0}"
										HeaderText="�\��">
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
