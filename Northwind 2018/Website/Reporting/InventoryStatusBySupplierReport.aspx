<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InventoryStatusBySupplierReport.aspx.cs" Inherits="Reporting_InventoryStatusBySupplierReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-header">Inventory Status Report By Supplier</h1>
    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="FilterLabel" runat="server" AssociatedControlID="SupplierDropDownList" Text="Filter by: " />
            <asp:DropDownList ID="SupplierDropDownList" runat="server"
                AppendDataBoundItems="true" DataSourceID="SuppliersDataSource" DataTextField="Text" DataValueField="Key">
                <asp:ListItem Value="0">[All Suppliers]</asp:ListItem>
            </asp:DropDownList>
            Select a supplier and click the refresh icon (<asp:Image ID="Refresh" runat="server" ImageUrl="~/Images/refresh.png" />) in the report below.
            <asp:ObjectDataSource runat="server" ID="SuppliersDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListSuppliers" TypeName="NorthwindTraders.BLL.ProductCatalogueController"></asp:ObjectDataSource>

            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
                <LocalReport ReportPath="Reporting\InventoryStatusBySupplierReport.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource Name="DataSet1" DataSourceId="ReportDataSource"></rsweb:ReportDataSource>
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ReportDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetInventoryStatusBySupplier" TypeName="NorthwindTraders.BLL.ProductCatalogueController">
                <SelectParameters>
                    <asp:ControlParameter ControlID="SupplierDropDownList" PropertyName="SelectedValue" Name="supplierId" Type="Int32"></asp:ControlParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>

