<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Traversa2.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/login.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container ice">
        <div class="card hot">
            <div class="card-title text-center  T">Signup</div>
            <div class="card-body">
                <form class="text-center">
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Name:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="nameTb" runat="server" type="text" class="form-control form-control-lg" placeholder="Enter your name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Password:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="EmailTB" runat="server" type="email" class="form-control form-control-lg"  placeholder="Enter your email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Password:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="PasswordTB" runat="server" type="password" class="form-control form-control-lg"  placeholder="Enter your password"></asp:TextBox>
                        </div>
                    </div>
                     <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg"> Confirm Password:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="cfmPasswordTB" runat="server" type="password" class="form-control form-control-lg"  placeholder="Re-enter your password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                        <button type="submit" class="btn btn-success btn-round btn-lg btn-block">Sign up</button>
                    </div>
                    <div class="text-center">
                        <a href="/Views/Users/Login.aspx" class="btn btn-link">Have an account?<u>Login now!</u></a>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
