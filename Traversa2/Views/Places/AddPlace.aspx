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
                		    <asp:TextBox ID="Pname" runat="server" placeholder="Enter name of place" CssClass="col-lg-5"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Description:</label>
                        <asp:TextBox ID="PDesc" runat="server" palceholder="Enter name of place" placeholder="Enter description of place" CssClass="col-lg-5"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Location(s):</label>
                            <asp:TextBox ID="PLocation" runat="server" palceholder="Enter location(s) of place" placeholder="Enter location(s) of place" CssClass="col-lg-5"></asp:TextBox>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Category:</label>
                		<asp:DropDownList ID="category" runat="server" CssClass="col-lg-5"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Image:</label>
                        <asp:FileUpload ID="FileUpload" runat="server" />
                    </div>
                    <asp:Label ID="uploadstatus" runat="server" Text=""></asp:Label>
                </div>
                    
                    <asp:Button ID="btnSave" class="btnSave" Text="Save" runat="server" OnClick="btnSave_Click"/>
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel --> <!-- end container-fluid -->
</div>
</asp:Content>
