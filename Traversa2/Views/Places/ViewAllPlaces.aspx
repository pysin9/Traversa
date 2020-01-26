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
        <label id="lbl">All Recommendations</label>
        <br>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GVPlace" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowDeleting="GVPlace_RowDeleting" DataKeyNames="PlId" OnSelectedIndexChanged="GVPlace_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="PlaceId" DataField="PlId" />
                <asp:BoundField HeaderText="Name of Place" DataField="PName" />
                <asp:BoundField HeaderText="Description" DataField="PDesc" />
                <asp:BoundField HeaderText="Address" DataField="PLocation" />
                <asp:BoundField HeaderText="Image" DataField="ImagePath" />
                <asp:BoundField HeaderText="Average Rating" DataField="AvgRating" />
                <asp:BoundField HeaderText="Category" DataField="CatId" />
                <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
