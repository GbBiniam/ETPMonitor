<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpenedSessionPage.aspx.cs" Inherits="ETPMonitoringTool.Pages.OpenedSessionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headplaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="server">
    <table>
        <tr><td>Trade Date</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td>Trade Status</td>
            <td><asp:ListBox   ID="ListBox1"   runat="server">
               

                </asp:ListBox></td>
            <td><asp:Button runat="server" Text="Search" /></td> 
            </tr>
        <tr> <td colspan ="5">
    <asp:GridView ID="gvOpenedSession" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="TradeDate" HeaderText="Trade Date" SortExpression="TradeDate" />
            <asp:BoundField DataField="OnlineStartTime" HeaderText="Online StartTime" SortExpression="OnlineStartTime" />
            <asp:BoundField DataField="StatusName" HeaderText="Status" SortExpression="StatusName" />
        </Columns>
    </asp:GridView>
</td></tr>
    </table>
    </asp:Content>
