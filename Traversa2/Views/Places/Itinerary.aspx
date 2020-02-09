<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Itinerary.aspx.cs" Inherits="Traversa2.Views.Places.Itinerary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .b{
                position: relative;
                top: 83px;
        }
        .main{
             margin-left: 160px; /* Same as the width of the sidenav */
            font-size: 28px; /* Increased text to enable scrolling */
            padding: 0px 10px;
        }
        .t {
            width: 187px;
            display: inline-block;
        }
         .u{
            left: 469px;
            position:relative;
            display:inline-block;
        } 
        .r{
            display: inline-block;
            position: relative;
            right: 61px;
        }
        .f{
            color: cornflowerblue;
            font-family: "Trebuchet MS", Helvetica, sans-serif;
            text-align: left;
            border-style: solid;
            border-color: aliceblue;
        }
        .i{
           position: relative;
          
           left: 190px;
        }
        .h{
            position:relative;
            left: 70px;
        }
        .g{
            text-transform:capitalize;
        }
         .auto-style1 {
             position: relative;
             left: 93px;
             top: 0px;
         }
        .auto-style2 {
            width: 144%;
        }
        .auto-style3 {
            position: relative;
            left: 4px;
            top: 4px;
            width: 209px;
        }
        .auto-style6 {
            width: 332px;
        }
        .auto-style7 {
            position: relative;
            left: 93px;
            top: 0px;
            width: 209px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    
         <div class="container-fluid">
        <div class="row">
             <nav class="col-md-2 d-none d-md-block sidebar b" style="background-color: aliceblue">
                 <div class="sidebar-sticky">
                    <ul class="nav flex-column">
                         <li class="nav-item text-center">
                                   <asp:LinkButton ID="LinkButtonAll" CssClass="text-center f" Font-Size="Large" runat="server" OnClick="LinkButtonAll_Click">All</asp:LinkButton>
                          </li>
                        <asp:DataList ID="DataListCategory" OnItemCommand="DataListCategory_ItemCommand" runat="server"><ItemStyle HorizontalAlign="center" />
                            <ItemTemplate >
                                
                                <li class="nav-item">
                                     <asp:LinkButton ID="LinkButtonCat"  CommandName="select" CssClass="text-center f" runat="server" CommandArgument='<%# Eval("CatId") %>' Text='<%# Bind("CatName") %>' Font-Size="Large"></asp:LinkButton>
                                </li>
                            </ItemTemplate>
                        </asp:DataList>
                    </ul>
                </div>
            </nav>
            <div class="r">
                <h5 class="r">Places to go: </h5>
                <div class="u">
                    <asp:TextBox ID="TextBoxSearch" class="form-control mr-sm-2 t" type="search" placeholder="Search" aria-label="Search" runat="server"></asp:TextBox>
                    <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" />
                </div>
            </div>
             <br />
             <br />
            <br />
             <asp:Label ID="Label13"  runat="server" Text=""></asp:Label>
            <asp:DataList ID="DataListPlaces" runat="server"  CssClass="i"  OnItemCommand="DataListPlaces_ItemCommand">
                  <ItemTemplate>
                      <div class="row">
                              <div class="col-lg-10">
                                 <table style="width: 90%; border:2px solid grey" id="table">
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style5">
                                            <asp:Label ID="name" runat="server" Text='<%# Bind("PName") %>' style="font-weight:bold; font-size:30px; text-align:center;"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td class="auto-style5">
                                        <asp:Image ID="image" runat="server" style="width:200px; height:200px; display:block; margin-left:auto; margin-right:auto;" ImageUrl='<%# Bind("ImagePath", "{0}") %>'/>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label1" runat="server" Text="Address(es): " style="font-size:21px;"></asp:Label>
                                       
                                        
                                        <br />
                                        <asp:Label ID="desc" runat="server"  style="font-size:21px;" Text='<%# Bind("PDesc") %>'></asp:Label>
                                        <br />
                                        <br />
                                        <asp:LinkButton ID="LinkButtonPlaces" runat="server" style="font-size:21px;" CommandName="viewPlace" CommandArgument='<%# Eval("PlId") %>'>See more details</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">
                                        &nbsp;</td>
                                    <td class="auto-style4">
                                        &nbsp;</td>
                                </tr>
                                        <tr>
                                    <td class="auto-style5">
                                        &nbsp;</td>
                                    <td class="auto-style4">
                                        &nbsp;</td>
                                </tr>
                            </table>
                               </div>
                          </div>
                               
                        
                  </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
  
   
</asp:Content>

