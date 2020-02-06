<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="ViewActivity.aspx.cs" Inherits="Traversa2.Views.Activities.ViewActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 315px;
            height: 280px;
            margin:100px 0 0 0;
            border-radius: 30px;
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

    </style>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left:450px; margin-top: 200px;">
        <asp:Label runat="server" ID="name" Text="[Title]"></asp:Label>
    </div>

    <div class="activityInfo" style="width: 317px; height: 1000px;">
        <img alt="Chef Cooking" class="auto-style1" src="https://www.theguideistanbul.com/wp-content/uploads/2019/11/Pelin-Cantinery-800x640.jpg" />

        <br />
        <br />
        <br />

        <i class="fa fa-map-marker" style="font-size:36px; margin-left:5px;"></i>
        <div class="icon-text"><asp:Label ID="Location" runat="server" Text="Chronos #01-07, 10 Bipolis Rd"></asp:Label></div>
        <br />
        <i class="fa fa-clock-o" style="font-size:36px"></i>
        <asp:Label ID="Duration" runat="server" class="icon-text-1">Duration: 2 hrs</asp:Label>
        <br />
        <br />
        <br />
        <i class="fas fa-user-friends" style="font-size:36px"></i>
        <asp:Label ID="People" runat="server" class="icon-text-1"> 2 ~ 3 per grp</asp:Label>
        <br />
        <br />
        <br />
        <i class="fas fa-comments" style="font-size:36px"></i>
        <asp:Label ID="Language" runat="server" class="icon-text-1">Hosted in English</asp:Label>
        <br />
        <br />
        <br />
        <i class='far fa-money-bill-alt' style='font-size:36px'></i>
        <asp:Label ID="Mon" runat="server" class="icon-text-1"> per person</asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAdd" class="button" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" />
        

    </div>
    
</asp:Content>
