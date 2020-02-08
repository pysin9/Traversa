<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="UserHomepage.aspx.cs" Inherits="Traversa2.Views.Home.UserHomepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/category.css" rel="stylesheet" />
        <style>
        .card {
            display:inline-block;
            margin: 0.5rem;
            position: relative;
            left: 60px;
        }
        .t{
           width: 187px;
           display: inline-block;

        }
        .r{
            display: inline-block;
        }
    </style>
     <link href="../../Stylesheet/map.css" rel="stylesheet" />
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>

    <script type="text/javascript">
        var markers =
            [
                {
                    title: "National Museum of Singapore",
                    position: new google.maps.LatLng(1.296618, 103.849773)
                },
                {
                    title: "Singapore Botanic Gardens",
                    position: new google.maps.LatLng(1.317040, 103.817329)
                },
                {
                    title: "Gardens by the Bay",
                    position: new google.maps.LatLng(1.283244, 103.863389)
                },
                {
                    title: "Haw Par Villa",
                    position: new google.maps.LatLng(1.284306, 103.782316)
                }
            ];

        function init_map(map_canvas_id, lat, lng, zoomLevel) {
            var myLatLng = new google.maps.LatLng(lat, lng);

            var options = {
                zoom: zoomLevel,
                center: myLatLng,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };

            var map_canvas = document.getElementById(map_canvas_id);

            var map = new google.maps.Map(map_canvas, options);

            // Place markers
            var bounds = new google.maps.LatLngBounds();

            for (var i = 0; i < markers.length; i++) {
                var marker = new google.maps.Marker(markers[i]);
                marker.setMap(map);

                bounds.extend(marker.getPosition());
            }

            map.fitBounds(bounds);
            map.setCenter(bounds.getCenter());
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card-heading text-center">
        <h2>Singapore</h2>
    </div>
    <br />
        <div class="card-body text-center">

            <div id="my_map" style="width: 1075px; height: 435px;"></div>

            <script type="text/javascript">
                init_map('my_map', 1.290270, 103.851959, 14);
            </script>
        </div>

        <br />
        <div class="container">
             <div class=".col-lg-4 .col-lg-offset-2">
             <h5 class="r">Popular by Ratings: </h5>
        <br />
        <asp:DataList ID="DatalistRating" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"  OnItemCommand="DataListCategory_ItemCommand">
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
</asp:Content>
