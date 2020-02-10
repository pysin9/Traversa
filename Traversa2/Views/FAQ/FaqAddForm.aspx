<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="FaqAddForm.aspx.cs" Inherits="Traversa2.Views.FAQ.FaqAddForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/FaqAddForm.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    <form id="form1" >
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">FAQID:</td>
                    <td>
                        <asp:TextBox ID="Tbfaqid" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">Question:</td>
                    <td>
                        <asp:TextBox ID="TbQuestion" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Answer</td>
                    <td>
                        <asp:TextBox ID="TbAnswer" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>
               
                

                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" Width="80px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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

</asp:Content>
