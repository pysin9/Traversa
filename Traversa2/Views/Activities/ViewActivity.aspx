<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="ViewActivity.aspx.cs" Inherits="Traversa2.Views.Activities.ViewActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 318px;
        }
        
        #table1{
            margin-left:auto; 
        }
        #table2{
            margin-right:auto;
            margin-top: 100px;
        }
        .hr{
            color:black;

        }

        .icon-text{
            width: 260px;
            height: 36px; 
            position: relative;
            margin-left: 45px;
            bottom: 35px;
        }
        .icon-text-1{
            width: 260px;
            height: 36px; 
            position: relative; 
            bottom: 8px;
            margin-left: 10px;
        }
        .button {
            background-color: #4CAF50;
            border: none;
            border-radius: 20px;
            color: white;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }
        .activityInfo {
           
        }

        .auto-style4 {
            width: 717px;
        }

        .auto-style5 {
            width: 71%;
            height: 318px;
        }
        .auto-style6 {
            width: 717px;
            height: 72px;
        }
        
        .auto-style7 {
            width: 247px;
            height: 297px;
        }
        
        .auto-style8 {
            height: 80px;
        }
        
    </style>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="table1" class="auto-style5">
        <tr>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="name" runat="server" Text="" style="font-weight:bold; font-size:30px; text-align:center;"></asp:Label>

            
        </tr>
        <tr>
            <td class="auto-style4">
                <br />
                <asp:Label ID="desc" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
            
        </tr>
        
    </table>

    <table class="auto-style7" id="table2">
        <tr class="auto-style1">
            <td><asp:Image ID="image" runat="server" style="width:300px; height:300px; display:block; margin-left:auto; margin-right:auto;"/></td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label2" runat="server" class="icon-text-1"  Text="Location: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="location" runat="server" Text="" style="font-size:21px;"></asp:Label>
        
            </td>
        </tr>
        <tr>
            <td>
               
               <asp:Label ID="Label3" runat="server" class="icon-text-1" Text="Date: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="date" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" class="icon-text-1" Text="No. of People: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="people" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <asp:Label ID="Label5" runat="server" class="icon-text-1" Text="Price: " style="font-size:21px;"></asp:Label>
                <asp:Label ID="price" runat="server" Text="" style="font-size:21px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" class="button" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>

   
    
</asp:Content>
