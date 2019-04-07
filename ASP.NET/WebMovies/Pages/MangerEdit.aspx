<%@ Page Language="C#" Title="Manger Admin edit" EnableViewState="false" AutoEventWireup="true" CodeBehind="MangerEdit.aspx.cs" Inherits="WebMovies.MangerEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>





    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div>
            <asp:GridView ID="gvAdmin" runat="server" EnableViewState="false" SkinID="gvAdmin"
                AutoGenerateColumns="False" ShowFooter="True" DataKeyNames="MoviesID" OnRowDataBound="gvAdmin_RowDataBound" OnRowEditing="gvAdmin_RowEditing" OnRowDeleting="gvAdmin_RowDeleting" OnRowCancelingEdit="gvAdmin_RowCancelingEdit" CellPadding="4" Height="343px" Width="1044px" OnRowUpdating="gvAdmin_RowUpdating1" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:TemplateField HeaderText="MoviesID"  Visible="false" SortExpression="MoviesID">
                        <EditItemTemplate>
                            <asp:Label ID="lblMoviesID" runat="server" Text='<%# Eval("MoviesID") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEditMovies" runat="server" Text='<%# Bind("MoviesID") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NameMovies" SortExpression="NameMovies">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNameMoviesEdit" ClientIDMode="Static" CssClass="form-control" AutoPostBack="false" EnableViewState="false" runat="server" Text='<%#Bind("NameMovies") %>'></asp:TextBox>
                            <asp:Label ID="lblMaseEr1" runat="server" ClientIDMode="Static"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNameMovies" runat="server" Text='<%# Bind("NameMovies") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ImageUrlOfMovies" SortExpression="ImageUrlOfMovies">
                        <EditItemTemplate>


                            <asp:FileUpload ID="FileUpload1" ClientIDMode="Static" runat="server" accept=".jpg,.jpeg,.png" />

                            <asp:Label ID="lblErroe" runat="server"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" CssClass="card-img-top" ImageUrl='<%#Eval("ImageUrlOfMovies") %>' runat="server" />


                        </ItemTemplate>



                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="MovieDirector" SortExpression="MovieDirector">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMovieDirector" runat="server" CssClass="form-control" ClientIDMode="Static" Text='<%# Bind("MovieDirector") %>'></asp:TextBox>
                            <asp:Label ID="lblMaseEr2" runat="server" ClientIDMode="Static"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblMoviesDirector" runat="server" Text='<%# Bind("MovieDirector") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Description" SortExpression="Description">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDescription" TextMode="MultiLine" CssClass="form-control" ClientIDMode="Static"  AutoPostBack="false" EnableViewState="false" runat="server" Text='<%# Bind("Description") %>'></asp:TextBox>
                            <asp:Label ID="lblMaseEr3" runat="server" ClientIDMode="Static"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDescription" runat="server"  Text='<%# Bind("Description") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Inventory" SortExpression="Inventory">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtInventory" CssClass="form-control" ClientIDMode="Static"  AutoPostBack="false" EnableViewState="false" runat="server" Text='<%# Bind("Inventory") %>'></asp:TextBox>
                            <asp:Label ID="lblMaseEr4" runat="server" ClientIDMode="Static"></asp:Label>


                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="txtInventory" runat="server" Text='<%# Bind("Inventory") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Rating" SortExpression="Rating">
                        <EditItemTemplate>
                            <asp:Label ID="lblRatingEdit" runat="server" Text='<%# Bind("Rating") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblRating" runat="server" Text='<%# Bind("Rating") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Category" SortExpression="CategoryID_CategoryID">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropCategry" ClientIDMode="Static" runat="server" AppendDataBoundItems="true">
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCategory"    runat="server" Text='<%# Bind("discription") %>'></asp:Label>

                        </ItemTemplate>
                       
                    </asp:TemplateField>


                    <asp:CommandField ButtonType="Button"   ShowEditButton="true" EditText="Edit" />

                    <asp:CommandField ShowDeleteButton="True" DeleteText="Delet" ButtonType="Button" />
                    <asp:CommandField ShowCancelButton="True" />




                </Columns>


                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />


            </asp:GridView>

          

            <hr />
            <br />
            <div class="card-body">

                <div class=" card-footer">
                    <div class="form-group">
                        <asp:TextBox ID="txtNameMoviesIsert" EnableViewState="true" CssClass="form-control" placeholder="Enter Name Movies" ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:Label ID="lblerroe1" runat="server" Font-Bold="true" ClientIDMode="Static"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:FileUpload ID="FileUploadIsert"   CssClass="form-control" placeholder="Enter file image of Movies" ClientIDMode="Static" runat="server" accept=".jpg,.jpeg,.png" />
                        <asp:Label ID="lblerroe2" runat="server" Font-Bold="true" ClientIDMode="Static"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtMovieDirectorIsert" EnableViewState="true" CssClass="form-control" placeholder="Enter Director Movies" ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:Label ID="lblerroe3" runat="server" Font-Bold="true" ClientIDMode="Static"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ClientIDMode="Static" EnableViewState="true" placeholder="Enter Description" TextMode="MultiLine" CssClass="form-control" ID="txtDescriptionIsert" runat="server"></asp:TextBox>

                        <asp:Label ID="lblerroe4" runat="server" Font-Bold="true" ClientIDMode="Static"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtInventoryInsert" EnableViewState="true" placeholder="Enter Inventory" CssClass="form-control" ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:Label ID="lblerroe5" runat="server" Font-Bold="true" ClientIDMode="Static"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:DropDownList ID="DropCategryInsert" CssClass="form-control"  ClientIDMode="Static"  EnableViewState="true" runat="server" AppendDataBoundItems="true">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="linkInsert" ClientIDMode="Static" CssClass="btn btn-primary" OnClick="linkInsert_Click1" runat="server" Text="Isert" ForeColor="Red" Font-Size="XX-Large" />
                    </div>

                </div>
            </div>
        </div>
        <div dir="rtl" class="container">
            <asp:Button ID="btnSingOut" runat="server" Text="SingOut" Font-Size="XX-Large" Font-Bold="true" ForeColor="Red" OnClick="btnSingOut_Click" />
            <br />
            <hr />
           
        </div>
    </form>


    <script src="https://code.jquery.com/jquery-3.2.1.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>

    <script src="../Scripts/EditAdmin.js"></script>

</body>
</html>
