<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Traversa2.Views.Purchase.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/checkout.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-heading text-center">
        <h2>Checkout</h2>
    </div>
    <br />
    <div class="card-body text-center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" HorizontalAlign="Center" Height="250px" Width="1000px" OnRowDataBound="GridView1_RowDataBound">
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
        <h3>Total Price: $<asp:Label ID="lbl_TotalAmt" runat="server" Text="Label"></asp:Label>0</h3>
        <br />
        <br />
        <h6><a href="http://localhost:51081/Views/Activities/ActivityList.aspx">You May Also Like</a></h6>
        <div>
            <center>
                <table>
                    <tr>
                        <td><asp:Image ID="Image1" runat="server" ImageUrl="~/uploads/Food Gastronomy.jpg" Height="250px" Width="250px"/></td>
                        <td></td>
                        <td><asp:Image ID="Image2" runat="server" ImageUrl="~/uploads/Italian cooking.jpg" Height="250px" Width="250px"/></td>
                    </tr>
                </table>
            </center>
        </div>
        <br />
        <br />
        <center>
            <table border="1">
                <tr>
                    <td>
                        Name
                    </td>
                    <td>
                        Amount Paid
                    </td>
                    <td>
                        Card Number
                    </td>
                    <td>
                        Expiry Date
                    </td>
                    <td>
                        CVV
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="tbAmt" runat="server"></asp:TextBox>

                    </td>
                    <td>
                        <asp:TextBox ID="tbCard" runat="server"></asp:TextBox>

                    </td>
                    <td>
                        <asp:TextBox ID="tbExpiry" runat="server"></asp:TextBox>

                    </td>
                    <td>
                        <asp:TextBox ID="tbCvv" runat="server"></asp:TextBox>

                    </td>
                </tr>
            </table>
        </center>
        <br />
        <br />
        <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" />
    </div>
</asp:Content>
