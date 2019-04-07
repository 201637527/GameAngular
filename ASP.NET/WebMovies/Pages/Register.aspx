<%@ Page Title="Register " Language="C#" MasterPageFile="~/MasterPage.Master" EnableViewState="false" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebMovies.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" dir="ltr">


    <asp:Label ID="lblMasseg" runat="server"></asp:Label>


    <div class="container py-5">
        <div class="row">
            <div class="col-md-12">
                <div class="row">

                    <div class="col-md-6 mx-auto">

                        <div class="card rounded-0">
                            <div class="card-header">


                                <asp:TextBox CssClass="form-control"  EnableViewState="true" ID="txtNameFirst" ClientIDMode="Static" placeholder="Enter First Name" runat="server" />

                               

                                <asp:Label ID="lbltxtUserMaseeg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>


                                <asp:TextBox CssClass="form-control" ID="txtLastName" ClientIDMode="Static" placeholder="Enter Last Name" runat="server" />
                                 <asp:Label ID="lblLastNameMaseeg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>





                                <asp:TextBox CssClass="form-control" ID="txtUser" ClientIDMode="Static" placeholder="Enter User Name" runat="server" />
                                <asp:Label ID="lbltxtUserMassge" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
                               


                                <asp:TextBox CssClass="form-control" TextMode="Email"  ClientIDMode="Static" ID="txtEmail" placeholder="Enter Email" runat="server" />
                                 <asp:Label ID="lblEmailMasseg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
                              



                                <div class="form-inline">
                                    <asp:DropDownList ID="DropPhone" class="form-control mb-2 mr-sm-2" ClientIDMode="Static" runat="server">
                                        <asp:ListItem>050</asp:ListItem>
                                        <asp:ListItem>052</asp:ListItem>
                                        <asp:ListItem>054</asp:ListItem>
                                        <asp:ListItem>053</asp:ListItem>
                                    </asp:DropDownList>-
                                 <asp:TextBox ID="txtPone"   class="form-control mb-2 mr-sm-2" ClientIDMode="Static" placeholder="Enter User Name" runat="server" />
                                     <asp:Label ID="lblPhoneMasseg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
                                   

                                </div>


                                

                                <asp:TextBox CssClass="form-control" TextMode="Password"  ClientIDMode="Static" ID="txtPass" placeholder="Enter Password" runat="server" />
                                 <asp:Label ID="lblPasswordMasseg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
                              

                                <asp:TextBox CssClass="form-control" TextMode="Password" ClientIDMode="Static" ID="txtComperPass" placeholder="Compare Password" runat="server" />
                                 <asp:Label ID="lblComperPassMasseg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>

                                

                                <asp:TextBox ID="txtCardToBuy"   ClientIDMode="Static" placeholder="Enter Credit Card"  CssClass="form-control"  runat="server"></asp:TextBox>
                                  <asp:Label ID="lblCreditMasseg" ClientIDMode="Static" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
                                
                                
                                <asp:Button Text="log on" CssClass="btn btn-primary" ID="btnLogin" runat="server" ClientIDMode="Static" OnClick="btnLogOn_Click" />
                                <asp:Label Text="Remmber Me" runat="server" />
                                <asp:CheckBox ID="CheckBox1" runat="server" />





                                <div class="container">
                                    <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" HeaderText="Error" runat="server" DisplayMode="List" ShowMessageBox="False" />
                                    <asp:Label ID="lblMaseg" Font-Size="X-Large" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

































     
</asp:Content>
