<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerOrderForm.aspx.cs" Inherits="Sales_CustomerOrderForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Customer Order Form</h1>
    <asp:Panel ID="CustomerSelectionPanel" runat="server" Visible="true" CssClass="row">
        <div class="col-md-6">
            <asp:Label ID="Label1" runat="server" Text="Customer: " AssociatedControlID="CustomerDropDown" />
            <asp:DropDownList ID="CustomerDropDown" runat="server" DataSourceID="CustomerDataSource" DataTextField="Text" DataValueField="Key" AppendDataBoundItems="true" CssClass="form-control" style="display: inline-block;">
                <asp:ListItem Value="">[select a customer]</asp:ListItem>
            </asp:DropDownList>
            <asp:ObjectDataSource runat="server" ID="CustomerDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCustomerNames" TypeName="NorthwindTraders.BLL.SalesController"></asp:ObjectDataSource>
            <asp:LinkButton ID="SelectCustomer" runat="server" OnClick="SelectCustomer_Click" CssClass="btn btn-default">Select</asp:LinkButton>
            <asp:LinkButton ID="CancelSelection" runat="server" OnClick="CancelSelection_Click" CssClass="btn btn-default" Visible="false">Cancel</asp:LinkButton>
            <asp:LinkButton ID="NewOrder" runat="server" OnClick="NewOrder_Click" CssClass="btn btn-primary" Visible="false">New Order</asp:LinkButton>
        </div>
        <asp:Panel ID="CustomerInfoPanel" runat="server" CssClass="col-md-6" Visible="false">
            <div class="row">
                <div class="col-sm-3"><asp:Label ID="CompanyNameLabel" runat="server" Text="Company Name" AssociatedControlID="CompanyName" /></div>
                <div class="col-sm-9"><asp:TextBox ID="CompanyName" runat="server" Enabled="false" CssClass="form-control" /></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><asp:Label ID="ContactNameLabel" runat="server" Text="Contact Name" AssociatedControlID="ContactName" /></div>
                <div class="col-sm-9"><asp:TextBox ID="ContactName" runat="server" Enabled="false" CssClass="form-control" /></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><asp:Label ID="PhoneLabel" runat="server" Text="Phone" AssociatedControlID="Phone" /></div>
                <div class="col-sm-9"><asp:TextBox ID="Phone" runat="server" Enabled="false" CssClass="form-control" /></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><asp:Label ID="FaxLabel" runat="server" Text="Fax" AssociatedControlID="Fax" /></div>
                <div class="col-sm-9"><asp:TextBox ID="Fax" runat="server" Enabled="false" CssClass="form-control" /></div>
            </div>
        </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="CustomerOrderHistoryPanel" runat="server" CssClass="row" Visible="false">
        <div class="col-md-12">
            <h3>Order History</h3>
            <asp:Label ID="FilterLabel" runat="server" AssociatedControlID="HistorySelectionList" Text="Order History Filter" />
            <asp:RadioButtonList ID="HistorySelectionList" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" RepeatLayout="Flow" OnDataBound="HistorySelectionList_DataBound" DataSourceID="HistoryFilterDataSource" DataTextField="Text" DataValueField="Key">
            </asp:RadioButtonList>
            <asp:ObjectDataSource runat="server" ID="HistoryFilterDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrderHistoryFilters" TypeName="NorthwindTraders.BLL.SalesController"></asp:ObjectDataSource>
            <hr />
            <asp:GridView ID="CustomerOrderHistoryGridView" runat="server" CssClass="table table-condensed table-hover" AutoGenerateColumns="False" DataSourceID="OrderHistoryDataSource" DataKeyNames="OrderId" OnSelectedIndexChanged="CustomerOrderHistoryGridView_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                </Columns>
                <EmptyDataTemplate>
                    <div>No customer order history available for the selected filter.</div>
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="Employee" HeaderText="Employee" SortExpression="Employee"></asp:BoundField>
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate"></asp:BoundField>
                    <asp:BoundField DataField="RequiredDate" HeaderText="Required Date" SortExpression="RequiredDate"></asp:BoundField>
                    <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" SortExpression="ShippedDate"></asp:BoundField>
                    <asp:BoundField DataField="Shipper" HeaderText="Shipper" SortExpression="Shipper"></asp:BoundField>
                    <asp:BoundField DataField="Freight" HeaderText="Freight" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:C}" SortExpression="Freight"></asp:BoundField>
                    <asp:BoundField DataField="OrderTotal" HeaderText="Order Total" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:C}" SortExpression="OrderTotal"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource runat="server" ID="OrderHistoryDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrdersByCustomer" TypeName="NorthwindTraders.BLL.SalesController">
                <SelectParameters>
                    <asp:ControlParameter ControlID="CustomerDropDown" PropertyName="SelectedValue" Name="customerId" Type="String"></asp:ControlParameter>
                    <asp:ControlParameter ControlID="HistorySelectionList" PropertyName="SelectedValue" Name="filter" Type="String" DefaultValue="&quot;&quot;"></asp:ControlParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>

    </asp:Panel>
</asp:Content>

