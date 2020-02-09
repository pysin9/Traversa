<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Traversa2.Views.Purchase.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/cart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-heading text-center">
        <h2>My Itinerary Cart</h2>
    </div>
    <br />
    <div class="card-body text-center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" OnRowCommand="GridView1_RowCommand" HorizontalAlign="Center" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Visible="False">
            <Columns>
                <asp:BoundField DataField="aid" HeaderText="Activity ID" />
                <asp:BoundField DataField="aname" HeaderText="Activity Name" />
                <asp:BoundField DataField="aprice" HeaderText="Price" />
                <asp:TemplateField HeaderText="Qty">
                    <ItemTemplate>
                        <asp:TextBox ID="tbQtyToAdd" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField CommandName="AddToCart" Text="Add To Cart" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        <h2>Items in shopping cart</h2>
        <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" HorizontalAlign="Center" AutoGenerateColumns="False" Height="250px" Width="1000px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:BoundField DataField="aid" HeaderText="Activity ID" />
                <asp:BoundField DataField="aname" HeaderText="Activity Name" />
                <asp:BoundField DataField="aprice" HeaderText="Price" />
                <asp:BoundField DataField="qty" HeaderText="Quantity" />
                <asp:ButtonField CommandName="RemoveFromCart" Text="Delete" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" OnClick="btnCheckOut_Click" />
    </div>
</asp:Content>
