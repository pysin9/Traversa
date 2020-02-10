<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="FAQAdmin.aspx.cs" Inherits="Traversa2.Views.FAQ.FAQAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="FaqId" HeaderText="FaqId" ReadOnly="True" />
            <asp:BoundField DataField="Question" HeaderText="Question" ReadOnly="True" />
            <asp:BoundField DataField="Answer" HeaderText="Answer" ReadOnly="True" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" />
</asp:Content>
