<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Traversa2.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <link href="../../Stylesheet/Profile.css" rel="stylesheet" type="text/css" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Profile </div>
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
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Email:</label>
                        <asp:TextBox ID="email" runat="server" placeholder="Enter new email" CssClass="col-lg-5"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Country of Origin:</label>
                		<asp:TextBox ID="country" runat="server" placeholder="Enter country of origin" CssClass="col-lg-5"></asp:TextBox>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Language:</label>
                		<input class="form-control" type="text" name="language" placeholder="Enter language">
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Food Preference:</label>
                	    <asp:DropDownList ID="foodpref" runat="server" CssClass="col-lg-5"></asp:DropDownList>
                    </div>
                </div>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->

</asp:Content>