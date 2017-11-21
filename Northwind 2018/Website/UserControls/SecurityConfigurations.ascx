<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SecurityConfigurations.ascx.cs" Inherits="UserControls_SecurityConfigurations" %>
<h3>Admin Login</h3>
<asp:Label ID="AdminUserName" runat="server" CssClass="label label-info" />
<asp:Label ID="AdminPassword" runat="server" CssClass="label label-success" />
<asp:LinkButton ID="FillInForm" runat="server" CssClass="btn btn-primary" OnClick="FillInForm_Click" Text="Use Admin Credentials" CausesValidation="false" />
<h3>Default Passwords</h3>
<asp:Label ID="DefaultPassword" runat="server" CssClass="label label-success" />

