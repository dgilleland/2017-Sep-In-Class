using NorthwindTraders.Security.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

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
}