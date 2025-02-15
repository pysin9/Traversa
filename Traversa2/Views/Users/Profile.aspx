﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Traversa2.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <link href="../../Stylesheet/Profile.css" rel="stylesheet" />


    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -webkit-box-flex: 0;
            -ms-flex: 0 0 41.666667%;
            flex: 0 0 41.666667%;
            max-width: 41.666667%;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Profile </div>
      <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
<%--<div class="alert alert-success">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>Success!</strong> Profile successfully saved
        </div>
        <div class="alert alert-warning">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>Oops!</strong> Profile not saved. Try later.
    </div>--%>
      <div class="card-body">
		    <form>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Username:</label>
                        <asp:TextBox ID="username" runat="server" placeholder="Enter new username" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVUname" runat="server" ControlToValidate="username" ErrorMessage="Username cannot be empty!" CssClass="col-lg-3" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Email:</label>
                        <asp:TextBox ID="uemail" runat="server" placeholder="Enter new email" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email cannot be empty!" CssClass="col-lg-3" ForeColor="Red" ControlToValidate="uemail"></asp:RequiredFieldValidator>
                    </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Language:</label>
                		<asp:DropDownList ID="lang" runat="server" CssClass="col-lg-5">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem>English</asp:ListItem>
                            <asp:ListItem>Chinese</asp:ListItem>
                            <asp:ListItem>Malay</asp:ListItem>
                            <asp:ListItem>Tamil</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="username" CssClass="col-lg-3" ForeColor="Red" ControlToValidate="lang" InitialValue="0"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Travelling style:</label>
                		<asp:DropDownList ID="travelstyle" runat="server" CssClass="auto-style1">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem>Family-oriented</asp:ListItem>
                            <asp:ListItem>With friends</asp:ListItem>
                            <asp:ListItem>Solo</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select your travel style" CssClass="col-lg-3" ForeColor="Red" ControlToValidate="travelstyle" InitialValue="0"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Food Preference:</label>
                	    <asp:DropDownList ID="foodpref" runat="server" CssClass="col-lg-5">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem>Vegan</asp:ListItem>
                            <asp:ListItem>Vegetarian</asp:ListItem>
                            <asp:ListItem>Pescatarian</asp:ListItem>
                            <asp:ListItem>Seafood</asp:ListItem>
                            <asp:ListItem Value="RedMeat">Red Meat</asp:ListItem>
                            <asp:ListItem Value="NPork">No Pork</asp:ListItem>
                            <asp:ListItem Value="NBeef">No Beef</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="FVFood" runat="server" ErrorMessage="Select a Food Preference" CssClass="col-lg-3" ForeColor="Red" ControlToValidate="foodpref" InitialValue="0"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->

</asp:Content>