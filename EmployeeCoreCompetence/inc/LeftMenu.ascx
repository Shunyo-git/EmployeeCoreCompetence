<%@ Control Language="vb" AutoEventWireup="false" Codebehind="LeftMenu.ascx.vb" Inherits="EmployeeCoreCompetence.LeftMenu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<FONT face="新細明體">
	<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="81" align="center" border="0">
		<TR>
			<TD><asp:panel id="Panel1" runat="server">
					<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
						<TR>
							<TD align="center" bgColor="buttonface" height="24">
								<asp:button id="btnMain" runat="server" BorderStyle="None" Text="首　頁" CausesValidation="False"></asp:button></TD>
						</TR>
						<TR>
							<TD height="5"></TD>
						</TR>
					</TABLE>
				</asp:panel></TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 25px" align="center" bgColor="buttonface" height="25"><asp:button id="btnSearch" runat="server" Text="進階查詢" BorderStyle="None" CausesValidation="False"></asp:button></TD>
		</TR>
		<TR>
			<TD height="5"></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="buttonface" height="24"><asp:button id="btnEditInfo" runat="server" Text="資料維護" BorderStyle="None" CausesValidation="False"></asp:button></TD>
		</TR>
		<TR>
			<TD height="5"></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="buttonface" height="24"><asp:button id="btnManagerCpt" runat="server" Text="專長審核" BorderStyle="None" CausesValidation="False"></asp:button></TD>
		</TR>
		<TR>
			<TD height="5"></TD>
		</TR>
		<TR>
			<TD align="center" height="24" bgColor="buttonface"><asp:button id="btnHelp" runat="server" Text="使用說明" BorderStyle="None" CausesValidation="False"></asp:button></TD>
		</TR>
		<TR>
			<TD></TD>
		</TR>
	</TABLE>
</FONT>
