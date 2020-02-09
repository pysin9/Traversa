<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="TimeAndDate.aspx.cs" Inherits="Traversa2.Views.MyItinenary.TimeAndDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="../../Stylesheet/category.css" rel="stylesheet" />
     <link href="../../Stylesheet/login.css" rel="stylesheet" type="text/css" />
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
        <h5 class="r">Create itinerary: </h5>
    </div>
    <br />

    <div class="container">
            <div class=".col-lg-4 .col-lg-offset-2">
            <h5 class="r">Popular by Ratings: </h5>
            <br />
            <asp:DataList ID="DatalistRating" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"  OnItemCommand="DataListCategory_ItemCommand">
                <ItemTemplate >
                    <div class="card text-center r" style="width: 13rem; height: 15rem;">
                        <asp:Image ID="Image2" class="card-img-top" ImageUrl='<%# Bind("ImagePath", "{0}") %>' runat="server" height="165px"  width="206px"/>
                        <br />
                
                        <div class="card-body">
                           <asp:Label ID="Label1" runat="server" Text='<%# Bind("AvgRating") %>'></asp:Label><asp:Label ID="Label2" runat="server" Text="/5"></asp:Label>
                            <br />
                           <asp:LinkButton ID="LinkButtonRating" runat="server" Text='<%# Bind("PName") %>' CommandName="Go" CommandArgument='<%# Eval("PlId") %>' ></asp:LinkButton>
                        </div>
                        </div>
                </ItemTemplate>
            </asp:DataList> 
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
