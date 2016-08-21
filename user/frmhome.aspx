<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmhome.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style>
        .OrderHistory_RowSeparator { margin: 0px 0px 7px 0px; }
        #c {
            padding-top:100px;
            padding-bottom: 10px;
        }
    </style>
    <div class="container-fluid page-header">
        <h1><small>
            <asp:Label ID="Label1" runat="server" Text="Recent Post"></asp:Label></small></h1>
    </div>

    <div class="row">
        <div class="col-md-1"></div>
        <div class="container-fluid col-md-8 ">
            <div class="page-header">
                <h2>
                    <asp:Label ID="lbl1" runat="server"></asp:Label></h2>
                <h4><span class="glyphicon glyphicon-time"></span><small>Post By
                <asp:Label ID="lbl2" runat="server" />, on
                <asp:Label ID="lbl3" runat="server" /></small>
                    <asp:LinkButton ID="lkUpdate" CssClass="btn btn-sm btn-info pull-right" runat="server" OnClick="lkUpdate_Click">Update Post</asp:LinkButton></h4>

            </div>
            <div class="container-fluid">
                <div>
                    <asp:Image ID="img1" class="img-responsive" Width="800" runat="server" />
                </div>
                <hr />
                <div class="col-md-11">
                    <p class="text-justify">
                        <asp:Label ID="lbl4" runat="server"></asp:Label>
                    </p>
                </div>
            </div>
            <br />
        </div>
        <div class="col-md-3">
            <asp:LinkButton ID="lk1" CssClass="btn btn-lg btn-success" runat="server" OnClick="lk1_Click">
                <span class="glyphicon glyphicon-pencil"></span> New
            </asp:LinkButton>

            <div id="c" class="container-fluid">
                <h2><small>
                    <asp:Label ID="lbpost" CssClass="page-header" runat="server" Text="Posts :"></asp:Label></small></h2><br /><br />
                <asp:DataList ID="DataList1" runat="server" DataKeyField="blgcod" BackColor="White" Font-Size="Large" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                    <SeparatorTemplate>
                        <h4 class="OrderHistory_RowSeparator"></h4>
                    </SeparatorTemplate>
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" CommandName="Select" runat="server" Text='<%# Eval("blghed") %>'></asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </div>
</asp:Content>