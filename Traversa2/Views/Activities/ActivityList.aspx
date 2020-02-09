<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ActivityList.aspx.cs" Inherits="Traversa2.Views.Activities.ActivityList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
        
        .f{
            color: cornflowerblue;
            font-family: "Trebuchet MS", Helvetica, sans-serif;
            text-align: left;
            border-style: solid;
            border-color: aliceblue;
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
                <asp:DataList ID="DataListCategory" OnItemCommand="DataListCategory_ItemCommand" runat="server">
                    <ItemStyle HorizontalAlign="center" />
                    <ItemTemplate>
                        <li class="nav-item">
                            <asp:LinkButton ID="LinkButtonCat" CommandName="select" CssClass="text-center f" runat="server" CommandArgument='<%# Eval("CatId") %>' Text='<%# Bind("CatName") %>' Font-Size="Large"></asp:LinkButton>
                        </li>
                    </ItemTemplate>
                </asp:DataList>
            </ul>
        </div>
    </nav>

    <br />
             <br />
            <br />
             <asp:Label ID="Label13"  runat="server" Text=""></asp:Label>
            <asp:DataList ID="DataListActivity" runat="server"  CssClass="i" OnItemCommand="DataListActivity_ItemCommand">
                  <ItemTemplate>
                      <div class="container i">
                          <div class="card" style="width:850px; height: 14rem;">
                                <div class="row no-gutters">
                                    <div class="col-md-4">
                                        <asp:Image ID="ImagePlaces" runat="server" ImageUrl='<%# Bind("ImagePath", "{0}") %>' height="221px"  width="230px" />
                                    </div>
                                      <div class="col-md-8">
                                          <div class="card-body h">
                                              <asp:Label ID="lblAcId" runat="server" Text='<%# Bind("AcId") %>' Visible="false"></asp:Label>
                                             <asp:Label ID="Label1" CssClass="card-title g" runat="server" Text='<%# Bind("AName") %>' Font-Bold="True" Font-Size="Larger"></asp:Label>
                                            <br />
                                            <br />
                                            <asp:Label ID="Label2" CssClass="card-text" runat="server" Text='<%# Bind("ADesc") %>'></asp:Label>
                                              <br />
                                              <br />
                                            <div class="card-action">
                                            <asp:LinkButton ID="LinkButtonActivity" runat="server" CommandName="FindOutMore" >Find Out More...</asp:LinkButton>
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
