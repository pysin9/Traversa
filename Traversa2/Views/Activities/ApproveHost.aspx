<%@ Page Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="ApproveHost.aspx.cs" Inherits="Traversa2.Views.Activities.ApproveHost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .hostform{
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style4 {
            width: 95px;
        }
        .auto-style9 {
            width: 381px;
        }
        .auto-style10 {
            margin-left: 480px;
            margin-right: auto;
            width: 624px;
        }
        </style>
</asp:Content>

   

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- To make dropdown link in 'Host An Activities' appear
     1. Enter email used for sign in and tick Accept Terms Checkbox.
     2. Click Submit Btn to sign up as Host successfully. 
     3. Click on 'Host An Activity', dropdown will appear. Click 'Your Activities' to create new activity.
     4. If dropdown link 'Your Activities' does not appear in 'Host An Activity' in navbar, close window and run again to make dropdown link appear.
     --->

    <br />
    <br />
    <h2 style="text-align:center;"><asp:Label ID="Label4" runat="server" Text="Sign up as a Host"></asp:Label></h2>

    <h6 style="text-align:center;"><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></h6>
    <br />
    <table class="auto-style10">
       
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbId" runat="server"></asp:Label>

            </td>
            <td class="auto-style9">
                <br />
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label5" runat="server" Text="Email: " ></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="HEmail" runat="server" Width="344px" placeholder="Enter your email used to sign in as a user" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is empty!" ControlToValidate="HEmail" ForeColor="Red" CssClass="col-lg-3" style="font-size:15px;"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td class="auto-style4">
                <br />
            </td>
        </tr>
        <!---
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
            -->
      

    </table>

    <table class="hostform">
        <tr>
            <td>
                <asp:CheckBox ID="HostRequired" runat="server" Text="I agree to hold full responsibility for all my actions taken as a host." Checked="true"/>
            </td>
        </tr>
    </table>
    <br />
   <br />
   <table class="hostform">
       <tr>
           <td></td>
           <td>
               <asp:Button ID="btSubmit" runat="server" Text="Submit"  OnClick="btnSubmit_Click" />
           </td>
           <td></td>
       </tr>
   </table> 
   
    
    <br />
    <br />

</asp:Content>