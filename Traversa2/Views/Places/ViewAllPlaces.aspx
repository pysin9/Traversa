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
        <asp:GridView ID="GVPlace" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowDeleting="GVPlace_RowDeleting" DataKeyNames="PlId" OnSelectedIndexChanged="GVPlace_SelectedIndexChanged">
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
                <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btnAdd_Click"/>
    </div>

</asp:Content>
