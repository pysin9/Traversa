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
    <div class="container">
         <div class=".col-lg-4 .col-lg-offset-2">
             <h5 class="r">List of Categories: </h5>
    <div class="u">
        
        <input class="form-control mr-sm-2 t" type="search" placeholder="Search" aria-label="Search">
        <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" />
    </div>
    
    <br />
    <asp:DataList ID="DataListCategory" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="DataListCategory_ItemCommand" >
        <ItemTemplate >
            <div class="card text-center r" style="width: 16.5rem; height: 17rem;">
                <asp:Image ID="Image2" class="card-img-top" ImageUrl='<%# Bind("CatImage", "{0}") %>' runat="server" height="211px"  width="262.5px"/>
                <br />
                
                <div class="card-body">
                   <asp:LinkButton ID="LinkButtonCategory" runat="server" Text='<%# Bind("CatName") %>' CommandName="Go" CommandArgument='<%# Eval("CatId") %>' ></asp:LinkButton>
                </div>
                </div>
        </ItemTemplate>
    </asp:DataList> 
         </div>
    </div>
    


   
    
</asp:Content>
