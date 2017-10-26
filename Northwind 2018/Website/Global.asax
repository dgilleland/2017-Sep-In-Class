<%@ Application Language="C#" %>
<%@ Import Namespace="Website" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="NorthwindTraders.Security.BLL" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);

        // Setup default security roles
        var roleManager = new RoleManager();
        roleManager.AddStartupRoles();

        // Add a Webmaster account
        var userManager = new UserManager();
        userManager.AddWewbMaster();
    }

</script>
