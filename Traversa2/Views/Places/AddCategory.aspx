<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="Traversa2.Views.Places.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div runat="server" id="alertSuccess" role="alert">
        <asp:Label ID="lblAlert" runat="server" Text=""></asp:Label>
    </div>
    <div class="container ice">
        <div class="card hot">
            <div class="card-title text-center  T">Create Category</div>
            <div class="card-body">
                <form class="text-center">
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Category Image:</label>
                        <div class="col-sm-5">
                            <asp:FileUpload ID="FileUploadImage" runat="server" />
                        </div>
                    </div>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Category Name:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="NameTB" runat="server" type="text" class="form-control form-control-lg"  placeholder="Enter your password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                        <asp:Button ID="btnCreate" class="btn btn-success btn-round btn-lg btn-block" runat="server" Text="Create" OnClick="btnCreate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
