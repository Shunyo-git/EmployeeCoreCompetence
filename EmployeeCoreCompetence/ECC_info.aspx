<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="inc/LeftMenu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="inc_ViewCareer" Src="inc/inc_ViewCareer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="inc_ViewEdu" Src="inc/inc_ViewEdu.ascx" %>
<%@ Page Language="vb" trace="false" AutoEventWireup="True" Codebehind="ECC_info.aspx.vb" Inherits="EmployeeCoreCompetence.ECC_info"%>
<%@ Register TagPrefix="uc1" TagName="infoBase" Src="inc/inc_infoBase.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Info</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Css/ECC.css" type="text/css" rel="stylesheet">
		<LINK href="Css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="Css/menu.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" runat="server">
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="750" border="0">
				<TR>
					<TD style="WIDTH: 113px; HEIGHT: 45px"></TD>
					<TD style="WIDTH: 555px; HEIGHT: 45px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 113px; HEIGHT: 16px" vAlign="top"><uc1:leftmenu id="LeftMenu1" runat="server"></uc1:leftmenu></TD>
					<TD style="WIDTH: 555px; HEIGHT: 16px" vAlign="top" align="center"><FONT face="·s²Ó©úÅé">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="600" align="center" border="0">
								<TR>
									<TD align="center"><uc1:infobase id="InfoBase1" runat="server"></uc1:infobase></TD>
								</TR>
								<TR>
									<TD width="20">&nbsp;</TD>
								</TR>
								<TR>
									<TD align="center"><uc1:inc_viewedu id="Inc_ViewEdu1" runat="server"></uc1:inc_viewedu></TD>
								</TR>
								<TR>
									<TD width="20">&nbsp;</TD>
								</TR>
								<TR>
									<TD align="center">
										<uc1:inc_ViewCareer id="Inc_ViewCareer1" runat="server"></uc1:inc_ViewCareer></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
								<TR>
									<TD></TD>
								</TR>
							</TABLE>
						</FONT>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
