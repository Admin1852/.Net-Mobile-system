<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="company details.aspx.cs" Inherits="company_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
<table align="center" style="width: 812px; margin-left: 0px"><tr><td>
    <asp:GridView ID="gdcompany" runat="server" Width="340px" 
        AutoGenerateColumns="False" Height="224px" 
        style="color: #FFFFFF; font-weight: 700; text-align: center">
        <Columns>


        <asp:BoundField DataField="CompanyId" HeaderText="ApplicationID" />
        <asp:BoundField DataField="CompanyName" HeaderText="ApplicationName" />
       <asp:BoundField DataField="UserName" HeaderText="UserName" />
      <asp:BoundField DataField="Password" HeaderText="Password" />
       <asp:BoundField DataField="FounderName" HeaderText="FounderName" />
        <asp:BoundField DataField="Address" HeaderText="Address" />
        <asp:BoundField DataField="Field" HeaderText="Field" />
          <asp:BoundField DataField="Website" HeaderText="Website" />
        <asp:BoundField DataField="Contact" HeaderText="Contact" />
        <asp:BoundField DataField="Mail" HeaderText="Mail" />
        </Columns>
    </asp:GridView></td></tr></table>
</asp:Content>

