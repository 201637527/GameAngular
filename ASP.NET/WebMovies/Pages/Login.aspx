<%@ Page  Title=" Login "    Language="C#"  EnableViewState="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebMovies.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-5">
    <div class="row">
        <div class="col-md-12">
         
            <div class="row">
                <div class="col-md-6 mx-auto">

                    <div class="card rounded-0">
                        <div class="card-header">
                            <h3 class="mb-0">Login</h3>
                        </div>
                        <div class="card-body">
                           
                                <div class="form-group">
                                    <asp:Label  ID="lblUsername" runat="server" Text="Username" ></asp:Label>
                                    <asp:TextBox ID="txtUsername" runat="server"  EnableViewState="false" ClientIDMode="Static"  placeholder="Enter User Name"  Class="form-control"></asp:TextBox>
                                    <div>
                                     <asp:Label ID="lblerroe1" Text="" ClientIDMode="Static" runat="server"></asp:Label>
                                  </div>
                                </div>
                                <div class="form-group">
                                   <asp:Label ID="lblPass" runat="server" Text="Password" ></asp:Label>
                                    <asp:TextBox ID="txtPASS" ClientIDMode="Static" TextMode="Password"   EnableViewState="false" placeholder="Enter Password" runat="server" Class="form-control"></asp:TextBox>
                                    
                                    <asp:Label ID="lblerroe2" Text="" ClientIDMode="Static" runat="server"></asp:Label>
                                </div>
                                <div>
                                <asp:Label ID="lblCheck" runat="server" Text="Remmber me" class="custom-control custom-checkbox"></asp:Label>
                                <asp:CheckBox ID="CheckBoxRemmeber" ClientIDMode="Static"  Checked="false"  runat="server" />
                                    
                                    
                                   
                                </div>
                                <asp:LinkButton ClientIDMode="Static" ID="linkToRegister" PostBackUrl="~/Pages/Register.aspx" runat="server">I forget password</asp:LinkButton>

                                <asp:Button ID="btnLgin" runat="server" ClientIDMode="Static"  OnClick="btnLgin_Click"  Text="Login" CssClass="btn btn-secondary btn-lg btn-block" />
                               
                          
                        </div>
                        
                    </div>
                  
                </div>


            </div>
          
        </div>
       
    </div>
   
</div>

   


</asp:Content>
