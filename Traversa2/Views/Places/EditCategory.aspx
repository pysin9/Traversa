<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="Traversa2.Views.Places.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cold{
            text-align:center;
        }
        .t{
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="cold">
        <label class=" t">Edit Category</label>
        <br>
        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridViewCat" runat="server" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnRowDeleting="GridViewCat_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="id" Visible="False" DataField="CatId" />
                <asp:BoundField HeaderText="Category Image" />
                <asp:BoundField HeaderText="Category Name" DataField="CatName" />
                <asp:CommandField ShowCancelButton="False" ShowEditButton="True" />
                
                
                
                <asp:CommandField ShowDeleteButton="True" />
                
                
                
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    
</asp:Content>
