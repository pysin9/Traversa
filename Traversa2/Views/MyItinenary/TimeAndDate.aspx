<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="TimeAndDate.aspx.cs" Inherits="Traversa2.Views.MyItinenary.TimeAndDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ice">
        <div class="card hot">
            <div class="card-title text-center  T">Create Itinerary</div>
            <div class="card-body">
                <form class="text-center">
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <div class="form-group row b">
                                <asp:Label ID="Label1" runat="server" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" Text=''></asp:Label>
                                <div class="col-sm-5">
                                    <asp:Image ID="Image1" runat="server" />
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg"></label>
                        <div class="col-sm-5">
                            <asp:Calendar ID="CalendarIT" runat="server" ondayrender="CalendarIT_DayRender"></asp:Calendar>
                        </div>
                    </div>
                    <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                    </div>
                    
                </form>
            </div>
        </div>
    </div>
</asp:Content>
