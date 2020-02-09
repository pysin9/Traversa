<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="ViewActivity.aspx.cs" Inherits="Traversa2.Views.Activities.ViewActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        #table1{
            margin-right:auto; 
        }
        #table2{
            margin-right:auto;
            margin-top: 20px;
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

        .auto-style5 {
            width: 85%;
            height: 318px;
            margin-left: 45px;
        }
                
        .auto-style7 {
            width: 1175px;
            height: 297px;
            margin-left: 87px;
            margin-top: 0px;
        }
        
        .auto-style8 {
            height: 80px;
        }
        
        .auto-style10 {
            width: 433px;
        }
        
        .auto-style11 {
            width: 120px;
        }
        
        .auto-style14 {
            width: 230px;
        }
        
        .auto-style15 {
            width: 120px;
            height: 34px;
        }
        .auto-style16 {
            width: 230px;
            height: 34px;
        }
        .auto-style17 {
            height: 34px;
        }
        
    </style>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="table1" class="auto-style5">
        <tr>
            <td class="auto-style10">&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblCartMsg" runat="server"></asp:Label></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Image ID="image" runat="server" style="display:block; margin-left:auto; margin-right:auto;" Width="355px" Height="300px"/>
            </td>
            <td>
                <asp:Label ID="lblAcId" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="name" runat="server" Text="" style="font-weight:bold; font-size:30px; text-align:center;"></asp:Label>
                <br />
                <br />
                 <asp:Label ID="desc" runat="server" Text="" style="font-size:21px;"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style10"></td>
            <td></td>
        </tr>
       
    </table>



    <table class="auto-style7" id="table2">

        <tr>
            <td></td>

        </tr>

        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label2" runat="server" Text="Location: " style="font-size:15px;"></asp:Label>
            </td>
            <td class="auto-style14">
                <asp:Label ID="location" runat="server" Text="" style="font-size:15px;"></asp:Label>
            </td>

            <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Provided Items: " style="font-size:20px;"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style15">
               <asp:Label ID="Label3" runat="server" Text="Price: " style="font-size:15px;"></asp:Label> 
            </td>
            <td class="auto-style16">
                <asp:Label ID="price" runat="server" Text="" style="font-size:15px;"></asp:Label>
            </td>
            <td class="auto-style17">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;
                <asp:Label ID="provItems" runat="server" Text="" style="font-size:20px;"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label1" runat="server" Text="Quantity: " style="font-size:15px;" ></asp:Label>  
            </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtQty" runat="server" style="font-size:15px;" placeholder="Enter no. of people joining" Width="190px"></asp:TextBox>
            </td>
            <td></td>
        </tr>

        <tr>
            <td class="auto-style11">
                
            </td>
            <td class="auto-style14">
                <asp:RequiredFieldValidator ID="CartQty" runat="server" ErrorMessage="Quantity is empty!" ControlToValidate="txtQty" ForeColor="Red" CssClass="col-lg-3" style="font-size:15px;"></asp:RequiredFieldValidator>
                <br />
            </td>
            <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Things to Bring: " style="font-size:20px;"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style11">
                <asp:Button ID="btnAdd" class="button" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" />
            </td>
            <td class="auto-style14">
                
            </td>
            <td>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;
                <asp:Label ID="thingstobring" runat="server" Text="" style="font-size:20px;"></asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>

        <tr>
            <td class="auto-style11"></td>
        </tr>
    </table>

    
    
   
    
</asp:Content>
