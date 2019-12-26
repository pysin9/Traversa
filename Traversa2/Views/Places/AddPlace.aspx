<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="AddPlace.aspx.cs" Inherits="Traversa2.Views.Places.AddPlace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Add a Place </div>
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
					    <label class="col-lg-3 control-label">Name of Place:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="PName" placeholder="Enter name of place">
              	        </div>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Description:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="PDesc" placeholder="Enter description of place">
              	        </div>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Location(s):</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="PLocation" placeholder="Enter location(s) of place">
              	        </div>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Category:</label>
              	        <div class="col-lg-5">
                		        <input class="form-control" type="text" name="Category" placeholder="Select categories">
              	        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Image:</label>
              	        <div class="col-lg-5">
                	            <input class="form-control" type="text" name="image" placeholder="Select image">
                        </div>
                    </div>
                </div>
                <button type="submit">Save</button>
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->
</asp:Content>
