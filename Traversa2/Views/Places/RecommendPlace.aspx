<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="RecommendPlace.aspx.cs" Inherits="Traversa2.Views.Places.RecommendPlace" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .empty {
            
        }
    </style>
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
     <%--  <div class="alert alert-success">
       <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>Recommendation successful!</strong>
        </div>
        <div class="alert alert-warning">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>Oops!</strong> Profile not saved. Try later.
    </div>--%>
      <div class="card-heading" > Recommend a Place </div>
      <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
      <div class="card-body">
		    <form action="RecommendPlace.aspx" method="post">
                <div class="form-group">
                    <div class="row justify-content-center">
                        <asp:ScriptManager ID="asm" runat="server" />
                        <ajaxToolkit:Rating ID="r1" runat="server"
                            CurrentRating="0"
                            MaxRating="5"
                            StarCssClass="ratingStar"
                            WaitingStarCssClass="wait"
                            FilledStarCssClass="filled"
                            EmptyStarCssClass="empty"></ajaxToolkit:Rating> 
                </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Place of recommendation:</label>
                		<asp:TextBox ID="RName" runat="server" placeholder="Enter name of recommended place" CssClass="col-lg-5" name="RName"></asp:TextBox>
                    </div>
			    </div>
			    <div class="form-group">
                    <div class="row justify-content-center">
					    <label class="col-lg-3 control-label">Reason for recommendation:</label>
                		<textarea ID="RReason" cols="60" rows="5" name="RReason"></textarea>
                    </div>
			    </div>
                    <asp:Button ID="btnRec" runat="server" Text="Recommend!"  OnClick="btnRec_Click" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->
</asp:Content>
