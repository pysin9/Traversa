﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Traversa2.Views.Users.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/Profile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Change your password </div>
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
		    <form method="post">
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">New Password:</label>
                        <asp:TextBox ID="password" runat="server" placeholder="Enter new password" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVPass" runat="server" ErrorMessage="New password cannot be empty" CssClass="col-lg-3" ControlToValidate="password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Confirm Password:</label>
                	    <asp:TextBox ID="cfmpass" runat="server" placeholder="Re-enter new password" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVCfm" runat="server" ErrorMessage="Retype password cannot be empty" CssClass="col-lg-3" ControlToValidate="cfmpass" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CVPass" runat="server" ErrorMessage="Passwords do not match" ControlToValidate="cfmpass" ControlToCompare="password" Operator="Equal" Type="String" CssClass="Col-lg-3" ForeColor="Red"></asp:CompareValidator>
                    </div>
                </div>
                <asp:Button ID="btnSubmit" runat="server" Text="Change" OnClick="btnSubmit_Click" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->
</asp:Content>
