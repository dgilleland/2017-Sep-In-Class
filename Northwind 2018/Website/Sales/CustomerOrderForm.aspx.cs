using NorthwindTraders.BLL;
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

    }

    protected void CustomerOrderHistoryGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    #endregion
}