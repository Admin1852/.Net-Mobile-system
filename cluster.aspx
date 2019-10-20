<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cluster.aspx.cs" Inherits="cluster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            font-size: x-large;
            color: #66FFFF;
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
    <br />
    <br />
<table align="center" style="width: 386px; height: 104px"><tr>
    <td align="center" 
        class="style2"><strong>Select Micro Cluster</strong></td><td>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="23px" 
            Width="86px" style="font-weight: 700; text-align: center">
             <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
              <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
<%--                   <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
              <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>--%>
          
        </asp:DropDownList>
        </td></tr>
            <tr><td colspan="2" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnew" runat="server" 
                    Text="Search" Height="43px" onclick="btnew_Click" Width="76px" 
                    style="font-weight: 700" /></td></tr>
            </table>

</asp:Content>

