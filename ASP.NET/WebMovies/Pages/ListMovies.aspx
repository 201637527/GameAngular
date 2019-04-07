<%@ Page Title=" List Movies" Language="C#" EnableViewState="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListMovies.aspx.cs" Inherits="WebMovies.ListMovies" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" dir="ltr">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtSearch"></asp:TextBox>



        <ajaxToolkit:AutoCompleteExtender runat="server" ClientIDMode="Static" TargetControlID="txtSearch"
            ServicePath="ListMovies.aspx"
            ServiceMethod="Search"
            MinimumPrefixLength="1"
            FirstRowSelected="true">
        </ajaxToolkit:AutoCompleteExtender>

        <asp:Button Text="Search" ClientIDMode="Static" ID="btnSearch" OnClick="btnSearch_Click" runat="server" />
        <br />



        <br />

        <asp:Label ID="lblErroe" runat="server"></asp:Label>



        <div dir="rtl" class="row">

            <asp:ListView ID="listVAllMovies" runat="server">

                <ItemTemplate>




                    <div class="col-sm-6 col-md-4 col-lg-3 mt-4">
                        <div class="card">

                            <div class="card-block">
                                <figure class="profile">
                                    <image class="card-img-top" src="<%#Eval("ImageUrlOfMovies") %>" style="height: 250px;"></image>

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
                                <asp:LinkButton ID="btnBuy" runat="server" CommandArgument='<%#Eval("MoviesID")%>' OnCommand="btnBuy_Command" Text="Buy Now!!!" CssClass="btn btn-primary">
                                </asp:LinkButton>

                            </div>
                        </div>
                    </div>


                </ItemTemplate>
            </asp:ListView>

        </div>
    </div>









</asp:Content>

