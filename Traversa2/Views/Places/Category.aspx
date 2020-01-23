<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Traversa2.Views.Places.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/category.css" rel="stylesheet" />
    <style>
        .card {
            display:inline-block;
            margin: 0.5rem;
            position: relative;
            left: 60px;
        }
        .t{
           width: 187px;
           display: inline-block;

        }
        .r{
            display: inline-block;
        }
        .u{
            left: 669px;
            position:relative;
            display:inline-block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h5 class="r">List of Categories: </h5>
    <div class="u">
        <input class="form-control mr-sm-2 t" type="search" placeholder="Search" aria-label="Search">
        <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" />
    </div>
    
    <br />

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="card text-center" style="width: 18rem;">
                <asp:Image ID="Image2" ImageUrl='<%# Bind("CatImage", "{0}") %>' runat="server" />
                <div class="card-body">
         
               <a href="#" class="card-link"> <%= Bind("CatName") %></a>
            </div>
         </div>
        </ItemTemplate>
    </asp:DataList>


   
    
</asp:Content>
