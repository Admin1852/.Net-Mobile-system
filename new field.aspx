<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="new field.aspx.cs" Inherits="new_field" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
<table align="center" style="width: 330px; height: 83px"><tr><td align="center" 
        class="style1"><strong>Add_NewField</strong></td><td><asp:TextBox ID="txtnew" 
            runat="server" Width="161px"></asp:TextBox></td></tr>
            <tr><td colspan="2" align="center"><asp:Button ID="btnew" runat="server" 
                    Text="Save" Height="43px" onclick="btnew_Click" Width="76px" /></td></tr>
            </table>
</asp:Content>

