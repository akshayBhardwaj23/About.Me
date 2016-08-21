<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmprf.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="profile">
    <br />
    <asp:Image ID="img1"  runat="server"  width="1400" height="800" CssClass="image" />
<div class="info">
<h1><asp:Label ID="lbl1" runat ="server" /></h1>
<h3>Welcome to my page
 </h3> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:LinkButton ID="LinkButton1" runat="server" CssClass="fav" ForeColor="White" OnClick="LinkButton1_Click">Add To Favourites</asp:LinkButton>
    <br />
    <asp:Label ID="lbl2" runat ="server" /><br />
<asp:Image ID="img2" runat="server" Height="150px" Width="150px" />
    <br /><br />
	<p>  
<asp:Literal ID="lt1" runat ="server" />
    </p>  
    <p>
        <asp:GridView ID="GridView1" runat="server" Width="456px" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Social Profiles">
        <ItemTemplate>
            <a href="<%#Eval("prflnkurl") %>"><%#Eval("prflnksit") %> Profile</a>

        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>      
    <asp:LinkButton ID="LinkButton5" CssClass="fav" ForeColor="White" runat="server" OnClick="LinkButton5_Click">Recent Activity</asp:LinkButton>
</div>
</div>
</asp:Content>

