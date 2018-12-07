<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApplicationLauncherPage.aspx.cs" Inherits="ETPMonitoringTool.Pages.ClosedSessionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headplaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="server">
  <div style="padding:10px">
     <table style="align-self:center">
            <tr><td colspan="2"><h2>Elecronic Trade Applicationa Launcher</h2></td></tr>
            <tr><td>Order Receiver</td><td><asp:Button ID="btnOreceiver" runat="server" Text="Start" OnClick="btnOreceiver_Click" />
                <asp:Button ID="btnOrceiverstop" runat="server" Text="Stop" OnClick="btnOreceiverstop_Click" />
                                       </td></tr>
            <tr><td>Trade Executor</td><td><asp:Button ID="btnTexecutor" runat="server" Text="Launch" OnClick="btnTexecutor_Click" /></td></tr>
            <tr><td>Tunnel Manager</td><td><asp:Button ID="btnTmanager" runat="server" Text="Launch" /></td></tr>
            <tr><td>Session Manager</td><td><asp:Button ID="btnSmanager" runat="server" Text="Launch" /></td></tr>
            <tr><td>Launch All</td><td><asp:Button ID="btnLall" runat="server" Text="Launch All" /></td></tr>

        </table>

  </div>
</asp:Content>
