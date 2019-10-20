<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chart3.aspx.cs" Inherits="chart3" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral,

PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting"

tagprefix="AChart" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <AChart:Chart ID="ChartID" runat="server" Width="345px"  >

 <series>

 <AChart:Series Name="Series1" ChartType="Pie">

 </AChart:Series>

 </series>

 <chartareas>

 <AChart:ChartArea Name="ChartArea1">

 </AChart:ChartArea>

 </chartareas>

 </AChart:Chart>
    &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            style="font-weight: 700">View Source</asp:LinkButton>
    &nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton1_Click" 
            style="font-weight: 700" PostBackUrl="~/cluster.aspx">Back</asp:LinkButton>
        <br />
        <br />
    <asp:GridView ID="gduser" runat="server" 
        Width="620px" AutoGenerateColumns="False" Height="105px" 
        style="font-weight: 700; color: #000066; text-align: center">
        <Columns>


        <asp:BoundField DataField="UserId" HeaderText="UserId" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
       <asp:BoundField DataField="FatherName" HeaderText="FatherName" />
      <asp:BoundField DataField="Address" HeaderText="Address" />
        <asp:BoundField DataField="Contact" HeaderText="Contact" />
        <asp:BoundField DataField="Mail" HeaderText="Mail" />
          
        
        
        </Columns>
    </asp:GridView>
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
