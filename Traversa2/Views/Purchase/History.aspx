<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Traversa2.Views.Purchase.History" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/history.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-heading text-center">
        <h2>Purchase History</h2>
    </div>
    <br />
    <div class="card-body text-center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="250px" HorizontalAlign="Center" Width="1000px">
            <Columns>
                <asp:BoundField DataField="aid" HeaderText="Activity ID" />
                <asp:BoundField DataField="aname" HeaderText="Activity Name" />
                <asp:BoundField DataField="aprice" HeaderText="Price" />
                <asp:BoundField DataField="qty" HeaderText="Quantity" />
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
        <asp:Button ID="btnHome" runat="server" Text="Back To Home" OnClick="btnCheckOut_Click"/>
    </div>
</asp:Content>
