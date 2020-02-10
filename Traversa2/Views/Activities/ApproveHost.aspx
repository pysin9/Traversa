<%@ Page Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="ApproveHost.aspx.cs" Inherits="Traversa2.Views.Activities.ApproveHost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .hostform{
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style2 {
            margin-left: auto;
            margin-right: auto;
            width: 1048px;
        }
        .auto-style4 {
            width: 270px;
        }
        .auto-style5 {
            width: 270px;
            height: 90px;
        }
        .auto-style6 {
            width: 521px;
            height: 90px;
        }
        .auto-style7 {
            height: 90px;
        }
        .auto-style8 {
            width: 521px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h2 style="text-align:center;"><asp:Label ID="Label4" runat="server" Text="Sign up as a Host"></asp:Label></h2>

    <h6 style="text-align:center;"><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></h6>
    <br />
    <table class="auto-style2">
       
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbId" runat="server"></asp:Label>

            </td>
            <td>
                <br />
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label5" runat="server" Text="Email: " ></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="HEmail" runat="server" Width="491px" placeholder="Enter your email used as a user"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is empty!" ControlToValidate="HEmail" ForeColor="Red" CssClass="col-lg-3" style="font-size:15px;"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td class="auto-style4">
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                 <asp:Label ID="Label3" runat="server" Text="More About Yourself: "></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="HDesc" runat="server" TextMode="MultiLine" Width="490px" placeholder="Describe more about yourself and your background"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Description is empty!" ControlToValidate="HDesc" ForeColor="Red" CssClass="col-lg-3" style="font-size:15px;"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td class="auto-style4">
                <br />
             </td>
        </tr>
        <tr>
            <td class="auto-style5">
                 <asp:Label ID="Label2" runat="server" Text="Reasons to sign up as a Host: "></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="HReasons" runat="server" TextMode="MultiLine" Width="490px" OnTextChanged="TextBox2_TextChanged" placeholder="Enter reasons why you want to sign up as a host"></asp:TextBox></td>
            <td class="auto-style7">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Reasons are empty!" ControlToValidate="HReasons" ForeColor="Red" CssClass="col-lg-3" style="font-size:15px;"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <br />
            </td>
            
        </tr>
    </table>
    <br />
    &nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="HostRequired" runat="server" Text="I agree to hold full responsibility for all my actions taken as a host." Checked="true"/>
    <br />
    &nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit"  style="margin-left: 500px;" OnClick="Button1_Click" />
    <br />
    <br />

</asp:Content>