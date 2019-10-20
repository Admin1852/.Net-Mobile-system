<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 27px;
            color: #FFFFFF;
            font-weight: 700;
            width: 444px;
        }
        .style2
        {
            height: 32px;
        }
        .style3
        {
            height: 53px;
            width: 440px;
        }
        .style4
        {
            width: 271px;
        }
        .style5
        {
            height: 30px;
            color: #FFFFFF;
            width: 271px;
        }
        .style6
        {
            height: 53px;
            width: 271px;
        }
        .style7
        {
            color: #FF0000;
        }
        .style8
        {
            height: 32px;
            width: 440px;
        }
        .style9
        {
            height: 30px;
            color: #FFFFFF;
            font-weight: 700;
            width: 440px;
        }
        .style10
        {
            width: 271px;
            height: 32px;
        }
        .style11
        {
            width: 403px;
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />

    
        <br />
        <br />
        <br />

    
        <table align="center" class="style1" background="Photo/computer_0036.jpg" 
            style="border-style: dotted">
            <tr>
                <td class="style8">
                    &nbsp; &nbsp;<br />
&nbsp;&nbsp;&nbsp; <span 
                        class="style7">*</span><asp:Label ID="Label1" runat="server" Text="UserId"></asp:Label>&nbsp;</td>
                <td class="style10">
                    &nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox1" 
                        runat="server" Width="230px"></asp:TextBox>&nbsp;
                        <td class="style11">
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox1" ErrorMessage="Not Valid ID" InitialValue="UID" 
                                style="color: #FF0000; font-size: small"></asp:RequiredFieldValidator>
                        </td>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; Email Id</td>
                <td class="style5">
                    &nbsp;&nbsp; &nbsp;<asp:TextBox 
                        ID="TextBox2" runat="server" Width="230px"></asp:TextBox></td>
            </tr>
                        <tr>
                <td class="style9">
                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;<span 
                        class="style7">*</span>Product </td>
                <td class="style5">
                    &nbsp;&nbsp; &nbsp;<asp:TextBox 
                        ID="TextBox4" runat="server" Width="230px"></asp:TextBox></td>
                         <td class="style11">
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TextBox1" ErrorMessage="Field required" InitialValue="UID" 
                                style="color: #FF0000; font-size: small"></asp:RequiredFieldValidator>
                        </td>
            </tr>
                        <tr>
                <td class="style3">
                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; &nbsp;Review</td>
                <td class="style6">
                    &nbsp;&nbsp; &nbsp;<asp:TextBox 
                        ID="TextBox3" runat="server" 
                        TextMode="MultiLine" Height="53px" Width="230px"></asp:TextBox></td>
            </tr>

            <tr>
                <td class="style8">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td class="style4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnlogin" runat="server" 
                        style="font-weight: 700;" Text="Submit" 
                        onclick="btnlogin_Click" Height="26px" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnlogin0" runat="server" 
                        style="height: 26px; font-weight: 700;" Text="Back" 
                        onclick="btnlogin_Click" PostBackUrl="~/login.aspx" />
                    </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    &nbsp;&nbsp;<asp:Label 
                        ID="Label2" runat="server" style="color: #FF0000" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
