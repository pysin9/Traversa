<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ViewOnePlace.aspx.cs" Inherits="Traversa2.Views.Places.ViewOnePlace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 318px;
        }
        #table{
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style2 {
            width: 527px;
        }
        .hr{
            color:black;

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table style="width: 80%;" id="table">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="name" runat="server" Text="" style="font-weight:bold; font-size:30px; text-align:center;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Image ID="image" runat="server" style="width:230px; height:230px; display:block; margin-left:auto; margin-right:auto;"/>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Address(es): " style="font-size:21px;"></asp:Label>
                <asp:Label ID="location" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <asp:Label ID="Label11" runat="server" Text="Region: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="region" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Avg Rating: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="avgrating" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <asp:Label ID="Label10" runat="server" Text="Category: "  style="font-size:21px;"></asp:Label>
                <asp:Label ID="category" runat="server" Text=""  style="font-size:21px;"></asp:Label>
                <br />
                <br />
                <asp:Label ID="desc" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <hr/>
    <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label ID="Label5" runat="server" Text="Write a review!" style="font-size:25px; text-align:center;"></asp:Label>
    </div>
    <table style="width: 80%; text-align: center;" id="table">
        <tr>
            <td class="auto-style2">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Rating: " style="font-size:21px;"></asp:Label>
            </td>
            <td>
                 <asp:RadioButtonList ID="rdRate" runat="server" RepeatDirection="Horizontal" Width="499px">
                    <asp:ListItem Value="1" Selected="True">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                    <asp:ListItem Value="5">5</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Comments: " style="font-size:21px;"></asp:Label>
            </td>
            <td>
                <textarea id="comment" cols="60" name="comment" rows="3" style="resize: none"></textarea>
            </td>
        </tr>
    </table>
    <div style="margin-left: auto; margin-right: auto; text-align: center;">
       <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="background-color:green; color: white;" OnClick="btnSubmit_Click"/>
    </div>
    <br />
    <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label ID="Label9" runat="server" Text="You reviewed: " style="font-size:25px; text-align:center;"></asp:Label>
        <asp:Label ID="userrate" runat="server" Text="" style="font-size:21px;"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="/5 " style="font-size:21px;"></asp:Label>
        <br />
        <asp:Label ID="usercomment" runat="server" Text="" style="font-size:21px;"></asp:Label>
    </div>
        <hr/>
    <%-- display all reviews --%>
    
    <div style="margin-left: auto; margin-right: auto; text-align: center; ">
        <asp:DataList ID="DataList1" runat="server" Width="100%">
            <ItemTemplate>
                <table style="width: 80%; text-align: center;" id="table">
                    <tr>
                        <td>
                            <asp:Label ID="lblUser" runat="server" Text='<%#Bind("UserName")%>' style="font-size:21px; font-weight:bold;"></asp:Label>
                            <asp:Label ID="Label6" runat="server" Text=" rated " style="font-size:21px;"></asp:Label>
                            <asp:Label ID="lblRate" runat="server" Text='<%#Bind("Rate")%>' style="font-size:21px;"></asp:Label>
                            <asp:Label ID="Label7" runat="server" Text="/5 on" style="font-size:21px;"></asp:Label>
                            <asp:Label ID="Label8" runat="server" Text='<%#Bind("Date")%>' style="font-size:21px;"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblComments" runat="server" Text='<%#Bind("Review")%> ' style="font-size:21px;"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
