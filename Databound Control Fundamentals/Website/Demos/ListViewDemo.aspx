<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListViewDemo.aspx.cs" Inherits="Demos_ListViewDemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">ListView Demo</h1>

    <div class="row">
        <div class="col-md-6">
            <asp:ListView ID="TaskListView" runat="server"
                 DataSourceID="TodoDataSource"
                 ItemType="DemoData.Task" DataKeyNames="TaskId"
                 OnItemCommand="TaskListView_ItemCommand">
                <LayoutTemplate><div runat="server" id="itemPlaceholder"></div></LayoutTemplate>
                <ItemTemplate>
                    <div class="panel panel-default">
                        <div class="panel-heading"><%# Item.Name %></div>
                        <div class="panel-body">
                            Due on <asp:TextBox ID="TaskDueDate" runat="server" Text="<%# Item.DueDate %>"></asp:TextBox>
                            
                        </div>
                        <div class="panel-footer">
                            <asp:LinkButton ID="Button1" runat="server"
                                 CommandName="Complete" CommandArgument="<%# Item.TaskId %>"
                                 CssClass="btn btn-default">Completed</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton1" runat="server"
                                 CommandName="Select" CommandArgument="<%# Item.TaskId %>"
                                 CssClass="btn btn-default">Select</asp:LinkButton>
                        </div>
                    </div>
                </ItemTemplate>
                <SelectedItemTemplate>
                    <div class="panel panel-success">
                        <div class="panel-heading"><%# Item.Name %></div>
                        <div class="panel-body">
                            Due on <asp:TextBox ID="TaskDueDate" runat="server" Text="<%# Item.DueDate %>"></asp:TextBox>
                            
                        </div>
                        <div class="panel-footer">
                            <asp:LinkButton ID="Button1" runat="server"
                                 CommandName="Complete" CommandArgument="<%# Item.TaskId %>"
                                 CssClass="btn btn-default">Completed</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton1" runat="server"
                                 CommandName="Select" CommandArgument="<%# Item.TaskId %>"
                                 CssClass="btn btn-default">Select</asp:LinkButton>
                        </div>
                    </div>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:ObjectDataSource runat="server" ID="TodoDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListTasks" TypeName="DemoData.TaskManager"></asp:ObjectDataSource>
        </div>
        <div class="col-md-6">
            <h2>Output</h2>
            <asp:Label ID="MessageLabel" runat="server" />
        </div>
    </div>
</asp:Content>

