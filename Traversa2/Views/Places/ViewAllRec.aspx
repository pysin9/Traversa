<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="ViewAllRec.aspx.cs" Inherits="Traversa2.Views.Places.ViewAllRec" %>
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
        <label id="lbl">All Recommendations</label>
        <br>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GVRecs" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowDeleting="GVRecs_RowDeleting" DataKeyNames="RecID" OnSelectedIndexChanged="GVRecs_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="RecID" HeaderText="Id" />
                <asp:BoundField DataField="RName" HeaderText="Name of Place" />
                <asp:BoundField DataField="RReason" HeaderText="Reason for Recommendation" />
                <asp:BoundField DataField="priceRate" HeaderText="Price Rating" />
                <asp:BoundField DataField="qualityRate" HeaderText="Overall Rating" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField SelectText="Approve" ShowSelectButton="True" />
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
