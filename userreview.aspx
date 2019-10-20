<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userreview.aspx.cs" Inherits="userreview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .head
        {
            z-index: 1;
            left: 110px;
            top: 15px;
            position: absolute;
            height: 54px;
            width: 808px;
        }
        .style1
        {
            z-index: 1;
            left: 110px;
            top: 15px;
            position: absolute;
            height: 54px;
            width: 808px;
            text-align: center;
            font-family: "Times New Roman", Times, serif;
            font-size: xx-large;
        }
        .bod
        {
            z-index: 1;
            left: 66px;
            top: 135px;
            position: absolute;
            height: 517px;
            width: 943px;
        }
    </style>
</head>
<body background="images/back.jpg">
    <form id="form1" runat="server">
    <div class="style1">
        <strong>ENTER REVIEW
    </strong>
    </div>

    <div class="bod">
        <asp:Label ID="Label1" runat="server" 
            style="z-index: 1; left: 322px; top: 43px; position: absolute; font-weight: 700;" 
            Text="Select Mobile"></asp:Label>
            <asp:Label ID="Label2" runat="server" 
            style="z-index: 1; left: 202px; top: 301px; position: absolute; bottom: 195px; font-weight: 700;" 
            Text="Weight"></asp:Label>


            <asp:Label ID="Label3" runat="server" 
            style="z-index: 1; left: 203px; top: 353px; position: absolute; font-weight: 700;" 
            Text="Design"></asp:Label>
            <asp:Label ID="Label4" runat="server" 
            style="z-index: 1; left: 202px; top: 191px; position: absolute; font-weight: 700;" 
            Text="Storage"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" 
            style="z-index: 1; left: 290px; top: 140px; position: absolute" 
            Text="Good Clarity" />
            <asp:CheckBox ID="CheckBox2" runat="server" 
            style="z-index: 1; left: 425px; top: 140px; position: absolute" 
            Text="Better" />
            <asp:CheckBox ID="CheckBox3" runat="server" 
            style="z-index: 1; left: 560px; top: 140px; position: absolute; right: 338px;" 
            Text="Bad" />


            <asp:CheckBox ID="CheckBox4" runat="server" 
            style="z-index: 1; left: 290px; top: 190px; position: absolute" 
            Text="Large" />
            <asp:CheckBox ID="CheckBox5" runat="server" 
            style="z-index: 1; left: 425px; top: 190px; position: absolute" 
            Text="Moderate" />
            <asp:CheckBox ID="CheckBox6" runat="server" 
            style="z-index: 1; left: 560px; top: 190px; position: absolute" 
            Text="Low " />



            <asp:Label ID="Label5" runat="server" 
            style="z-index: 1; left: 202px; top: 246px; position: absolute; font-weight: 700;" 
            Text="Battery Life"></asp:Label>
            <asp:Label ID="Label6" runat="server" 
            
            
            style="z-index: 1; left: 744px; top: 44px; position: absolute; font-weight: 700;" 
            Visible="False"></asp:Label>
            <asp:Label ID="Label7" runat="server" 
            style="z-index: 1; left: 202px; top: 145px; position: absolute; font-weight: 700;" 
            Text="Camera"></asp:Label>
            <asp:Label ID="Label8" runat="server" 
            style="z-index: 1; left: 202px; top: 407px; position: absolute; font-weight: 700;" 
            Text="Screen"></asp:Label>


        <asp:DropDownList ID="DropDownList1" runat="server" 
            style="z-index: 1; left: 440px; top: 40px; position: absolute; height: 42px; width: 183px">
            <asp:ListItem>--select--</asp:ListItem>
            <asp:ListItem>micromax</asp:ListItem>
            <asp:ListItem>samsung</asp:ListItem>
            <asp:ListItem>intex</asp:ListItem>
            <asp:ListItem>lava</asp:ListItem>
            <asp:ListItem>lenovo</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>


        <asp:CheckBox ID="CheckBox7" runat="server" 
            
            style="z-index: 1; left: 291px; top: 240px; position: absolute; right: 563px;" 
            Text="Long" />
            <asp:CheckBox ID="CheckBox8" runat="server" 
            style="z-index: 1; left: 425px; top: 240px; position: absolute" 
            Text="Not Much" />
            <asp:CheckBox ID="CheckBox9" runat="server" 
            style="z-index: 1; left: 562px; top: 240px; position: absolute" 
            Text="Low" />
 <asp:CheckBox ID="CheckBox10" runat="server" 
            style="z-index: 1; left: 289px; top: 297px; position: absolute" 
            Text="Heavy" />
             <asp:CheckBox ID="CheckBox11" runat="server" 
            style="z-index: 1; left: 426px; top: 294px; position: absolute" 
            Text="Normal" />
             <asp:CheckBox ID="CheckBox12" runat="server" 
            style="z-index: 1; left: 563px; top: 289px; position: absolute" 
            Text="Light" />
            <asp:CheckBox ID="CheckBox13" runat="server" 
            style="z-index: 1; left: 288px; top: 349px; position: absolute" 
            Text="Good" />
            <asp:CheckBox ID="CheckBox14" runat="server" 
            style="z-index: 1; left: 426px; top: 346px; position: absolute" 
            Text="Moderate" />
            <asp:CheckBox ID="CheckBox15" runat="server" 
            style="z-index: 1; left: 563px; top: 346px; position: absolute" 
            Text="Bad" />
            <asp:CheckBox ID="CheckBox16" runat="server" 
            style="z-index: 1; left: 289px; top: 405px; position: absolute" 
            Text="Large" />
            <asp:CheckBox ID="CheckBox17" runat="server" 
            style="z-index: 1; left: 426px; top: 403px; position: absolute" 
            Text="Medium" />
            <asp:CheckBox ID="CheckBox18" runat="server" 
            style="z-index: 1; left: 563px; top: 395px; position: absolute" 
            Text="Small" />

        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="z-index: 1; left: 430px; top: 467px; position: absolute; font-weight: 700" 
            Text="Submit" />
        <asp:TextBox ID="TextBox1" runat="server" 
            style="z-index: 1; left: 680px; top: 139px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" 
            style="z-index: 1; left: 680px; top: 191px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" 
            style="z-index: 1; left: 680px; top: 239px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" 
            style="z-index: 1; left: 680px; top: 289px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" 
            style="z-index: 1; left: 680px; top: 339px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" 
            style="z-index: 1; left: 680px; top: 389px; position: absolute"></asp:TextBox>

            <asp:Label ID="Label9" runat="server" 
            style="z-index: 1; left: 49px; top: 117px; position: absolute; font-weight: 700;" 
            Text="Submit Reviews"></asp:Label>
            <asp:Label ID="Label10" runat="server" 
            
            
            style="z-index: 1; left: 655px; top: 44px; position: absolute; font-weight: 700;" 
            Visible="False"></asp:Label>
            <asp:Label ID="Label11" runat="server" 
            
            
            style="z-index: 1; left: 818px; top: 47px; position: absolute; font-weight: 700;" 
            Visible="False"></asp:Label>




    </div>
    </form>
</body>
</html>
