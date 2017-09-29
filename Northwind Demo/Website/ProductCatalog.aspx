<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductCatalog.aspx.cs" Inherits="ProductCatalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Product Catalog</h1>

    <div class="row">
        <div class="col-md-12">
            <asp:Repeater ID="CategoryRepeater" runat="server"
                 ItemType="NorthwindData.App.DTOs.ProductCategory">
                <ItemTemplate>
                    <img src="data:image/png,<%# Convert.ToBase64String(Item.Picture) %>" />
                    <h4><%# Item.Name %></h4>
                    <blockquote>
                        <asp:Repeater ID="ProductRepeater" runat="server"
                             ItemType="NorthwindData.App.DTOs.ProductInfo"
                             DataSource="<%# Item.Products %>">
                            <ItemTemplate>
                                
                                <p><b><%# Item.Name %></b>
                                    <!-- Format the price using string interpolation -->
                                   <%# $"{Item.Price:C}" %> <%# Item.QuantityPerUnit %>
                                   &mdash; <%# Item.InStock %> In stock </p>
                            </ItemTemplate>
                        </asp:Repeater>
                    </blockquote>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

