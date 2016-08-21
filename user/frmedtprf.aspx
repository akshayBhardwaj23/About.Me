<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmedtprf.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<div id="contentPart">
	<h1>Profile details<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h1>
	<table width="100%" border="0" cellspacing="0" cellpadding="8">
		<tr>
			<td align="left" valign="top" style="width: 19%">First Name:</td>
			<td width="85%" align="left" valign="top">
                <asp:TextBox ID="txtfstnam" runat="server" CssClass="field2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfstnam" ErrorMessage="Fill this" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Last Name:</td>
			<td width="85%" align="left" valign="top">
                <asp:TextBox ID="txtlstnam" runat="server" CssClass="field2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlstnam" ErrorMessage="Fill this" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Biography:</td>
			<td align="left" valign="top">
                <cc1:Editor ID="Editor1" runat="server" Height="250px" Width="500px" />
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Upload Your Image:</td>
			<td align="left" valign="top">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Upload Background Image:</td>
			<td align="left" valign="top">&nbsp;<asp:FileUpload ID="FileUpload2" runat="server" />
			<small>(Picture should be max 1024 wide)</small></td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Privacy Status</td>
			<td align="left" valign="top">
                <asp:RadioButtonList ID="RadioButtonList1"   runat="server" Width="337px">
                    <asp:ListItem Value="R">Show Email to Public</asp:ListItem>
                    <asp:ListItem Value="P">Don&#39;t Show Email to Public</asp:ListItem>
                </asp:RadioButtonList>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Facebook Profile Page URL</td>
			<td align="left" valign="top">
                <asp:TextBox ID="txtfac" runat="server" CssClass="field2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtfac" ErrorMessage="Fill this" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtfac" ErrorMessage="Enter valid url" Font-Bold="True" ForeColor="#CC0066" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">Twitter Profile Page URL</td>
			<td align="left" valign="top">
                <asp:TextBox ID="txttwt" runat="server" CssClass="field2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txttwt" ErrorMessage="Fill this" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txttwt" ErrorMessage="Enter valid url" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%">LinkedIn Profile Page URL</td>
			<td align="left" valign="top">
                <asp:TextBox ID="txtlin" runat="server" CssClass="field2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtlin" ErrorMessage="Fill this" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtlin" ErrorMessage="Enter valid url" ForeColor="#CC0066" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" Font-Bold="True"></asp:RegularExpressionValidator>
            </td>
		</tr>
		<tr>
			<td align="left" valign="top" style="width: 19%"></td>
			<td align="left" valign="top">
                <asp:Button ID="Button1" CssClass="btn button" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" CssClass="btn cancel" runat="server" Text="Cancel" OnClick="Button2_Click" CausesValidation="false" />
            </td>
		</tr>
	</table>
</div>

</asp:Content>

