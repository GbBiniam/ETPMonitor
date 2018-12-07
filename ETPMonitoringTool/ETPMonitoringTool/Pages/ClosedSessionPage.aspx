<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClosedSessionPage.aspx.cs" Inherits="ETPMonitoringTool.Pages.ClosedSessionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headplaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="server">
    <asp:GridView ID="gvOpenedSession" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="TradeDate" HeaderText="Trade Date" SortExpression="TradeDate" />
            <asp:BoundField DataField="OnlineStartTime" HeaderText="Online StartTime" SortExpression="OnlineStartTime" />
            <asp:BoundField DataField="StatusName" HeaderText="Status" SortExpression="StatusName" />
        </Columns>
    </asp:GridView>
</asp:Content>
