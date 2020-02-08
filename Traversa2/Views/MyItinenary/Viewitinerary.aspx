<%@ Page Title="" Language="C#" MasterPageFile="~/navbarAfterLogin.Master" AutoEventWireup="true" CodeBehind="Viewitinerary.aspx.cs" Inherits="Traversa2.Views.MyItinenary.Viewitinerary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
     <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
     <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
      <script>
      $( function() {
        $( "#accordion" ).accordion();
      } );
      </script>
    
    
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
            position: relative;
             bottom: 9px;
              left: 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <div class="text-center">
        <asp:Label ID="Labelerr" runat="server" Text=""></asp:Label>
    </div>
    
    <div class="container">
        <h5 class="r">My Itinerary: </h5>
        <div class="u">
            <asp:LinkButton ID="LbtnCreate"  class="btn btn-info" runat="server" OnClick="LbtnCreate_Click">Create</asp:LinkButton>
        </div>   
    <br />
    

    
    <div class="text-center container">
        <asp:Label ID="LabelMessage" runat="server" Text="Nothing to see here" Visible="true"></asp:Label>
      <%--  <asp:DataList ID="DataListItinName" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" Visible="false" CssClass="i" OnItemCommand="DataListItinName_ItemCommand">
            <ItemTemplate >
                <div class="dropdown">
                    <asp:Button ID="Buttonname" CommandName="Show"  class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" runat="server" Text='<%# Bind("IName") %>'/>
                      <div class="dropdown-menu" aria-labelledby="dropdownMenu2">
                          
                         <asp:LinkButton ID="LinkButtonAdd" class="btn btn-info dropdown-item" CommandName="Addd"  CommandArgument='<%# Eval("IName") %> ' runat="server">Add+</asp:LinkButton>--%>
                             <%-- <asp:Image ID="Image3" runat="server" CssClass="col-md-4 i" ImageUrl='<%# Bind("ImagePath") %>' Visible="false"/>--%>
                             <%-- <asp:Label ID="Labelna" runat="server" Text='<%# Bind("PName") %>'></asp:Label>--%>
<%--                      </div>
                    </div>
                           
                           
           </div>
                </ItemTemplate>
           </asp:DataList>--%>
        
        
    </div>
        </div>

        
    
</asp:Content>
