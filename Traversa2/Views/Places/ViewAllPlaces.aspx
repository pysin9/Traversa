<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="ViewAllPlaces.aspx.cs" Inherits="Traversa2.Views.Places.ViewAllPlaces" %>
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
        <label id="lbl">All Places</label>
        <br>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GVPlace" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowDeleting="GVPlace_RowDeleting" DataKeyNames="PlId" OnSelectedIndexChanged="GVPlace_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="PlaceId" DataField="PlId" ReadOnly="True" />
                <asp:BoundField HeaderText="Name of Place" DataField="PName" ReadOnly="True" />
                <asp:BoundField HeaderText="Description" DataField="PDesc" ReadOnly="True" />
                <asp:BoundField HeaderText="Address" DataField="PLocation" ReadOnly="True" />
                <asp:ImageField DataImageUrlField="ImagePath" HeaderText="Image" ReadOnly="True" >
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
                <asp:BoundField HeaderText="Average Rating" DataField="AvgRating" ReadOnly="True" />
                <asp:BoundField HeaderText="Category" DataField="CatName" ReadOnly="True" />
                <asp:BoundField DataField="Region" HeaderText="Region" />
                <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
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
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btnAdd_Click"/>
    </div>

</asp:Content>
