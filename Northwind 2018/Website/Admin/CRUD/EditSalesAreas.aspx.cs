using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CRUD_EditSalesAreas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckForException(object sender, ObjectDataSourceStatusEventArgs e)
    {
        // Here is where I can inspect the event to see if an exception has occurred
        if (e.Exception is DbEntityValidationException)
        {
            var ex = e.Exception as DbEntityValidationException;
            // Get a list of all the error messages for this
            var details = from DbValidationError error
                            in ex.EntityValidationErrors.First().ValidationErrors
                          select error.ErrorMessage;
            MessageLabel.Text = "The following validation errors occurred:"
                              + "<blockquote><ul>";
            foreach (string problem in details)
                MessageLabel.Text += $"<li>{problem}</li>";
            MessageLabel.Text += "</ul></blockquote>";

            // Tell the ObjectDataSource control that I've just dealt with the error
            e.ExceptionHandled = true;
        }
        else if (e.Exception is Exception)
        {
            MessageLabel.Text = "Something else wonky happened: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
            MessageLabel.Text = "";
    }
}