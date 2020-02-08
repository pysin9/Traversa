﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Itinerary.aspx.cs" Inherits="Traversa2.Views.Places.Itinerary" %>
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
            left: 669px;
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
           top: 39px;
           right: 112px;
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
                <asp:Label ID="LabelNAme" class="r" runat="server" Text="Choose a the places to go"></asp:Label>
                <div class="u">
                    <asp:TextBox ID="TextBoxSearch" class="form-control mr-sm-2 t" type="search" placeholder="Search" aria-label="Search" runat="server"></asp:TextBox>
                    <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" />
                </div>
            </div>
             <br />
             <br />
            <br />
             <asp:Label ID="Label13"  runat="server" Text=""></asp:Label>
            <asp:DataList ID="DataListPlaces" runat="server"  CssClass="i">
                  <ItemTemplate>
                      <div class="container i">
                          <div class="card" style="width:600px; height: 13.3rem;">
                                <div class="row no-gutters">
                                    <div class="col-md-4">
                                        <asp:Image ID="ImagePlaces" runat="server" ImageUrl='<%# Bind("ImagePath", "{0}") %>' height="211px"  width="262.5px" />
                                    </div>
                                      <div class="col-md-8">
                                          <div class="card-body h">
                                             <asp:Label ID="Label1" CssClass="card-title g" runat="server" Text='<%# Bind("PName") %>' Font-Bold="True" Font-Size="Larger" ForeColor="Silver"></asp:Label>
                                            <br />
                                            <br />
                                            <asp:Label ID="Label2" CssClass="card-text" runat="server" Text='<%# Bind("PDesc") %>'></asp:Label>
                                            <br />
                                              <br />
                                              <br />
                                            <div class="card-action">
                                            <asp:Button ID="BtnSearch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Search" OnClick="BtnSearch_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                          </div>

                               
                        
                  </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>

