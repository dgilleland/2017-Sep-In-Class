using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_ListViewDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TaskListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch(e.CommandName)
        {
            case "Complete":
                MessageLabel.Text = $"I can change TaskId {e.CommandArgument} to 'Completed'";
                break;
            case "Select":
                MessageLabel.Text = "Here I can deal with a Select event.";
                // Because "Select" is one of the internally supported CommandNames
                // we might want to indicate that we have handled the command ourselves
                e.Handled = false;
                break;
        }
    }
}