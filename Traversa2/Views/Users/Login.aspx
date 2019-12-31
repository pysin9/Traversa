<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Traversa2.Views.Users.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/login.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ice">
        <div class="card hot">
            <div class="card-title text-center  T">Login</div>
            <div class="card-body">
                <form class="text-center">
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Email:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="emailTB" runat="server" type="email" class="form-control form-control-lg" placeholder="Enter your email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Password:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="passwordTB" runat="server" type="password" class="form-control form-control-lg"  placeholder="Enter your password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                        <button type="submit" class="btn btn-success btn-round btn-lg btn-block">Login</button>
                    </div>
                    <div class="text-center">
                        <a href="/Register" class="btn btn-link">Don't have an account?<u>Register now!</u></a>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
