<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmfav.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="contentPart">
        <h1>Favourites</h1>


        <table style="width: 100%">


            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" CssClass="search-result" Width="648px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Profiles">
                                <ItemTemplate>
                                    <table style="width: 100%">
                                        <tr>
                                            <td rowspan="3" style="width: 185px">
                                                <img src="../prfpics/<%#Eval("prfcod") %><%#Eval("prfpic") %>"
                                                    height="120px" width="120px" border="2" />

                                            </td>
                                            <td>
                                                <b><%#Eval("prffrstnam") %> &nbsp; <%#Eval("prflstnam") %></b>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <%#Eval("prfbio") %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <a href="frmprf.aspx?pcod=<%#Eval("prfregcod") %>">View Complete Profile</a>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

