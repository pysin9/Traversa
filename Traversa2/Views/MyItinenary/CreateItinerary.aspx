<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="CreateItinerary.aspx.cs" Inherits="Traversa2.Views.MyItinenary.CreateItinerary" %>
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
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <div class="container">
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
                <div class="u">
                    <input class="form-control mr-sm-2 t" type="search" placeholder="Search" aria-label="Search">
                    <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label13"  runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LabelNAme" class="r" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click" />
                </div>
            </div>
             <br />
             <br />
            <br />
            <asp:DataList ID="DataListIt" runat="server"  CssClass="i" OnItemCommand="DataListIt_ItemCommand" >
                  <ItemTemplate>
                          <div class="row">
                              <div class="col-lg-10">
                                 <table style="width: 70%; border:2px solid grey" id="table">
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style5">
                                            <asp:Label ID="name" runat="server" Text='<%# Bind("PName") %>' style="font-weight:bold; font-size:20px; text-align:center;"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td class="auto-style5">
                                        <asp:Image ID="image" runat="server" style="width:200px; height:200px; display:block; margin-left:auto; margin-right:auto;" ImageUrl='<%# Bind("ImagePath", "{0}") %>'/>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label1" runat="server" Text="Descriptions: " style="font-size:18px;"></asp:Label>
                                        <asp:Label ID="PlLabel" runat="server" Visible="false" Text='<%# Bind("PlId") %>'> </asp:Label>
                                        
                                        <br />
                                        <asp:Label ID="desc" runat="server"  style="font-size:18px;" Text='<%# Bind("PDesc") %>'></asp:Label>
                                        <br />
                                        <asp:LinkButton ID="LinkButtonPlaces" runat="server" style="font-size:21px;" CommandName="viewPlace" CommandArgument='<%# Eval("PlId") %>'>See more details</asp:LinkButton>
                                         
                                    </td>
                                        <td>
                                             &nbsp;&nbsp;&nbsp;&nbsp;
                                            <%-- <asp:CheckBox ID="CheckBoxAdd" class="r" runat="server" Width="100px" Height="100px"  />--%>
                                            <asp:ImageButton ID="ImageButtonAd" runat="server" Width="50px" Height="50px" ImageUrl="~/images/plus--v1.png" CommandArgument='<%# Eval("PlId") %>' CommandName="AddPl"/>
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
    </div>
    
</asp:Content>
