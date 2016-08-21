<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="HomeEdit.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid page-header">
        <h1><small>
            <asp:Label ID="Label1" runat="server" Text="Edit Post"></asp:Label></small></h1>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-9">
                <form class="form-horizontal" role="form">
                    <div class="form-group">
                        <asp:Label Font-Size="Large" Font-Bold="true" CssClass="control-label col-sm-2" runat="server">Heading</asp:Label>
                        <div class="col-sm-10">                            
                            <asp:TextBox ID="txthead" CssClass="form-control input-lg" placeholder="Enter Heading" runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label Font-Bold="true" Font-Size="Large" CssClass="control-label col-sm-2" runat="server">Content</asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox CssClass="form-control" TextMode="MultiLine" rows="20" id="txtdsc" placeholder="Enter Content" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="control-label col-sm-2" Font-Bold="true" Font-Size="Large" runat="server">Add Image</asp:Label>
                        <div class="col-sm-10">
                            <asp:FileUpload ID="FileUpload1" runat="server" Height="28px" Width="497px" />
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="form-control-static">                        
                        <div class="col-sm-offset-2 col-sm-10">                            
                            <asp:Button ID="btn1" CssClass="btn btn-success" runat="server" Text="Update" OnClick="btn1_Click1" />&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btn2" CssClass="btn btn-default" runat="server" Text="Cancel" OnClick="btn2_Click1"/>
                        </div>                        
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

