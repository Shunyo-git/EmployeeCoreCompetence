<%@ Control Language="vb" AutoEventWireup="false" Codebehind="inc_infoBase.ascx.vb" Inherits="EmployeeCoreCompetence.infoBase" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
 
<FONT face="新細明體">
	<TABLE id="Table1" style="BORDER-RIGHT: #cc9966 1px; BORDER-TOP: #cc9966 1px; BORDER-LEFT: #cc9966 1px; WIDTH: 600px; BORDER-BOTTOM: #cc9966 1px; BORDER-COLLAPSE: collapse; BACKGROUND-COLOR: white"
		borderColor="#cc9966" cellSpacing="0" cellPadding="4" rules="all" border="1">
		<TR style="FONT-WEIGHT: bold; COLOR: #ffffcc; BACKGROUND-COLOR: #990000">
			<TD align="center" colSpan="2">基本資料&nbsp;
			</TD>
		</TR>
		<TR>
			<TD align="center" width="120" bgColor="#ffffcc">姓 名
			</TD>
			<TD style="COLOR: #330099" width="480"><asp:label id="lblName" runat="server"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="#ffffcc">單 位</TD>
			<TD style="COLOR: #330099"><asp:label id="lblDept" runat="server"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="#ffffcc">職 稱</TD>
			<TD style="COLOR: #330099"><asp:label id="lblTitle" runat="server"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="#ffffcc">E-mail</TD>
			<TD style="COLOR: #330099"><asp:label id="lblEmail" runat="server"></asp:label></TD>
		</TR>
		<!--
		<TR style="COLOR: #330099; BACKGROUND-COLOR: #ffffcc" align="right">
			<TD colSpan="2">
			</TD>
		</TR>
		--></TABLE>
</FONT>
