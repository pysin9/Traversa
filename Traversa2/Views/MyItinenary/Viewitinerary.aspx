<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Viewitinerary.aspx.cs" Inherits="Traversa2.Views.MyItinenary.Viewitinerary" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <div class="container">
        <h5 class="r">My Itinerary: </h5>
    <div class="u">
        <asp:LinkButton ID="LinkButtonCreate" class="btn btn-outline-info" runat="server" Text="Create" OnClick="LinkButtonCreate_Click"></asp:LinkButton>
    </div>
    
    <br />
    <div class="container">
        <asp:DataList ID="DataListCategory" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" >
        <ItemTemplate >
            <div class="card text-center r" style="width: 16.5rem; height: 17rem;">
                <asp:Image ID="Image2" class="card-img-top"  runat="server" height="211px"  width="262.5px" Visible="false"/>
                <br />
                <div class="card-body">
                   <asp:LinkButton ID="LinkButtonView" runat="server" Text="See" Visible="false" Font-Bold="True" Font-Size="Larger" ></asp:LinkButton>
                </div>
                </div>
        </ItemTemplate>
    </asp:DataList>
    </div>

    
    <div class="text-center container">
        <asp:Label ID="LabelMessage" runat="server" Text="Nothing to see here"></asp:Label>
    </div>
    </div>
    
</asp:Content>
