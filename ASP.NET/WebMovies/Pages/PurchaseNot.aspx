<%@ Page Title="Purchase"  EnableViewState="false" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PurchaseNot.aspx.cs" Inherits="WebMovies.Pages.PurchaseNot" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="card">
            
                <p>
                Your order has been successfully placed!!!<br />
                Thanks for the invitation!!!<br />
                For any questions, please call 05099999.
             
            </p>
        </div>
    <asp:Button ID="btnSingOut" runat="server" Text="SingOut" CssClass="btn-primary" OnClick="btnSingOut_Click" />
</asp:Content>
