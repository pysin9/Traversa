<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="HostView.aspx.cs" Inherits="Traversa2.Views.Activities.HostView" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style>
        .cold{
            text-align:center;
        }
        .t{
            font-weight: bold;
        }
        #divider{
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="divider">
    <div class ="cold">
        <h1>Activity</h1>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdd" class="" runat="server" Text="Host An Activity" OnClick="btnAdd_Click" />
        <br />
        <br />
        <asp:GridView ID="GVActivity" runat="server" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnRowDeleting="GVActivity_RowDeleting" DataKeyNames="AcId" OnSelectedIndexChanged="GVActivity_SelectedIndexChanged"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="id" Visible="False" DataField="AcId" />
                <asp:ImageField DataImageUrlField="ImagePath" HeaderText="Activity Image"  ControlStyle-Width="500" ControlStyle-Height = "350"  >
                <ControlStyle Height="150px" Width="150px"></ControlStyle>
                </asp:ImageField>
                <asp:BoundField HeaderText="Title" DataField="AName" />
                <asp:BoundField HeaderText="Description" DataField="ADesc" />
                <asp:BoundField HeaderText="Location" DataField="ALocation" />
                <asp:BoundField HeaderText="Price" DataField="APrice"/>
                
                <asp:BoundField HeaderText="Provided Items" DataField="AProvided"/>
                <asp:BoundField HeaderText="Things to Bring" DataField="ABring"/>  

                <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
               

                <asp:CommandField ShowDeleteButton="True" />
                
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
 
    </div>
    </div>
</asp:Content>


