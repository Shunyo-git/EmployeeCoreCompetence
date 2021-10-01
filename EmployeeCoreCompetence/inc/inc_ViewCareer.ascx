<%@ Control Language="vb" AutoEventWireup="false" Codebehind="inc_ViewCareer.ascx.vb" Inherits="EmployeeCoreCompetence.inc_ViewCareer" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
 
<TABLE id="Table1" style="BORDER-RIGHT: #cc9966 1px; BORDER-TOP: #cc9966 1px; BORDER-LEFT: #cc9966 1px; WIDTH: 600px; BORDER-BOTTOM: #cc9966 1px; BORDER-COLLAPSE: collapse; BACKGROUND-COLOR: white"
	borderColor="#cc9966" cellSpacing="0" cellPadding="4" rules="all" border="1">
	<TR style="FONT-WEIGHT: bold; COLOR: #ffffcc; BACKGROUND-COLOR: #990000">
		<TD align="center" colSpan="2">經歷
		</TD>
	</TR>
</TABLE>
<asp:DataGrid id="DataGrid1" runat="server" Width="600px" BorderColor="#CC9966" BorderStyle="None"
	BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False">
	<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
	<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
	<HeaderStyle ForeColor="Black" BackColor="#FFFFCC"></HeaderStyle>
	<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
	<Columns>
		<asp:BoundColumn DataField="T_00678" ReadOnly="True" HeaderText="公司名稱"></asp:BoundColumn>
		<asp:BoundColumn DataField="T_00040" ReadOnly="True" HeaderText="職稱"></asp:BoundColumn>
		<asp:BoundColumn DataField="T_00679" ReadOnly="True" HeaderText="開始日期"></asp:BoundColumn>
		<asp:BoundColumn DataField="T_00680" ReadOnly="True" HeaderText="結束日期"></asp:BoundColumn>
		<asp:BoundColumn DataField="Years" ReadOnly="True" HeaderText="年資"></asp:BoundColumn>
		<asp:BoundColumn DataField="T_00898" ReadOnly="True" HeaderText="主管職"></asp:BoundColumn>
	</Columns>
	<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
</asp:DataGrid><LINK href="../Css/Styles.css" type="text/css" rel="stylesheet">
