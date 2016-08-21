<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmreg.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title">
        Sign up to quickly build your personal profile page that points users to your content from around the web.<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td valign="top">ENTER YOUR EMAIL ADDRESS<br />
                <asp:TextBox runat="server" ID="txteml" CssClass="field"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txteml" ErrorMessage="Fill This" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td height="20" valign="top"></td>
        </tr>
        <tr>
            <td valign="top">CREATE A PASSWORD<br />
                <asp:TextBox runat="server" ID="txtpwd" TextMode="Password"
                    CssClass="field"></asp:TextBox>
                <br />
                <asp:PasswordStrength ID="txtpwd_PasswordStrength" runat="server" Enabled="True" PreferredPasswordLength="6" TargetControlID="txtpwd">
                </asp:PasswordStrength>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Fill This" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td height="20" valign="top"></td>
        </tr>
        <tr>
            <td valign="top">CONFIRM PASSWORD<br />
                <asp:TextBox runat="server" ID="txtconpwd" TextMode="Password"
                    CssClass="field"></asp:TextBox>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtconpwd" ErrorMessage="Password not match " Font-Bold="True" ForeColor="#CC0066"></asp:CompareValidator>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtconpwd" ErrorMessage="Fill This" Font-Bold="True" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td height="20" valign="top"></td>
        </tr>

        <tr>
            <td valign="top">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" />
                <asp:ImageButton ID="b1" runat="server" CssClass="pull-right"
                    ImageUrl="images/btn.jpg" OnClick="b1_Click" /></td>
        </tr>
    </table>
</asp:Content>

