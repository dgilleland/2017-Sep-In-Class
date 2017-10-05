<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sandbox.aspx.cs" Inherits="Sandbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Clearance Items</h1>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SandboxDataSource" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company"></asp:BoundField>
            <asp:BoundField DataField="OrdersToDate" HeaderText="OrdersToDate" SortExpression="OrdersToDate"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="SandboxDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ShipperSummary" TypeName="NorthwindTraders.BLL.SandboxController"></asp:ObjectDataSource>
</asp:Content>

