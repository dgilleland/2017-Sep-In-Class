using NorthwindTraders.BLL;
using NorthwindTraders.Entities.POCOs;
using System;
using System.Collections.Generic;
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
    protected void NewOrder_Click(object sender, EventArgs e)
    {
        // Hide the history GridView


        // prepare the OrderItemsListView for bulk editing
        var orderItems = new List<CustomerOrderItem>();
        OrderItemsListView.DataSource = orderItems;
        OrderItemsListView.DataBind();

        var controller = new SalesController();
        var products = controller.GetProducts();
        var dropDown = OrderItemsListView.InsertItem.FindControl("AvailableProducts") as DropDownList;
        dropDown.DataSource = products;
        dropDown.DataTextField = "Text";
        dropDown.DataValueField = "Key";
        dropDown.DataBind();
        dropDown.Items.Insert(0, "[select a product]");
        ResetInsertItemValues(dropDown, 0, 0, 0);
    }

    protected void CustomerOrderHistoryGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        // if selected
        //    disable the NewOrder button
        //    prepare the OrderItemsListView
        //    if order is shipped
        //        disable the OrderItemsListView
        // else
        //    enable the NewOrder button
    }

    protected void AvailableProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList dropDown = (DropDownList)sender;
        // container is current row of Listview,
        // which holds the dropdownlist that caused postback 
        if (dropDown.SelectedIndex > 0)
        {
            var controller = new SalesController();
            var product = controller.GetProduct(int.Parse(dropDown.SelectedValue));
            ResetInsertItemValues(dropDown, 1, product.UnitPrice, 0);
        }
        else
        {
            ResetInsertItemValues(dropDown, 0, 0, 0);
        }
    }

    private void ResetInsertItemValues(DropDownList dropDown, int qty, decimal price, float discount)
    {
        ListViewItem container = (ListViewItem)dropDown.NamingContainer;
        var newItemQty = container.FindControl("NewItemQuantity") as TextBox;
        var newItemPrice = container.FindControl("NewItemPrice") as TextBox;
        var newItemDiscount = container.FindControl("NewItemDiscount") as TextBox;
        newItemDiscount.Text = discount.ToString();
        newItemPrice.Text = price.ToString("C");
        newItemQty.Text = qty.ToString();
    }

    protected void OrderItemsListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Insert":
                InsertOrderItem();
                break;
            case "Delete":

                break;
            case "Update":

                break;
        }
    }
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
            var newId = container.FindControl("ProductId") as HiddenField;
            newId.Value = product.ProductId.ToString();
            var newName = container.FindControl("ProductName") as HiddenField;
            newName.Value = product.ProductName;
            var newInStock = container.FindControl("InStockQuantity") as HiddenField;
            newInStock.Value = product.InStockQuantity.ToString();
            var newQtyPerUnit = container.FindControl("QuantityPerUnit") as HiddenField;
            newQtyPerUnit.Value = product.QuantityPerUnit;

            var newDiscount = container.FindControl("DiscountPercent") as HiddenField;
            newDiscount.Value = theDiscount.Text;
            var newQuantity = container.FindControl("Quantity") as HiddenField;
            newQuantity.Value = theQty.Text;
            var newPrice = container.FindControl("UnitPrice") as HiddenField;
            newPrice.Value = decimal.Parse(thePrice.Text, System.Globalization.NumberStyles.Currency).ToString();

            // Insert the item
            OrderItemsListView.InsertNewItem(false);

            // Reset the edit order's Add data
            dropDown.SelectedIndex = 0;
            //ResetInsertItemValues(dropDown, 0, 0, 0);
        }
    }
    #endregion

    protected void OrderItemsListView_ItemInserting(object sender, ListViewInsertEventArgs e)
    {

    }
}