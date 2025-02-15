﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Viewitinerary.aspx.cs" Inherits="Traversa2.Views.MyItinenary.Viewitinerary" %>
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
            left: 10px;
            position:relative;
            display:inline-block;
        }
        .i{
            display: inline-block;
        }
        .p{
            display:inline-block;
            position: relative;
             bottom: 9px;
              left: 8px;
        }
        .dropdown-menu{
            width: 930px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <div class="text-center">
        <asp:Label ID="Labelerr" runat="server" Text=""></asp:Label>
    </div>
    
    <div class="container">
        <h5 class="r">My Itinerary: </h5>
        <div class="u">
            <asp:LinkButton ID="LbtnCreate"  class="btn btn-info" runat="server" OnClick="LbtnCreate_Click">Create</asp:LinkButton>
        </div>   
    <br />
    <br />

    
    <div class=" container">
        <div class="text-center">
             <asp:Label ID="LabelMessage" runat="server" Text="Nothing to see here" Visible="true"></asp:Label>
        </div> 
        <asp:DataList ID="DataListItinName" runat="server" Visible="false" CssClass="i" OnItemCommand="DataListItinName_ItemCommand">
            <ItemTemplate >
                <div class="dropdown">
                    <asp:Button ID="Buttonname" CommandName="Show"  class="btn btn-secondary dropdown-toggle btn-lg" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server" Text='<%# Bind("IName") %>' CommandArgument='<%#Eval("PlId") %>'/>
                     <div class="dropdown-menu" aria-labelledby="dropdownMenu2">
                         <table style="width: 100%;">
                             <tr>
                                 <td>
                                     <asp:Image ID="Imagepl" runat="server" ImageUrl='<%# Bind("image") %>' width="150px" Height="150px"/>
                                 </td>
                                 <td>
                                     <asp:Label ID="Labelna" runat="server" Text='<%# Bind("PName") %>'></asp:Label>
                                 </td>
                                 <td>
                                     <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ItinId") %>'>Edit</asp:LinkButton>
                                 </td>
                                 <td>
                                     <asp:LinkButton ID="LinkButtonDEL" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ItinId") %>'>Delete</asp:LinkButton>
                                 </td>
                             </tr>
                             
                         </table>
                       </div>
                      </div>
                </ItemTemplate>
           </asp:DataList>
        </div>
        </div>

        
    
</asp:Content>
