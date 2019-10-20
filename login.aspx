<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        #tabel1
        {
            width: 933px;
            height: 525px;
        }
        .table_text_11px
        {}
        .style6
        {
            font-size: x-large;
        }
        .style12
        {
            font-family: "Times New Roman";
            font-size: xx-large;
            color: #000066;
            text-align: center;
            height: 31px;
        }
        .style14
        {
            height: 27px;
            width: 569px;
        }
        .style19
        {
            height: 18px;
        }
        .style20
        {
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
            width: 569px;
            height: 27px;
        }
        .style21
        {
            width: 650px;
            height: 27px;
        }
        .style22
        {
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
            width: 569px;
            height: 19px;
        }
        .style23
        {
            width: 650px;
            height: 19px;
        }
        </style>
</head>
<body background="Photo/thumb-1920-96622.jpg">
    <form id="form1" runat="server">      
    <br />
       
            <br />
    <br />
    <br />
    <br />
    <br />
    <br />
       
            <table align="center" cellpadding="0" cellspacing="20" 
                
                
        style="color: #FFFFFF; font-weight: 700; height: 376px; width: 39%; margin-left: 385px;" >
            <tr><td colspan="2" class="style12"><strong>Login </strong></td></tr>
                <tr>
                    <td align="right" class="style20">
                        UserName</td>
                    <td class="style21">
                        <asp:TextBox ID="txtUser" runat="server" Height="28px" Width="167px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style22">
                        Password</td>
                    <td class="style23">
                        <asp:TextBox ID="txtpass" 
             runat="server" TextMode="Password" Height="28px" Width="167px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                <td class="style14"> </td>
                    <td class="style21">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="42px" 
                            ImageUrl="~/animated-welcome-image-0233.gif" onclick="ImageButton1_Click" 
                            style="margin-left: 10px; margin-bottom: 16px" Width="145px" />
                    </td><asp:Label ID="lab1" runat="server" Text="info"></asp:Label>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <strong><span class="style6">Are You New Application Holder&nbsp;
                        <img src="Photo/Blink.gif" style="height: 15px; width: 32px" />&nbsp; </span></strong><asp:LinkButton 
                            ID="lbowner" runat="server" Text="Click Here" 
                            PostBackUrl="~/companyregister.aspx" style="color: #000066"></asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" class="style19">
                        <strong><span class="style6">Are You New User 
                        <img src="Photo/Blink.gif" style="height: 14px; width: 32px" />&nbsp; </span></strong><asp:LinkButton 
                            ID="lbnew" runat="server" Text="Click Here" PostBackUrl="~/userreg.aspx" 
                            style="color: #000066" ></asp:LinkButton>
                    </td>
                </tr>  </table>

    </form>
</body>
</html>
