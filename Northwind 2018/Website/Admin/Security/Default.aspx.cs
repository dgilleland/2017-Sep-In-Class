using NorthwindTraders.Security.BLL;
using NorthwindTraders.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Website;

public partial class Admin_Security_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected List<string> GetRoleNames()
    {
        var mgr = new RoleManager();
        return mgr.Roles.Select(r => r.Name).ToList();
    }

    protected void UserListView_ItemInserting(object sender, ListViewInsertEventArgs e)
    {
        var addToRoles = new List<string>();
        var roles = e.Item.FindControl("RoleMemberships") as CheckBoxList;
        if (roles != null)
            foreach (ListItem item in roles.Items)
                if (item.Selected)
                    addToRoles.Add(item.Value);
        e.Values["RoleMemberships"] = addToRoles;
    }

    protected void UnregisteredUsersGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        MessageUserControl.TryRun(() =>
        {
            UnregisteredUsersGridView.SelectedIndex = e.NewSelectedIndex;
            GridViewRow row = UnregisteredUsersGridView.SelectedRow;
            if (row != null)
            {
                string userName = null, email = null;
                UnregisteredUserType userType;
                TextBox input;
                input = row.FindControl("GivenUserName") as TextBox;
                if (input != null)
                    userName = input.Text;
                input = row.FindControl("GivenEmail") as TextBox;
                if (input != null)
                    email = input.Text;
                userType = (UnregisteredUserType)Enum.Parse(typeof(UnregisteredUserType), row.Cells[1].Text);

                UnregisteredUser user = new UnregisteredUser()
                {
                    Id = UnregisteredUsersGridView.SelectedDataKey.Value.ToString(),
                    UserType = userType,
                    Name = row.Cells[2].Text,
                    OtherName = row.Cells[3].Text,
                    AssignedUserName = userName,
                    AssignedEmail = email
                };

                UserManager manager = new UserManager();
                manager.RegisterUser(user);
                DataBind();
            }
        });
    }

    protected void RefreshAll(object sender, EventArgs e)
    {
        DataBind();
    }

    protected void CheckForException(object sender, ObjectDataSourceStatusEventArgs e)
    {
        MessageUserControl.HandleDataBoundException(e);
    }
}