<%@ Page Title="One Movie"  EnableViewState="false" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OneMovies.aspx.cs" Inherits="WebMovies.Pages.OneMovies" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>








    <div class="col-sm-6 col-md-4 col-lg-3 mt-4">
        <div class="card">

            <div class="card-block">
                <figure class="profile">

                    <asp:Image class="card-img-top" ID="Image1" runat="server" />
                    <asp:Label class="card-text" ID="lblMoviesName" runat="server"></asp:Label>
                </figure>
                <asp:Label class="card-title mt-3" ID="lblDescription" runat="server" Text="Label"></asp:Label>

                <div class="meta">
                </div>
                <div class="card-text">
                    <asp:Label ID="lblMovieDirector" runat="server"></asp:Label>


                </div>
            </div>
            <div class="card-footer">



               
                <asp:Button ID="btnBuy" CssClass="btn btn-primary" OnClick="btnBuy_Click" runat="server" Text="Buy Now" />
            </div>
        </div>
    </div>









    
</asp:Content>
