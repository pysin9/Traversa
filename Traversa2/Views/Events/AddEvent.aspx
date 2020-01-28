<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="Traversa2.Views.Events.EditEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/PlaceForm.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="container">
        <div class=".col-lg-4 .col-lg-offset-2">
            <div class="card-heading">Add an Event </div>

            <div class="card-body">
                <form>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Name of Event:</label>
                            <asp:TextBox ID="EName" runat="server" placeholder="Enter name of place" CssClass="col-lg-5"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Description:</label>
                            <asp:TextBox ID="EDesc" runat="server" placeholder="Enter description of place" CssClass="col-lg-5"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Location(s):</label>
                            <asp:TextBox ID="ELocation" runat="server" placeholder="Enter location(s) of place" CssClass="col-lg-5"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Category:</label>
                            <asp:DropDownList ID="category" runat="server" CssClass="col-lg-5">
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem>Food</asp:ListItem>
                                <asp:ListItem>Music</asp:ListItem>
                                <asp:ListItem>Festival &amp; Concerts</asp:ListItem>
                                <asp:ListItem>Technology</asp:ListItem>
                                <asp:ListItem>Beauty</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Price:</label>
                            <asp:TextBox ID="EPrice" runat="server" placeholder="Enter price range for event" CssClass="col-lg-5"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="row justify-content-center">
                            <label class="col-lg-3 control-label">Image:</label>
                            <asp:Button ID="btnSelect" runat="server" CssClass="col-lg-5" Text="Select" />
                        </div>
                    </div>
                    <br />
                    <asp:Button ID="btnSave" class="btnSave" Text="Save" runat="server" />
                </form>
            </div>
            <!-- end panel-body -->
        </div>
        <!-- end panel -->
        <!-- end container-fluid -->
    </div>
</asp:Content>