﻿<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="Traversa2.Views.Places.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ice">
            <div class="row">
                <div class="col-lg-5 col-md-10 ml-auto mr-auto">
                    <div class="card card-login">
                        <form class="form" action="/admin/create" method="POST">
                            <h2 class="card-title text-center">Create Category</h2>
                            <div class="card-body">
                                <div class="input-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                            <i class="material-icons">&#128288;</i>
                                        </span>
                                    </div>
                                    <div class="try-select" style="width:300px;">
                                        <select name="category" class="form-control" id="exampleFormControlSelect1">
                                            <option id='organic' value="Fresh">Fresh</option>
                                            <option id='option 2' value="Dairy">Dairy</option>
                                            <option id='option 3' value="Beverages">Beverages</option>
                                            <option id='option 4' value="Frozen">Frozen</option>
                                            <option id='option 4' value="Health">Health</option>
                                            <option id='option 4' value="Snacks">Snacks</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center">
                                <button type="submit" class="btn btn-success btn-round">Create</button>
                            </div>
                        </form>
                    </div>

                </div>
            </div>
        </div>
</asp:Content>
