<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="Traversa2.Views.Map.Map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        <h2>Map</h2>
    </div>
    <br />
    <div class="card-body text-center">

        <div id="my_map" style="width: 1075px; height: 435px;"></div>

        <p>
            You are viewing where the famous tourist attractions are in Singapore!
        </p>

        <script type="text/javascript">
            init_map('my_map', 1.290270, 103.851959, 14);
        </script>
    </div>
</asp:Content>

