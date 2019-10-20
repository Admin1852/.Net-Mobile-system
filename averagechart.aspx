<%@ Page Language="C#" AutoEventWireup="true" CodeFile="averagechart.aspx.cs" Inherits="averagechart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .ds
        {
            z-index: 1;
            left: 128px;
            top: 64px;
            position: absolute;
            width: 892px;
            height: 649px;
        }
    </style>
</head>
<body  background="images/backk2.jpg">
    <form id="form1" runat="server">
    <div class="ds">
        <asp:Label ID="Label1" runat="server" Text="View Average Result" 
            
            style="z-index: 1; left: 270px; top: 70px; position: absolute; font-weight: 700"></asp:Label>


            <asp:Label ID="Label2" runat="server" Text="View Average Result" 
            style="z-index: 1; left: 390px; top: 30px; position: absolute; font-weight: 700"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            
            style="z-index: 1; left: 446px; top: 70px; position: absolute; width: 145px; right: 301px;" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--Select---</asp:ListItem>
            <asp:ListItem>micromax</asp:ListItem>
            <asp:ListItem>lenovo</asp:ListItem>
            <asp:ListItem>lava</asp:ListItem>
            <asp:ListItem>intex</asp:ListItem>
            <asp:ListItem>samsung</asp:ListItem>
        </asp:DropDownList>
        <asp:Chart ID="Chart1" runat="server" 
            style="z-index: 1; left: 320px; top: 200px; position: absolute">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                <Area3DStyle Enable3D="true" LightStyle="Realistic" />  
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="z-index: 1; left: 630px; top: 64px; position: absolute; font-weight: 700" 
            Text="View" />
    </div>
    </form>
</body>
</html>
