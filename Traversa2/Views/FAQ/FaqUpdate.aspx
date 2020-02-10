<%--<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="FaqUpdate.aspx.cs" Inherits="Traversa2.Views.FAQ.FaqUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>--%>
<%--<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="FaqUpdate.aspx.cs" Inherits="Traversa2.Views.FAQ.FaqUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FaqUpdate.aspx.cs" Inherits="Traversa2.FaqUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">FAQID:</td>
                    <td>
                        <asp:TextBox ID="TbFaqid" runat="server" Width="211px" Enabled="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Question:</td>
                    <td>
                        <asp:TextBox ID="Tbqns" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Answer:</td>
                    <td>
                        <asp:TextBox ID="Tbans" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" Width="55px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Label ID="LblMsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
