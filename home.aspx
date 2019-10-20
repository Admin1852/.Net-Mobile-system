<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table><tr><td>
        <asp:Image ID="img" runat="server" 
        ImageUrl="~/system-architecture.mobile.jpg" height="490px" 
            Width="712px" BorderStyle="Dotted"/>

</td>

<td class="style3">
    <p>
        <b class="style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></p>
    <p class="MsoNormal">
        <span style="font-size: 14.0pt; line-height: 150%; font-family: &quot;Times New Roman&quot;,&quot;serif&quot;; color: #333333;">
        As more and more applications produce streaming data, clustering data streams 
        has become an important technique for data and knowledge engineering. </span>
    </p>
    <p class="MsoNormal">
        <span style="font-size: 14.0pt; line-height: 150%; font-family: &quot;Times New Roman&quot;,&quot;serif&quot;; color: #333333;">
        A typical approach is to summarize the data stream in real-time with an online 
        process into a large number of so called micro-clusters. </span>
    </p>
    <p class="MsoNormal">
        <span style="font-size: 14.0pt; line-height: 150%; font-family: &quot;Times New Roman&quot;,&quot;serif&quot;; color: #333333;">
        Micro-clusters represent local density estimates by aggregating the information 
        of many data points in a defined area. On demand, a (modified) conventional 
        clustering algorithm is used in a second offline step to recluster the 
        micro-clusters into larger final clusters. </span>
    </p>
    <p class="MsoNormal">
        <span style="font-size: 14.0pt; line-height: 150%; font-family: &quot;Times New Roman&quot;,&quot;serif&quot;; color: #333333;">
        For reclustering, the centers of the micro-clusters are used as pseudo points 
        with the density estimates used as their weights. <o:p></o:p></span>
    </p>
    <p>
        <br 
                class="style4" />
    </p>
    



</td></tr><tr><td>&nbsp;</td>

<td class="style1">
    &nbsp;</td></tr></table>


</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .style1
    {
        text-align: justify;
    }
    .style3
    {
        text-align: justify;
        font-weight: normal;
        font-family: "Times New Roman", Times, serif;
    }
    .style4
    {
        font-size: x-large;
        text-align: left;
    }
</style>
</asp:Content>


