<%@ Control Language="vb" AutoEventWireup="false" Codebehind="inc_ViewEdu.ascx.vb" Inherits="EmployeeCoreCompetence.inc_ViewEdu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
 
<FONT face="新細明體">
	<TABLE id="Table1" style="BORDER-RIGHT: #cc9966 1px; BORDER-TOP: #cc9966 1px; BORDER-LEFT: #cc9966 1px; WIDTH: 600px; BORDER-BOTTOM: #cc9966 1px; BORDER-COLLAPSE: collapse; BACKGROUND-COLOR: white"
		borderColor="#cc9966" cellSpacing="0" cellPadding="4" rules="all" border="1">
		<TR style="FONT-WEIGHT: bold; COLOR: #ffffcc; BACKGROUND-COLOR: #990000">
			<TD align="center" colSpan="2">學歷
			</TD>
		</TR>
		<TR>
			<TD align="center" width="120" bgColor="#ffffcc">學 校
			</TD>
			<TD style="COLOR: #330099" width="480"><asp:label id="lblSchool" runat="server"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center" bgColor="#ffffcc">科 系</TD>
			<TD style="COLOR: #330099"><asp:label id="lblClass" runat="server"></asp:label></TD>
		</TR>
	</TABLE>
</FONT>
