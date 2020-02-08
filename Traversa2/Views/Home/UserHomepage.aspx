<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="UserHomepage.aspx.cs" Inherits="Traversa2.Views.Home.UserHomepage" %>
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
             <h5 class="r">Popular by Ratings: </h5>
    <br />
    <asp:DataList ID="DatalistRating" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
        <ItemTemplate >
            <div class="card text-center r" style="width: 13rem; height: 15rem;">
                <asp:Image ID="Image2" class="card-img-top" ImageUrl='<%# Bind("ImagePath", "{0}") %>' runat="server" height="165px"  width="206px"/>
                <br />
                
                <div class="card-body">
                   <asp:Label ID="Label1" runat="server" Text='<%# Bind("AvgRating") %>'></asp:Label><asp:Label ID="Label2" runat="server" Text="/5"></asp:Label>
                    <br />
                   <asp:LinkButton ID="LinkButtonRating" runat="server" Text='<%# Bind("PName") %>' CommandName="Go" CommandArgument='<%# Eval("PlId") %>' ></asp:LinkButton>
                </div>
                </div>
        </ItemTemplate>
    </asp:DataList> 
         </div>
    </div>
</asp:Content>
