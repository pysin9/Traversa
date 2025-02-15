﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbarForAdmin.Master" AutoEventWireup="true" CodeBehind="AddPlace.aspx.cs" Inherits="Traversa2.Views.Places.AddPlace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Add a Place </div>
      <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
      <div class="card-body">
		    <form>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Name of Place:</label>
                		    <asp:TextBox ID="Pname" runat="server" placeholder="Enter name of place" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVName" runat="server" ErrorMessage=" Name is empty!" ControlToValidate="PName" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Description:</label>
                        <asp:TextBox ID="PDesc" runat="server" palceholder="Enter name of place" placeholder="Enter description of place" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVDesc" runat="server" ErrorMessage=" Description is empty!" ControlToValidate="PDesc" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Location(s):</label>
                            <asp:TextBox ID="PLocation" runat="server" placeholder="Enter Address(s) of place" CssClass="col-lg-5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FVLoca" runat="server" ErrorMessage=" Address is empty!" ControlToValidate="PLocation" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Category:</label>
                		<asp:DropDownList ID="category" runat="server" CssClass="col-lg-5">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="FVCat" runat="server" ErrorMessage="Please select a Category!" InitialValue="0" ControlToValidate="category" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Region:</label>
                		<asp:DropDownList ID="region" runat="server" CssClass="col-lg-5">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem>North</asp:ListItem>
                            <asp:ListItem>South</asp:ListItem>
                            <asp:ListItem>East</asp:ListItem>
                            <asp:ListItem>West</asp:ListItem>
                            <asp:ListItem>Central</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select a Region!" InitialValue="0" ControlToValidate="category" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Image:</label>
                        <asp:FileUpload ID="FileUpload" runat="server" CssClass="col-lg-5"/>          
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="No image has been selected!" ControlToValidate="FileUpload" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                    </div>
                    <asp:Label ID="imgName" runat="server" Text="" CssClass="col-lg-5"></asp:Label>
                </div>
                    <asp:Button ID="btnCancel" class="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="False" />
                    <asp:Button ID="btnSave" class="btnSave" Text="Save" runat="server" OnClick="btnSave_Click"/>
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel --> <!-- end container-fluid -->
</div>
</asp:Content>
