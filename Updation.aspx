<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Updation.aspx.cs" Inherits="Updation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center"><tr><td align="center">
<asp:Label ID="txt" runat="server" Text="Update New Application Details" 
        style="font-weight: 700; font-size: x-large; font-family: 'Times New Roman', Times, serif"></asp:Label>
    
</td>
<td><asp:TextBox ID="txtupload" runat="server" TextMode="MultiLine" Height="118px" 
        Width="361px"></asp:TextBox></td>
</tr>
<tr>
<td align="center" colspan="2" style="font-size:larger;">
<asp:ImageButton ID="imgbt" runat="server" ImageUrl="~/CLICK_HERE-ANIMATED.gif" 
        onclick="imgbt_Click" />
    <br />
    <br />
    <br />
<asp:Label ID="label" runat="server" Text="Info"></asp:Label></td>
</tr>

</table>
</asp:Content>

