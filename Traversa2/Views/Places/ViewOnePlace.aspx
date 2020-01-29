<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ViewOnePlace.aspx.cs" Inherits="Traversa2.Views.Places.ViewOnePlace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 318px;
        }
        #table{
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table style="width: 70%; border:solid" id="table">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="name" runat="server" Text="" style="font-weight:bold; font-size:30px; text-align:center;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Image ID="image" runat="server" style="width:200px; height:200px; display:block; margin-left:auto; margin-right:auto;"/>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Address(es): " style="font-size:21px;"></asp:Label>
                <asp:Label ID="location" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Avg Rating: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="avgrating" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <br />
                <asp:Label ID="desc" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
