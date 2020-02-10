<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/navbar.Master" CodeBehind="ViewAllHost.aspx.cs" Inherits="Traversa2.Views.Activities.ViewAllHost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .hostTitle{
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

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="divider">
    <div class ="hostTitle">
        <h1>Host</h1>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GVHost" runat="server" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnRowDeleting="GVHost_RowDeleting" DataKeyNames="UserId" OnSelectedIndexChanged="GVHost_SelectedIndexChanged" Width="1069px"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="UserId" DataField="ID" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Description" DataField="Description" />
                <asp:BoundField HeaderText="Reasons" DataField="Reason" />
              
                <asp:CommandField SelectText="Approve" ShowSelectButton="True" />
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


