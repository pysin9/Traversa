<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="EditActivity.aspx.cs" Inherits="Traversa2.Views.Activities.EditActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        
        .auto-style2 {
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

        .Rbtn {
            text-align: left;
            margin-left: 45px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="container">
        <div class=".col-lg-4 .col-lg-offset-2">
            <div class="card-heading"> Edit Activity</div>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
            <div class="card-body">
                <form>
                    <asp:Label ID="lblAcId" runat="server"></asp:Label>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Title:</label>
                            <asp:TextBox ID="AName" runat="server" placeholder="Enter title of activity" CssClass="col-lg-5"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVAName" runat="server" ErrorMessage="Title is empty!" ControlToValidate="AName" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Description:</label>
                            <asp:TextBox ID="ADesc" runat="server" placeholder="Enter description of activity" CssClass="col-lg-5" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVADesc" runat="server" ErrorMessage="Description is empty!" ControlToValidate="ADesc" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Location:</label>
                            <asp:TextBox ID="ALocation" runat="server" placeholder="Enter location where activity is held at" CssClass="col-lg-5"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVALocation" runat="server" ErrorMessage="Location is empty!" ControlToValidate="ALocation" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Category:</label>
                            <asp:DropDownList ID="category" runat="server" CssClass="col-lg-5">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="FVCategory" runat="server" ErrorMessage="Category is not selected!" ControlToValidate="category" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Price (S$):</label>
                            <asp:TextBox ID="APrice" runat="server" placeholder="Enter the price per person" CssClass="col-lg-5"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVPrice" runat="server" ErrorMessage="Price is empty!" ControlToValidate="APrice" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <!---
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Date:</label>
                            <asp:TextBox ID="ADate" runat="server" CssClass="col-lg-5" placeholder="Enter date of activity" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVDate" runat="server" ErrorMessage="No date has been selected!" ControlToValidate="ADate" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>-->

                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Image:</label>  
                            <asp:FileUpload ID="FileUpload" runat="server" CssClass="auto-style2" />
                            <asp:RequiredFieldValidator ID="FVImage" runat="server" ErrorMessage="No image has been selected!" ControlToValidate="FileUpload" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                        <asp:Label ID="imgName" runat="server" Text="" CssClass="col-lg-5"></asp:Label>
                    </div>

                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-11 control-label" id="labelP">What can you Provide:</label>
                            
                        </div>
                    </div>
                    <!---
                    <asp:RadioButtonList ID="RBtnProvided" runat="server" class="Rbtn">
                        <asp:ListItem Value="ProvidedNothing">Nothing</asp:ListItem>
                        <asp:ListItem Value="ProvidedSomething">I wish to provide something.</asp:ListItem>
                    </asp:RadioButtonList>
                        --->

                     <div class="form-group">
                        <div class="row justify-content-center">
                            <asp:TextBox ID="AProvided" runat="server" placeholder="List things you will be providing for this activity, eg. transportation, food, tickets, etc..." CssClass="col-lg-8" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="FVProvided" runat="server" ErrorMessage="No items listed!" ControlToValidate="AProvided" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    

                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-11 control-label" id="labelB">Things to Bring:</label>
                        </div>
                    </div>
                    <!---
                    <asp:RadioButtonList ID="RBtnBring" runat="server" class="Rbtn">
                        <asp:ListItem Value="BringNothing">Nothing</asp:ListItem>
                        <asp:ListItem Value="BringSomething">Participants are required to bring something.</asp:ListItem>
                    </asp:RadioButtonList>
                        --->
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <asp:TextBox ID="ABring" runat="server" placeholder="List items/things participants are required to bring for this activity to commence." CssClass="col-lg-8" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="No items listed!" ControlToValidate="ABring" ForeColor="Red" CssClass="col-lg-3"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Save" runat="server" Text="Submit" class="btnSave" OnClick="Submit_Click" />
                    <asp:Button ID="Exit" runat="server" Text="Exit" class="btnCancel" OnClick="Exit_Click" CausesValidation="False" />
                </form>
            </div>
            <!-- end panel-body -->
        </div>
        <!-- end panel -->
        <!-- end container-fluid -->
    </div>
</asp:Content>

