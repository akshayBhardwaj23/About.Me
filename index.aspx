<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="title">Sign In</div>
		<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr>
		<td valign="top">ENTER YOUR EMAIL ADDRESS<br />
        <asp:TextBox ID="txteml" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txteml" ErrorMessage="Fill This" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            <br />
</td>
	</tr>
	<tr>
		<td height="20" valign="top"></td>
	</tr>
	<tr>
		<td valign="top">CREATE A PASSWORD<br />
    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"
        CssClass="field">

    </asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Fill This" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            <br />
</td>
	</tr>
	<tr>
		<td height="20" valign="top"></td>
	</tr>
	
	<tr>
		<td valign="top">
            <asp:Button ID="Button1" runat="server" CssClass="login-btn" Text="Login" Width="131px" OnClick="Button1_Click"  /> 
        </td>
	</tr>
            <tr>
		<td height="20" valign="top"></td>
	</tr>
	
	<tr>
		<td valign="top">
             
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label><br />
             
        </td>
	</tr>
</table>
</asp:Content>

