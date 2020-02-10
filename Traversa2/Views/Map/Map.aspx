<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="Traversa2.Views.Map.Map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Stylesheet/map.css" rel="stylesheet" />
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>

    <script type="text/javascript">
        var markers =
            [
                {
                    title: "Bugis Street",
                    position: new google.maps.LatLng(1.300578, 103.855032),
                },
                {
                    title: "National Museum of Singapore",
                    position: new google.maps.LatLng(1.296618, 103.849773)
                },
                {
                    title: "East Coast Park",
                    position: new google.maps.LatLng(1.301058, 103.913800)
                },
                {
                    title: "Singapore Parliament House",
                    position: new google.maps.LatLng(1.289100, 103.850443)
                }
            ];

        // Create the info window...
        var info = new google.maps.InfoWindow({ content: "<h3>Hello, world!</h3>" });

        // Display the info window when the marker is clicked...
        google.maps.event.addListener(marker, 'click', function () {
            info.open(map, marker);
        });

        function init_map(map_canvas_id, lat, lng, zoomLevel, infoWindowContents) {
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

                if (infoWindowContents && infoWindowContents.length > i)
                    createInfoWindow(map, marker, infoWindowContents[i]);
                bounds.extend(marker.getPosition());
            }

            map.fitBounds(bounds);
            map.setCenter(bounds.getCenter());
        }

        function createInfoWindow(map, marker, infoWindowProperties) {
            var info = new google.maps.InfoWindow(infoWindowProperties);

            google.maps.event.addListener(marker, 'click', function () {
                info.open(map, marker);
            });
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
        <br />
        <br />
        <center>
            <table border="1" style="width: 1000px; height:200px;">
                <tr>
                    <td>
                        Place
                    </td>
                    <td>
                        Address
                    </td>
                </tr>
                <tr>
                    <td>
                        Bugis Street
                    </td>
                    <td>
                        3 New Bugis Street, Singapore 188867
                    </td>
                </tr>
                <tr>
                    <td>
                        National Museum of Singapore
                    </td>
                    <td>
                        93 Stamford Rd, Singapore 178897
                    </td>
                </tr>
                <tr>
                    <td>
                        East Coast Park
                    </td>
                    <td>
                        E Coast Park Service Rd
                    </td>
                </tr>
                <tr>
                    <td>
                        Singapore Parliament House
                    </td>
                    <td>
                        1 Parliament Pl, Singapore 178880
                    </td>
                </tr>
            </table>
        </center>

        <script type="text/javascript">
            init_map('my_map', 1.290270, 103.851959, 14);
        </script>
    </div>
</asp:Content>