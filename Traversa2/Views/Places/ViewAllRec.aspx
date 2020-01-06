<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ViewAllRec.aspx.cs" Inherits="Traversa2.Views.Places.ViewAllRec" %>
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
<%--    <asp:GridView ID="GVRec" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="RecID" />
            <asp:BoundField DataField="RName" HeaderText="Name of Place" ReadOnly="True" />
            <asp:BoundField DataField="RReason" HeaderText="Reason for Recommendation" ReadOnly="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>--%>
    <div id="divider">
        <label id="lbl">All Recommendations</label>
        <br>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GVRecs" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowDeleting="GVRecs_RowDeleting" DataKeyNames="RecID">
            <Columns>
                <asp:BoundField DataField="RecID" HeaderText="Id" Visible="False" />
                <asp:BoundField DataField="RName" HeaderText="Name of Place" />
                <asp:BoundField DataField="RReason" HeaderText="Reason for Recommendation" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
