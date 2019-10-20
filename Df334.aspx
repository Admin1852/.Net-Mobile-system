<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chart8.aspx.cs" Inherits="chart" %>
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
    <div><AChart:Chart ID="ChartID" runat="server" Width="345px"  >

 <series>

 <AChart:Series Name="Series1" ChartType="Pie">

 </AChart:Series>

 </series>

 <chartareas>

 <AChart:ChartArea Name="ChartArea1">

 </AChart:ChartArea>

 </chartareas>

 </AChart:Chart>
    
    </div>
    </form>
</body>
</html>
