<%@ Page Title="Home Page" Language="C#" EnableViewState="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebMovies.HomePage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" EnableViewState="false">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <div class="container" dir="ltr">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtSearch"></asp:TextBox>

        <asp:Label ID="lblErroe" ClientIDMode="Static" runat="server"></asp:Label>

        <ajaxToolkit:AutoCompleteExtender ClientIDMode="Static" runat="server" TargetControlID="txtSearch"
            ServicePath="HomePage.aspx"
            ServiceMethod="Search"
            MinimumPrefixLength="1"
            FirstRowSelected="true">
        </ajaxToolkit:AutoCompleteExtender>

        <asp:Button Text="Search" ID="btnSearch" OnClick="btnSearch_Click" ClientIDMode="Static" runat="server" />
        <br />
        <br />


        <h1>This Movies Popular</h1>
        <div dir="ltr" class="row">




            <asp:ListView ID="LViewBestM" runat="server" OnItemDataBound="LViewBestM_ItemDataBound" >

                <ItemTemplate>



                     <div class="col-sm-6 col-md-4 col-lg-3 mt-4">
                        <div class="card">
                            
                            <div class="card-block">
                                <figure class="profile">
                                    <image class="card-img-top" src="<%#Eval("ImageUrlOfMovies") %>" style=" height: 250px; ></image>
                                    <p class="card-text"><%#Eval("NameMovies")%></p>
                                </figure>
                                <h4 class="card-title mt-3"><%#Eval("MovieDirector") %></h4>
                                <div class="meta">
                                    
                                </div>
                                <div class="card-text">
                                    
                                     <h6 class="card-title"><%#Eval("Description") %></h6>
                       
                                </div>
                            </div>
                            <div class="card-footer">
                                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <ajaxToolkit:Rating ID="RatingBestMO" runat="server"
                                                    StarCssClass="straRating"
                                                    FilledStarCssClass="filldStar"
                                                    EmptyStarCssClass="EmptyStar"
                                                    WaitingStarCssClass="witingStar" ReadOnly="true" CurrentRating="0"
                                                    MaxRating="4">
                                                </ajaxToolkit:Rating>
                                            </ContentTemplate>

                                        </asp:UpdatePanel>

                                <asp:LinkButton ID="btnBuy" runat="server" CommandArgument='<%#Eval("MoviesID")%>' OnCommand="btnBuy_Command" Text="Buy Now!!!" CssClass="btn btn-primary">
                                </asp:LinkButton>

                            </div>
                        </div>
                    </div>
                </ItemTemplate>

            </asp:ListView>


        </div>
    </div>

    <asp:Label ID="lblMasse" Text="t" ForeColor="Green" EnableViewState="true" ClientIDMode="Static" runat="server" Font-Size="XX-Large"></asp:Label>
</asp:Content>
