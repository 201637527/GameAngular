<%@ Page Title="Login Manager"  EnableViewState="false" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginAmin.aspx.cs" Inherits="WebMovies.Pages.LoginAmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    <div class="container" dir="ltr">
        <h1>Welcome Manager</h1>
        <div class="row">
            
            <div class="col-4">

                <div class="card-body">

                    <div class="form-group">
                        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                        <asp:TextBox ID="txtUsername"  runat="server" EnableViewState="false" ClientIDMode="Static" placeholder="Enter User Name" Class="form-control"></asp:TextBox>
                        <div>
                            <asp:Label ID="lblerroe1" Text="" ClientIDMode="Static" runat="server"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="txtPASS" TextMode="Password" ClientIDMode="Static" EnableViewState="false" placeholder="Enter Password" runat="server" Class="form-control"></asp:TextBox>

                        <asp:Label ID="lblerroe2" Text="" ClientIDMode="Static" runat="server"></asp:Label>
                    </div>
                  
                    <asp:Button ID="btnLgin" runat="server" ClientIDMode="Static"  OnClick="btnLgin_Click" Text="Login" CssClass="btn btn-secondary btn-lg btn-block" />
                   
                    <asp:Label ID="lblMassage" runat="server"></asp:Label>
                </div>


            </div>
        </div>
    </div>
        <script src="../Scripts/LoginAdmin.js"></script>

</asp:Content>
