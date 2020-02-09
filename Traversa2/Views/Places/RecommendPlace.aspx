<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="RecommendPlace.aspx.cs" Inherits="Traversa2.Views.Places.RecommendPlace" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" id="container">
  <div class=".col-lg-4 .col-lg-offset-2">
      <div class="card-heading" > Recommend a Place </div>
      <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
      <div class="card-body">
		    <form action="RecommendPlace.aspx" method="post">
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3">Price: </label>
                        <asp:RadioButtonList ID="rdPrice" runat="server" RepeatDirection="Horizontal" CssClass="col-lg-5">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:RadioButtonList> 
			    </div>
                <div class="form-group">
                    <div class="row justify-content-center">
                        <label class="col-lg-3">Overall rating: </label>
                        <asp:RadioButtonList ID="rdOverall" runat="server" RepeatDirection="Horizontal" CssClass="col-lg-5">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:RadioButtonList>  
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
                		<textarea ID="RReason" cols="61" rows="5" name="RReason"></textarea>
                    </div>
			    </div>
                    <asp:Button ID="btnRec" runat="server" Text="Recommend!"  OnClick="btnRec_Click" />
			 </form>
      </div> <!-- end panel-body -->
    </div> <!-- end panel -->
</div> <!-- end container-fluid -->
</asp:Content>
