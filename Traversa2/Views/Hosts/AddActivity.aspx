<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="AddActivity.aspx.cs" Inherits="Traversa2.Views.Hosts.AddActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -webkit-box-flex: 0;
            -ms-flex: 0 0 16.666667%;
            flex: 0 0 16.666667%;
            max-width: 16.666667%;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Activity </div>

      <div class="card-body">
		    <form>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Title:</label>
                		    <asp:TextBox ID="ATitle" runat="server" placeholder="" CssClass="col-lg-5"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Location:</label>
                        <asp:TextBox ID="ALocation" runat="server" placeholder="Enter description of place" CssClass="col-lg-5"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">No. of People:</label>
                            <asp:TextBox ID="APeople" runat="server" placeholder="Enter location(s) of place" CssClass="col-lg-5"></asp:TextBox>
                   </div>
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Category:</label>
                		<asp:DropDownList ID="ACategory" runat="server" CssClass="auto-style2">
                            <asp:ListItem>- Select -</asp:ListItem>
                            <asp:ListItem>Food</asp:ListItem>
                            <asp:ListItem>Music</asp:ListItem>
                            <asp:ListItem>Art</asp:ListItem>
                            <asp:ListItem>Beauty</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3 control-label">Language:</label>
                        <asp:DropDownList ID="ALanguage" runat="server" CssClass="col-lg-5">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>English</asp:ListItem>
                            <asp:ListItem>Chinese</asp:ListItem>
                            <asp:ListItem>Malay</asp:ListItem>
                            <asp:ListItem>Indian</asp:ListItem>
                            <asp:ListItem>Korean</asp:ListItem>
                            <asp:ListItem>Japanese</asp:ListItem>
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <!--<div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Please Specify:</label>
                        <asp:TextBox ID="AOthers" runat="server" CssClass="col-lg-5"></asp:TextBox>
                    </div>
                </div>-->
                 <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-3 control-label">Price:</label>
                        <asp:TextBox ID="APrice" runat="server" CssClass="col-lg-5"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-8 control-label">Add Schedule:</label>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-2 control-label">Date From:</label>
                        <asp:TextBox ID="DateFrom" runat="server" CssClass="auto-style1"  TextMode="Date"></asp:TextBox>
                        <label class="col-lg-2 control-label">&nbsp;&nbsp;&nbsp;&nbsp;Date To:  </label>
                        <asp:TextBox ID="DateTo" runat="server" CssClass="col-lg-2" TextMode="Date"></asp:TextBox>
                    </div>
                </div>

                 <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-8 control-label">Description:</label>
                    </div>
                </div>

                 <div class="form-group">
                    <div class="row justify-content-center">
                        <textarea id="TextAreaDesc" class="col-lg-8 form-control" style="margin-left:35px;" rows="2" placeholder="Provide a detailed description of the activity you will be doing. If your activity includes bringing people to multiple places, describe those places as per your planned itinerary."></textarea>
                    </div>
                </div>

                 <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-8 control-label">What can you Provide:</label>
                    </div>
                </div>
                
                <div class="form-group">
                    <div class="row justify-content-center">
                        <asp:CheckBox ID="CheckBoxNothing" runat="server" CssClass="" />
                        <asp:Label ID="Nothing" runat="server" style="margin-right:605px;" CssClass="">Nothing</asp:Label>
                    </div>
                </div>

                 
                <div class="form-group">
                    <div class="row justify-content-center">
                        <asp:CheckBox ID="CheckBoxSomething" runat="server" CssClass="" />
                        <asp:Label ID="Something" runat="server" style="margin-right:463px;"  CssClass="">I wish to provide something.</asp:Label>
                    </div>
                </div>


                <div class="form-group">
                    <div class="row justify-content-center">
                        <textarea id="TextAreaProvided" class="col-lg-8 form-control" style="margin-left:35px;" rows="1" placeholder="List things you will be providing for this activity, eg. transportation, food, tickets, etc..."></textarea>
                    </div>
                </div>
               

                <div class="form-group">
                    <div class="row justify-content-center">
              	        <label class="col-lg-8 control-label">Things to Bring:</label>
                    </div>
                </div>


                <div class="form-group">
                    <div class="row justify-content-center">
                        <asp:CheckBox ID="NothingToBring" runat="server" CssClass="" />
                        <asp:Label ID="hgfhgf" runat="server" style="margin-right:605px;" CssClass="">Nothing</asp:Label>
                    </div>
                </div>
                 
                <div class="form-group">
                    <div class="row justify-content-center">
                        <asp:CheckBox ID="BringSomething" runat="server" CssClass="" />
                        <asp:Label ID="Label1" runat="server" style="margin-right:240px;" CssClass="">Participants are required to bring something for this activity.</asp:Label>
                    </div>
                </div>    

                <div class="form-group">
                    <div class="row justify-content-center">
                        <textarea id="TextAreaThings" class="col-lg-8 form-control" style="margin-left:35px;" rows="1" placeholder="List items/things participants are required to bring for this activity to commence."></textarea>
                    </div>
                </div>

                
                <asp:Label ID="LblMsg" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
                <asp:Button ID="Exit" runat="server" Text="Exit" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel --> <!-- end container-fluid -->
</div>
</asp:Content>