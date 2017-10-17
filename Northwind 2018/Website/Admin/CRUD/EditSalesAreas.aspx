<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditSalesAreas.aspx.cs" Inherits="Admin_CRUD_EditSalesAreas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="jumbotron">
        <h1>Sales Management Areas</h1>
        <p class="lead">Northwind Trader's employees are assigned to various sales areas, comprised of regions and territories. The initial set of areas focus on the continental US. This page provides <a href="#" data-placement="top" data-toggle="tooltip" title="Read, Edit, Add, Delete -- Cleaner than CRUD">R.E.A.D.</a> management of these areas.</p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="MessageLabel" runat="server" />
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h1>Regions</h1>
        </div>
        <div class="col-md-6">
            <h1>Territories</h1>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
</asp:Content>

