<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InventoryStatusReport2.aspx.cs" Inherits="Reporting_InventoryStatusReport2" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="page-content">Inventory Status</h1>

    <div class="row">
        <div class="col-md-12">
            <%--Place my ReportViewer control--%>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
                <LocalReport ReportPath="Reporting\InventoryStatusReport2.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource Name="InventoryStatusDataSet" DataSourceId="InventoryDataSource"></rsweb:ReportDataSource>
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="InventoryDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetInventoryStatus" TypeName="NorthwindTraders.BLL.ProductCatalogueController"></asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>

