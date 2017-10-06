<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sandbox.aspx.cs" Inherits="Sandbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Employees</h1>
    <div class="row">
        <asp:Repeater ID="EmployeeBioRepeater" runat="server"
            ItemType="NorthwindTraders.BLL.SandboxController+Bio"
            DataSourceID="BioDataSource">
            <ItemTemplate>
                <div class="col-md-6">
                    <img src='data:<%# Item.MimeType.Replace(@"\",@"/") %>;base64,<%# Convert.ToBase64String(Item.Photo) %>'
                        class="pull-left img-thumbnail"
                        style="width:25%;height:auto; margin-right: 12px;" />
                    <h3><%# Item.FullName %></h3>
                    <h4><%# Item.JobTitle %>
                        <small>(Extension <%# Item.CompanyPhoneExtension %></small>
                    </h4>
                    <p><%# Item.Notes %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource runat="server" ID="BioDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="EmployeeBios" TypeName="NorthwindTraders.BLL.SandboxController"></asp:ObjectDataSource>
    </div>

<%--    <hr />
    <h1 class="page-header">Customer Order Histories</h1>
    <div class="row">
        <asp:Repeater ID="OrderHistoryRepeater" runat="server"
            ItemType="NorthwindTraders.BLL.SandboxController+CustomerOrderHistory"
            DataSourceID="OrderHistoryDataSource">
            <ItemTemplate>
                <div class="col-md-4">
                    <h3><%# Item.Company %></h3>
                    <p>
                        <%# Item.TotalCost.ToString("C") %>
                        <span runat="server" visible="<%# Item.FreightCharge.HasValue %>">
                            (<%# Item.FreightCharge.Value.ToString("C") %> freight)
                        </span>
                        &mdash; Ordered on <%# Item.OrderDate.Value.ToShortDateString() %>
                    </p>
                    <asp:GridView ID="OrderDetailGridView" runat="server"
                        DataSource="<%# Item.OrderItems %>"></asp:GridView>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <asp:ObjectDataSource runat="server" ID="OrderHistoryDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllCustomerOrders" TypeName="NorthwindTraders.BLL.SandboxController"></asp:ObjectDataSource>
    </div>--%>


    <hr />
    <h1 class="page-header">Clearance Items</h1>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SandboxDataSource" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company"></asp:BoundField>
            <asp:BoundField DataField="OrdersToDate" HeaderText="OrdersToDate" SortExpression="OrdersToDate"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="SandboxDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ShipperSummary" TypeName="NorthwindTraders.BLL.SandboxController"></asp:ObjectDataSource>
</asp:Content>

