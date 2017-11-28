﻿using NorthwindTraders.BLL;
using NorthwindTraders.Entities.DTOs;
using NorthwindTraders.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sales_CustomerOrderForm : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    #region Customer Selection
    protected void HistorySelectionList_DataBound(object sender, EventArgs e)
    {
        // Select the first filter item in the radio list
        HistorySelectionList.SelectedIndex = 0;
    }

    private void ToggleActiveCustomer(bool isActive)
    {
        // Not active - select a new customer
        SelectCustomer.Visible =
        CustomerDropDown.Enabled =
            !isActive;
        // Active - work with selected customer
        NewOrder.Visible =
        CancelSelection.Visible =
        CustomerInfoPanel.Visible =
        CustomerOrderHistoryPanel.Visible =
            isActive;
    }

    protected void SelectCustomer_Click(object sender, EventArgs e)
    {
        bool isSelected = CustomerDropDown.SelectedIndex > 0;
        ToggleActiveCustomer(isSelected);
        if (isSelected)
        {
            // Get the customer summary information
            var controller = new SalesController();
            var info = controller.GetCustomerSummary(CustomerDropDown.SelectedValue);
            CompanyName.Text = info.CompanyName;
            ContactName.Text = info.ContactName;
            Phone.Text = info.Phone;
            Fax.Text = info.Fax;
        }
    }

    protected void CancelSelection_Click(object sender, EventArgs e)
    {
        CustomerDropDown.SelectedIndex = 0;
        ToggleActiveCustomer(CustomerDropDown.SelectedIndex > 0);
    }
    #endregion

    #region Order Creation/Selection
    #region Event Handlers for Form Controls
    protected void NewOrder_Click(object sender, EventArgs e)
    {
        // Hide the history GridView


        // prepare the OrderItemsListView for bulk editing
        var orderItems = new List<CustomerOrderItem>();
        SetupOrderForEditing(orderItems);
    }

    protected void CustomerOrderHistoryGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        // if selected
        if (CustomerOrderHistoryGridView.SelectedIndex >= 0)
        {
            //    disable the NewOrder button
            //    prepare the OrderItemsListView
            int orderId = int.Parse(CustomerOrderHistoryGridView.SelectedValue.ToString());
            var controller = new SalesController();
            var order = controller.GetExistingOrder(orderId);

            SetupOrderDates(order);
            SetupOrderForEditing(order.Details.ToList());
            //    if order is shipped
            //        disable the OrderItemsListView
        }
        // else
        //    enable the NewOrder button
    }
    #endregion

    #region "Helper" methods
    private void SetupOrderDates(CustomerOrderWithDetails order)
    {
        if (order.OrderDate.HasValue)
            EditOrderDate.Text = order.OrderDate.Value.ToString("yyyy-MM-dd");
        if (order.RequiredDate.HasValue)
            EditRequiredDate.Text = order.RequiredDate.Value.ToString("yyyy-MM-dd");
        if (order.ShippedDate.HasValue)
            EditShippedOnDate.Text = order.ShippedDate.Value.ToString("yyyy-MM-dd");
        if (order.Freight.HasValue)
            EditFreight.Text = order.Freight.Value.ToString("C");
    }

    private void SetupOrderForEditing(IList<CustomerOrderItem> orderItems)
    {
        // Bind the ListView
        OrderItemsListView.DataSource = orderItems;
        OrderItemsListView.DataBind();

        // Calculate the Totals
        decimal total = 0;
        decimal totalRaw = 0;
        foreach (var item in orderItems)
        {
            totalRaw += (item.Quantity * item.UnitPrice);
            total += (item.Quantity * item.UnitPrice) - (item.Quantity * item.UnitPrice) * (Convert.ToDecimal(item.DiscountPercent));
        }
        decimal freight;
        decimal.TryParse(EditFreight.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out freight);
        decimal totalWithFreight = total + freight;
        // Display the totals
        OrderTotal.Text = totalWithFreight.ToString("C");
        TotalExtendedLabel.Text = totalRaw.ToString("C");
        TotalDiscountedLabel.Text = total.ToString("C");

        // Setup the ListView's Products (InsertTemplate)
        var controller = new SalesController();
        var products = controller.GetProducts();
        var dropDown = OrderItemsListView.InsertItem.FindControl("AvailableProducts") as DropDownList;
        dropDown.DataSource = FilteredProductList(orderItems);
        dropDown.DataTextField = "Text";
        dropDown.DataValueField = "Key";
        dropDown.DataBind();
        dropDown.Items.Insert(0, "[select a product]");
        ResetInsertItemDefaultValues(dropDown, 0, 0, 0);
    }

    private IList<KeyValueOption> FilteredProductList(IList<CustomerOrderItem> currentItems)
    {
        var controller = new SalesController();
        var products = controller.GetProducts();
        products.RemoveAll(k => 
                           currentItems.Any(ci => 
                                            k.Key == ci.ProductId.ToString()));
        return products;
    }

    private IList<CustomerOrderItem> ExtractFromOrderItemsListViewItems()
    {
        var dataInForm = new List<CustomerOrderItem>();

        foreach(ListViewDataItem item in OrderItemsListView.Items)
        {
            dataInForm.Add(FromDataItem(item));
        }

        return dataInForm;
    }

    private CustomerOrderItem FromDataItem(ListViewDataItem item)
    {
        var productIdControl = item.FindControl("ProductId") as HiddenField;
        var nameLabel = item.FindControl("ProductNameLabel") as Label;
        var inStockLabel = item.FindControl("InStockQuantityLabel") as Label;
        var qtyPerUnitLabel = item.FindControl("QuantityPerUnitLabel") as Label;
        var qtyTextBox = item.FindControl("QuantityTextBox") as TextBox;
        var priceTextBox = item.FindControl("UnitPriceTextBox") as TextBox;
        var discountTextBox = item.FindControl("DiscountPercentTextBox") as TextBox;
        var result = new CustomerOrderItem
        {
            ProductId = int.Parse(productIdControl.Value),
            ProductName = nameLabel.Text,
            InStockQuantity = short.Parse(inStockLabel.Text),
            QuantityPerUnit = qtyPerUnitLabel.Text,
            Quantity = short.Parse(qtyTextBox.Text),
            UnitPrice = decimal.Parse(priceTextBox.Text, System.Globalization.NumberStyles.Currency),
            DiscountPercent = float.Parse(discountTextBox.Text.Replace("%", ""))/100
        };
        return result;
    }

    /// <summary>
    /// Resets the Quantity, Price, and Discount for new products.
    /// </summary>
    /// <param name="dropDown"></param>
    /// <param name="qty"></param>
    /// <param name="price"></param>
    /// <param name="discount"></param>
    /// <remarks>
    /// <para>
    /// Note that this method has been specially crafted to work with the <see cref="OrderItemsListView"/> ListView control on this form.
    /// <para>
    /// This method works by first finding the "parent" object that contains the DropDownList (which, in our case, is the InsertItemTemplate of the <see cref="OrderItemsListView"/> ListView control), and then looks for specifically named TextBox controls so that it can set their .Text values to the supplied qty, price, and discount.
    /// </para>
    /// </remarks>
    private void ResetInsertItemDefaultValues(DropDownList dropDown, int qty, decimal price, float discount)
    {
        ListViewItem container = (ListViewItem)dropDown.NamingContainer;
        var newItemQty = container.FindControl("NewItemQuantity") as TextBox;
        var newItemPrice = container.FindControl("NewItemPrice") as TextBox;
        var newItemDiscount = container.FindControl("NewItemDiscount") as TextBox;
        newItemDiscount.Text = discount.ToString();
        newItemPrice.Text = price.ToString("C");
        newItemQty.Text = qty.ToString();
    }
    #endregion
    #endregion

    #region Order Editing
    #region Event Handlers
    protected void AvailableProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList dropDown = (DropDownList)sender;
        // container is current row of Listview,
        // which holds the dropdownlist that caused postback 
        if (dropDown.SelectedIndex > 0)
        {
            var controller = new SalesController();
            var product = controller.GetProduct(int.Parse(dropDown.SelectedValue));
            ResetInsertItemDefaultValues(dropDown, 1, product.UnitPrice, 0);
        }
        else
        {
            ResetInsertItemDefaultValues(dropDown, 0, 0, 0);
        }
    }
    
    protected void OrderItemsListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Insert":
                InsertOrderItem();
                break;
            case "Delete":
                int productId = int.Parse(e.CommandArgument.ToString());
                var items = ExtractFromOrderItemsListViewItems();
                var toRemove = items.Single(x => x.ProductId == productId);
                items.Remove(toRemove);
                SetupOrderForEditing(items);
                break;
            case "Refresh":
                SetupOrderForEditing(ExtractFromOrderItemsListViewItems());
                break;
        }
        e.Handled = true;
    }

    //protected void OrderItemsListView_ItemInserting(object sender, ListViewInsertEventArgs e)
    //{
    //}
    #endregion

    #region Helper Methods
    private void InsertOrderItem()
    {
        var container = OrderItemsListView.InsertItem;
        var dropDown = container.FindControl("AvailableProducts") as DropDownList;
        if (dropDown.SelectedIndex > 0)
        {
            // Get the product details and prep the new item to add to the order listview
            var controller = new SalesController();
            var product = controller.GetProduct(int.Parse(dropDown.SelectedValue));

            // Get the qty, price, and discount from the textboxes
            var theQty = container.FindControl("NewItemQuantity") as TextBox;
            var thePrice = container.FindControl("NewItemPrice") as TextBox;
            var theDiscount = container.FindControl("NewItemDiscount") as TextBox;

            // Place them inside of hidden fields
            var newItem = new CustomerOrderItem
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                InStockQuantity = product.InStockQuantity,
                QuantityPerUnit = product.QuantityPerUnit,
                Quantity = short.Parse(theQty.Text),
                UnitPrice = decimal.Parse(thePrice.Text, System.Globalization.NumberStyles.Currency),
                DiscountPercent = float.Parse(theDiscount.Text)/100
            };

            // Insert the item
            var existing = ExtractFromOrderItemsListViewItems();
            existing.Add(newItem);
            SetupOrderForEditing(existing);
        }
    }
    #endregion
    #endregion

    protected Label TotalExtendedLabel { get; set; }
    protected Label TotalDiscountedLabel { get; set; }

    protected void OrderItemsListView_LayoutCreated(object sender, EventArgs e)
    {
        TotalExtendedLabel = OrderItemsListView.FindControl("TotalExtended") as Label;
        TotalDiscountedLabel = OrderItemsListView.FindControl("TotalDiscounted") as Label;
    }
}