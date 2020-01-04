<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ViewAllRec.aspx.cs" Inherits="Traversa2.Views.Places.ViewAllRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <asp:GridView ID="GVRec" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="RecID" />
            <asp:BoundField DataField="RName" HeaderText="Name of Place" ReadOnly="True" />
            <asp:BoundField DataField="RReason" HeaderText="Reason for Recommendation" ReadOnly="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>--%>
    <table id="tblRec" style="width: 100%;" class="table">
        <% foreach (var item in recList) { %>
            <tr>
                <td><%= item.RName %></td>
                <td><%= item.RReason%></td>
                <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /></td>
                
            </tr>
        <% } %>
    </table>
</asp:Content>
