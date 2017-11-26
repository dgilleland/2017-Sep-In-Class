<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerOrderForm.aspx.cs" Inherits="Sales_CustomerOrderForm" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Customer Order Form</h1>
    <asp:Panel ID="CustomerSelectionPanel" runat="server" Visible="true" CssClass="row">
        <div class="col-md-6">
            <asp:Label ID="Label1" runat="server" Text="Customer: " AssociatedControlID="CustomerDropDown" />
            <asp:DropDownList ID="CustomerDropDown" runat="server" DataSourceID="CustomerDataSource" DataTextField="Text" DataValueField="Key" CssClass="form-control" style="display: inline-block;">
            </asp:DropDownList>
            <asp:ObjectDataSource runat="server" ID="CustomerDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCustomerNames" TypeName="NorthwindTraders.BLL.SalesController">
                <SelectParameters>
                    <asp:ControlParameter ControlID="AllCustomersCheckBox" PropertyName="Checked" Name="listAll" Type="Boolean"></asp:ControlParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:LinkButton ID="SelectCustomer" runat="server" OnClick="SelectCustomer_Click" CssClass="btn btn-default">Select</asp:LinkButton>
            <asp:LinkButton ID="CancelSelection" runat="server" OnClick="CancelSelection_Click" CssClass="btn btn-default" Visible="false">Cancel</asp:LinkButton>
            <asp:LinkButton ID="NewOrder" runat="server" OnClick="NewOrder_Click" CssClass="btn btn-primary" Visible="false">New Order</asp:LinkButton>
            <div>
                <asp:CheckBox ID="AllCustomersCheckBox" runat="server" Checked="true" AutoPostBack="true" />
                <asp:Label ID="Label3" runat="server" Text="All Customers" AssociatedControlID="AllCustomersCheckBox" />
            </div>
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
            <asp:GridView ID="CustomerOrderHistoryGridView" runat="server" CssClass="table table-condensed table-hover" AutoGenerateColumns="False" DataSourceID="OrderHistoryDataSource" DataKeyNames="OrderId" OnSelectedIndexChanged="CustomerOrderHistoryGridView_SelectedIndexChanged" SelectedRowStyle-CssClass="active">
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

    <asp:Panel ID="CustomerOrderEditingPanel" runat="server" CssClass="row">
        <div class="col-md-12">
            <h3>Edit Order</h3>
            <asp:ListView ID="OrderItemsListView" runat="server"
                 ItemType="NorthwindTraders.Entities.POCOs.CustomerOrderItem"
                 InsertItemPosition="FirstItem"
                 OnItemCommand="OrderItemsListView_ItemCommand">
                <LayoutTemplate>
                    <table class="table table-hover table-condensed table-bordered">
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                </LayoutTemplate>
                <InsertItemTemplate>
                    <tr class="success">
                        <td colspan="3">
                            <asp:Label ID="ProductsLabel" runat="server" AssociatedControlID="AvailableProducts" Text="Add Product:"></asp:Label>
                            <asp:DropDownList ID="AvailableProducts" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="AvailableProducts_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:HiddenField ID="ProductId" runat="server" Value="<%# BindItem.ProductId %>" />
                            <asp:HiddenField ID="ProductName" runat="server" Value="<%# BindItem.ProductName %>" />
                            <asp:HiddenField ID="InStockQuantity" runat="server" Value="<%# BindItem.InStockQuantity %>" />
                            <asp:HiddenField ID="QuantityPerUnit" runat="server" Value="<%# BindItem.QuantityPerUnit %>" />
                            <asp:HiddenField ID="Quantity" runat="server" Value="<%# BindItem.Quantity %>" />
                            <asp:HiddenField ID="UnitPrice" runat="server" Value="<%# BindItem.UnitPrice %>" />
                            <asp:HiddenField ID="DiscountPercent" runat="server" Value="<%# BindItem.DiscountPercent %>" />
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="NewItemQuantity" Text="Quantity"></asp:Label>
                            <asp:TextBox ID="NewItemQuantity" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="PriceLabel" runat="server" AssociatedControlID="NewItemPrice" Text="Price"></asp:Label>
                            <asp:TextBox ID="NewItemPrice" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="DiscountLabel" runat="server" AssociatedControlID="NewItemDiscount" Text="Discount"></asp:Label>
                            <asp:TextBox ID="NewItemDiscount" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td style="vertical-align:bottom;">
                            <asp:LinkButton ID="AddItem" runat="server" CommandName="Insert" Text="Add" CssClass="btn btn-success"></asp:LinkButton>
                        </td>
                    </tr>
                    <tr runat="server" style="">
                        <th runat="server">Product Name</th>
                        <th runat="server">In Stock</th>
                        <th runat="server">Qty Per Unit</th>
                        <th runat="server">Order Qty</th>
                        <th runat="server">Unit Price</th>
                        <th runat="server">Extended Price</th>
                        <th runat="server">Discount</th>
                        <th runat="server">Discount Price</th>
                        <th runat="server"></th>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:Label id="ProductNameLabel" runat="server" Text="<%# Item.ProductName %>" /></td>
                        <td><asp:Label id="InStockQuantityLabel" runat="server" Text="<%# Item.InStockQuantity %>" /></td>
                        <td><asp:Label id="QuantityPerUnitLabel" runat="server" Text="<%# Item.QuantityPerUnit %>" /></td>
                        <td><asp:TextBox id="QuantityTextBox" runat="server" Text="<%# Item.Quantity %>" /></td>
                        <td>$ <asp:TextBox id="UnitPriceTextBox" runat="server" Text="<%# Item.UnitPrice %>" /></td>
                        <td><asp:Label id="Label4" runat="server" Text='<%# (Item.Quantity * Item.UnitPrice).ToString("C") %>' /></td>
                        <td><asp:TextBox id="DiscountPercentTextBox" runat="server" Text="<%# Item.DiscountPercent %>" /> %</td>
                        <td><asp:Label id="Label5" runat="server" Text='<%# ((Item.Quantity * Item.UnitPrice) - (Item.Quantity * Item.UnitPrice) * (Convert.ToDecimal(Item.DiscountPercent) / 100M)).ToString("C") %>' /></td>
                        <td></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </asp:Panel>
</asp:Content>