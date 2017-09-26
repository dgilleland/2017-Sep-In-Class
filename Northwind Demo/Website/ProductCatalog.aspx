<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductCatalog.aspx.cs" Inherits="ProductCatalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Product Catalog</h1>

    <div class="row">
        <div class="col-md-12">
            <asp:Repeater ID="CategoryRepeater" runat="server"
                 ItemType="NorthwindData.App.DTOs.ProductCategory">
                <ItemTemplate>
                    <h4><%# Item.Name %></h4>
                    <blockquote>
                        <asp:Repeater ID="ProductRepeater" runat="server"
                             ItemType="NorthwindData.App.DTOs.ProductInfo"
                             DataSource="<%# Item.Products %>">
                            <ItemTemplate>
                                <h6><%# Item.Name %></h6>
                            </ItemTemplate>
                        </asp:Repeater>
                    </blockquote>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

