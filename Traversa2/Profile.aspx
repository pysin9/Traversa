<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Traversa2.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Stylesheet/Profile.css" rel="stylesheet" type="text/css" />
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
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="Username" placeholder="Enter new username">
              	        </div>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Email:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="email" placeholder="Enter new email">
              	        </div>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Country of Origin:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="country" placeholder="Enter your country of origin">
              	        </div>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Language:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="language" placeholder="Enter language">
              	        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Food Preference:</label>
              	        <div class="col-lg-5">
                	            <input class="form-control" type="text" name="foodpref" placeholder="Enter your food preference">
                        </div>
                    </div>
                </div>
                <button type="submit">Update</button>
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->

</asp:Content>