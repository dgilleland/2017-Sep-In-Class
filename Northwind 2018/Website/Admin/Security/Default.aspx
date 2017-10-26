<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Security_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row jumbotron">
        <h1>Site Administration</h1>
    </div>
    <div class="row">
        <div class="col-md-12">
            <!-- Nav tabs via Bootstrap -->
            <ul class="nav nav-tabs">
                <li class="active"><a href="#users" data-toggle="tab">Users</a></li>
                <li><a href="#roles" data-toggle="tab">Security Roles</a></li>
                <li><a href="#unregistered" data-toggle="tab">Unassigned Users</a></li>
            </ul>
            <div class="tab-content">
                <div id="users" class="tab-pane fade in active">
                    <blockquote>Registered Users in the Site</blockquote>
                    <asp:ListView ID="UsersListView" runat="server"
                         DataSourceID="UsersDataSource"
                         ItemType="NorthwindTraders.Security.Entities.UserProfile">
                        <LayoutTemplate>
                            <div class="row bg-info">
                                <div class="col-sm-3 h4">Action</div>
                                <div class="col-sm-3 h4">User</div>
                                <div class="col-sm-6 h4">Profile Info</div>
                            </div>
                            <div runat="server" id="itemPlaceholder"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-sm-3">TODO</div>
                                <div class="col-sm-3">
                                    <%# Item.UserName %>
                                </div>
                                <div class="col-sm-6">
                                    Email: <%# Item.Email %>
                                    <asp:CheckBox ID="IsConfirmed" runat="server"
                                         Enabled="false" Checked="<%# Item.EmailConfirmed %>"
                                         Text="Confirmed" />
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                    <asp:ObjectDataSource runat="server" ID="UsersDataSource"
                         OldValuesParameterFormatString="original_{0}"
                         TypeName="Website.UserManager"
                         SelectMethod="ListAllUsers"></asp:ObjectDataSource>
                </div>

                <div id="roles" class="tab-pane fade in">
                    <blockquote>Security Roles for the Site</blockquote>
                </div>

                <div id="unregistered" class="tab-pane fade in">
                    <blockquote>Users who are not assigned to security roles</blockquote>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

