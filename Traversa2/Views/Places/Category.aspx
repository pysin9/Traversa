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

    

    <% foreach(var item in categoryList) { %>
         <div class="card text-center" style="width: 18rem;">
             <%--<asp:Image ID="Image1" ImageURL="<%= item.CatImage %>" CssClass="card-img-top" runat="server" />--%>
            <img class="card-img-top" src="<%= item.CatImage %>"  src="../uploads/chicken-satay-56a8a7643df78cf7729f6e56.jpg"/>
            <div class="card-body">
         
               <a href="#" class="card-link"> <%= item.CatName %></a>
            </div>
         </div>
    <% } %>
   
    
</asp:Content>
