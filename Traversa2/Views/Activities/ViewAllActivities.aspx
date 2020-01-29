<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="ViewAllActivities.aspx.cs" Inherits="Traversa2.Views.Activities.ViewAllActivities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        #divider{
            text-align:center;
           
        }
        #lbl{
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="divider">
        <label id="lbl">All Activities</label>
        <br>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
