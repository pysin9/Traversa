<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="ViewAllCategory.aspx.cs" Inherits="Traversa2.Views.Places.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cold{
            text-align:center;
        }
        .t{
            font-weight: bold;
        }
    </style>
        
    <script type="text/javascript" language="javascript">
        function ConfirmOnDelete(item)
        {
          if (confirm("Are you sure to delete: " + item + "?")==true)
            return true;
          else
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="cold">
        <label class=" t">Edit Category</label>
        <br>
        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridViewCat" runat="server" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnRowDeleting="GridViewCat_RowDeleting" DataKeyNames="CatId" OnSelectedIndexChanged="GridViewCat_SelectedIndexChanged" 
            >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="id" DataField="CatId" />
                <asp:ImageField DataImageUrlField="CatImage" HeaderText="Category Image"  ControlStyle-Width="500" ControlStyle-Height = "350"  >
<ControlStyle Height="350px" Width="500px"></ControlStyle>
                </asp:ImageField>
                <asp:BoundField HeaderText="Category Name" DataField="CatName" />
                <asp:CommandField HeaderText="Edit" SelectText="Edit" ShowSelectButton="True" />
                
                
                
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
