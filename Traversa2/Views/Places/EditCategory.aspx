<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="Traversa2.Views.Places.EditCategory1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/login.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container ice">
         <asp:Label ID="LblErrorr" runat="server" Text="Label"></asp:Label>
        <div class="card hot">
            <div class="card-title text-center  T">Create Category</div>
            <div class="card-body">
                <form class="text-center">
                    <asp:DataList ID="DataListk" runat="server" >
                        <ItemTemplate>
                             <div class="form-group row b">
                                 <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Current Image:</label>
                                 <div class="col-sm-5">
                                     <asp:Image ID="ImageCat" ImageUrl='<%# Bind("CatImage", "{0}") %>' runat="server" height="300px" Width="400px"/>
                                     
                                </div>
                            </div>
                              
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:Label ID="LabelCatName" runat="server" Text="Label"></asp:Label>
                    <div class="form-group row b">
                                <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">File:</label>
                                <div class="col-sm-5">
                                    <asp:FileUpload ID="FileUploadCat" runat="server" />
                                </div>
                            </div>
                            <div class="form-group row b">
                                <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Name:</label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                                <asp:LinkButton ID="LinkButtonCreate" runat="server" CssClass="btn btn-success btn-round btn-lg btn-block" >Create</asp:LinkButton>
                            </div>
                  
                    
                </form>
            </div>
        </div>
    </div>
</asp:Content>
