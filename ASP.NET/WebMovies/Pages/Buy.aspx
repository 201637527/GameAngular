<%@ Page Title="Buy" Language="C#" EnableViewState="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Buy.aspx.cs" Inherits="WebMovies.Buy" %>

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
                <asp:Label class="card-title mt-3" ID="lblDescription" runat="server" ></asp:Label>

                <div class="meta">
                </div>
                <div class="card-text">
                    <asp:Label ID="lblMovieDirector" runat="server"></asp:Label>
                    <div class="card-footer">
                          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <ajaxToolkit:Rating ID="RatingMovies" runat="server"
                            
                                 StarCssClass="straRating" 
                                 FilledStarCssClass="filldStar" 
                                 EmptyStarCssClass="EmptyStar"
                                  WaitingStarCssClass="witingStar"

                                  MaxRating="4">
                        </ajaxToolkit:Rating>
                    </ContentTemplate>

                </asp:UpdatePanel>
                        </div>
                </div>
            </div>
            <div class="card-footer">

         

                <asp:Label ID="lblMasage" runat="server" Text="Please put how much card do you want to buy" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="txtCard" TextMode="Number" ClientIDMode="Static" CssClass="form -control" min="1" max="10" step="1"  runat="server"></asp:TextBox>
                <asp:LinkButton ID="btnBuy" runat="server" ClientIDMode="Static" CommandArgument='<%#Eval("MoviesID")%>' OnCommand="btnBuy_Command" Text="Buy Now!!!" CssClass="btn btn-primary">
                        
                </asp:LinkButton>
                <asp:Label ID="lblwarning" Font-Size="X-Large" Font-Bold="true" ClientIDMode="Static" runat="server"></asp:Label>
                
            </div>
        </div>
    </div>
    

    <%--<div dir="rtl" class="row">




        <table class="card  mx-auto" style="width: 200px;">

            <tr>
                <td>
                    <asp:Label ID="lblMoviesName" CssClass="card-title" runat="server"></asp:Label>

                </td>
            </tr>
            <tr>
                <td class="card-body">
                    <asp:Label ID="lblMovieDirector" class="card-title" runat="server"></asp:Label>

                </td>
            </tr>

            <tr>
                <td class="card-body">
                    <asp:Label ID="lblDescription" CssClass="card-title" runat="server" Text="Label"></asp:Label>

                </td>
            </tr>

            <tr>
                <td>
                    <asp:Image ID="Image1" class="card-img-top" runat="server" Style="width: 100px" />

                </td>
            </tr>




            <tr>

                <td>

                    <div>






                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <ajaxToolkit:Rating ID="RatingMovies" runat="server"
                                    StarCssClass="straRating"
                                    FilledStarCssClass="filldStar"
                                    EmptyStarCssClass="EmptyStar"
                                    WaitingStarCssClass="witingStar" 
                                    MaxRating="4">
                                </ajaxToolkit:Rating>
                            </ContentTemplate>

                        </asp:UpdatePanel>

                    </div>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:TextBox ID="txtCard" TextMode="Number"  ClientIDMode="Static"  CssClass="form -control" min="1" max="10" step="1"  runat="server"></asp:TextBox>
                      <asp:LinkButton ID="btnBuy" runat="server" ClientIDMode="Static" CommandArgument='<%#Eval("MoviesID")%>' OnCommand="btnBuy_Command" Text="Buy Now!!!" CssClass="btn btn-primary">
                        
                                </asp:LinkButton>
                      <asp:Label ID="lblwarning" Font-Size="X-Large" Font-Bold="true" ClientIDMode="Static" runat="server"></asp:Label>
                
                </td>
            </tr>

        </table>--%>
</asp:Content>
