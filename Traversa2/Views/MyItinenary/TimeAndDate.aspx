<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="TimeAndDate.aspx.cs" Inherits="Traversa2.Views.MyItinenary.TimeAndDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
         
        .t{
           width: 187px;
           display: inline-block;

        }
        .r{
            display: inline-block;
        }
        .u{
            left: 10px;
            position:relative;
            display:inline-block;
        }
        .i{
            display: inline-block;
        }
        .p{
            display:inline-block;
          
        }
        .T {
            font-size: 40px;
            font-family: "Roboto", "Helvetica", "Arial", sans-serif;
         }
    </style>
    <script>

    </script>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="text-center">
        <asp:Label ID="Labelerr" runat="server" Text=""></asp:Label>
    </div>
    <div class="container">
        <h5 class="r">My Itinerary: </h5>
        <div class="u">
          <button type="button" class="btn btn-info" data-toggle="modal" data-target="#exampleModalCenter">
            Create
          </button>
        </div>
    </div>
    <br />
     <div class="container ice">
        <div class="card hot">
            <div class="card-title text-center  T">Add Itinerary</div>
            <div class="card-body">
                <form class="text-center">
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Itinerary Name:</label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="NameTB" runat="server"  class="form-control form-control-lg" placeholder="Enter Itinerary Name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row b">
                        <label for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg">Choose Place:</label>
                        <div class="col-sm-5">
                           <asp:DropDownList ID="DDLPlaces" runat="server" CssClass="col-lg-5">
                              <asp:ListItem></asp:ListItem>
                          </asp:DropDownList>
                    </div>
                    </div>
                    <%--<div  class="form-group row b">
                        <asp:Label ID="Labeldate" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" runat="server" Text="Choose a Date"></asp:Label>
                         <asp:TextBox ID="TextBoxDate" class="col-md-5 p" runat="server" placeholder="Choose a date"></asp:TextBox>
                          <asp:ImageButton ID="ImageButtonDate" runat="server" ImageUrl="~/images/calendar-512.png" Width="50px" Height="40px" OnClick="ImageButtonDate_Click" />
                          <br />
                        <br />
                          <asp:Calendar ID="CalendarDate" runat="server"  OnSelectionChanged="CalendarDate_SelectionChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" >
                              <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                              <NextPrevStyle VerticalAlign="Bottom" />
                              <OtherMonthDayStyle ForeColor="#808080" />
                              <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                              <SelectorStyle BackColor="#CCCCCC" />
                              <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                              <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                              <WeekendDayStyle BackColor="#FFFFCC" />
                          </asp:Calendar>
                    </div>--%>
                    <div class="text-center col-sm-5 col-md-5 col-lg-6 f">
                        <asp:Button ID="btnCreate" class="btn btn-success btn-round btn-lg btn-block" runat="server" Text="Create" OnClick="btnCreate_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>


</asp:Content>
