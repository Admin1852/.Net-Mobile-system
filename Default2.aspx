<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<table align="center" width="100%">
<tr><td align="center">
    <asp:GridView ID="gdview" runat="server" 
        
        BackImageUrl="~/images/stock-footage-purple-atmospheric-motion-graphics.jpg" 
        BackColor="#0000CC" style="color: #FFFFFF" AutoGenerateColumns="False"> 
           
   <Columns>
   <asp:BoundField DataField="Name" HeaderText="Name" />
   <asp:BoundField DataField="Address" HeaderText="Address" />
   <asp:BoundField DataField="Field" HeaderText="Field" />
   <asp:BoundField DataField="Contact" HeaderText="Contact No" />
   <asp:BoundField DataField="Mail" HeaderText="E-Mail Id" />   
   </Columns>
   
   
   </asp:GridView>
   
   </td> 
    </tr>


</table>
</asp:Content>

