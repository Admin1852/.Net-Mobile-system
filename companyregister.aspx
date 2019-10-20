<%@ Page Language="C#" AutoEventWireup="true" CodeFile="companyregister.aspx.cs" Inherits="companyregister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .table_text_11px
        {}
        .style5
        {
            font-size: large;
            color: #66FFFF;
        }
        
        
       
        
        .style12
        {
            color: #00FFCC;
        }
        .style13
        {
            color: #33CCCC;
            font-size: xx-large;
        }
        
        .style18
        {
            color: #0000FF;
            font-size: xx-large;
        }
        .style19
        {
            color: #0000FF;
        }
        .style20
        {
            font-size: large;
            color: #0000FF;
        }
        .style1
        {
            font-size: x-large;
        }
    </style>
</head>
<body background="powerpoint-presentation-design.jpg">
    <form id="form1" runat="server">
    <div id="pan1">
    <br /><br />
	
            <table width="100%" align="center"><tr><td align="center" 
                    style="font-weight: 700; color: #000066">
                <span class="style1" 
                    style="font-family: &quot;Times New Roman&quot;; mso-ascii-font-family: &quot;Times New Roman&quot;; mso-fareast-font-family: +mj-ea; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-color-index: 1; mso-font-kerning: 12.0pt; language: en-US; font-weight: bold">
                <br />
                Mobile Rating System</span><br />
            </td></tr></table>
            

            
        
           
          
           
            
               <fieldset>
           <table border="0" cellspacing="0" cellpadding="5px" align="center" style="height: 388px;">
                     
                         <tr>
                            <td colspan="4" align="center"><div class="style12"><strong>
                                <span class="style13">
                                <br />
                                </span><span class="style18">Registration Form</span>
                                <br />
                                 </strong>  </div></td>
                              
                              
                            </tr>
                             <tr>
                            <td class="style8"><div align="right" class="style5"><strong>
                                <span class="style19">
                                ApplicationID</span> </strong>  </div></td>
                              
                              <td class="style10"><div align="left" class="body_text_black">
                                  <asp:Label ID="Label12" runat="server" Text="" style="font-weight: 700"></asp:Label>
                                
                             
                                  <br />
                                
                             
                              </div></td>
                            
                            <td class="style8"><div align="left" class="style5"><strong><span class="style19">
                                ApplicationName</span> </strong>  </div></td>
                              <td class="style10"><div align="left" class="body_text_black">
                              <asp:TextBox ID="txtcname" runat="server" class="table_text_11px" Width="246px" Height="30px"></asp:TextBox>
                                
                             
                                  <br />
                                
                             
                              </div></td>
                            </tr>
                             <tr>
                            <td class="style8"><div align="right" class="style5"><strong><span class="style19">
                                UserName</span> </strong>  </div></td>
                              <td class="style10"><div align="left" class="body_text_black">
                              <asp:TextBox ID="txtUser" runat="server" class="table_text_11px" Width="246px" Height="30px"></asp:TextBox>
                                
                             
                                  <br />
                                
                             
                              </div></td>
                           
                            <td class="style7"><div align="right"><span class="style20"><strong>Password</strong></span>  </div></td>
                              <td class="style17"><div align="left" class="body_text_black">
                              <asp:TextBox ID="txtpass" runat="server" class="table_text_11px"
                                      TextMode="Password" Height="30px" Width="246px" ></asp:TextBox>
                                
                             
                                  <br />
                                
                             
                              </div></td>
                            </tr>
                          
                          <tr>
                            <td class="style7"><div align="right">&nbsp;<span class="style20"><strong>FounderName</strong></span>  </div></td>
                            <td class="style17"><div align="left">
                           
                              <asp:TextBox ID="txtfounder" runat="server"  class="table_text_11px" Width="246px" Height="30px" ></asp:TextBox>
                            </div></td>
                         
                            <td class="style8"><div align="right"><span class="style20"><strong>Address</strong></span>  </div></td>
                            <td class="style10"><div align="left">
                           
                              <asp:TextBox ID="txtaddress" runat="server"  class="table_text_11px" 
                                    TextMode="MultiLine" size="30" Width="246px" ></asp:TextBox>
                            </div></td>
                          </tr>
                          <tr>
                            <td class="style8"><div align="right"><span class="style20"><strong>Product</strong></span> </div></td>
                            <td class="style10"><div align="left">

                              <asp:DropDownList ID="ddlfield" runat="server" AutoPostBack="true" Height="30px" 
                                    Width="246px">
                               <asp:ListItem>Select</asp:ListItem>
                                      <asp:ListItem>Watch</asp:ListItem>
                                      <asp:ListItem>Grocerry</asp:ListItem>
                                      <asp:ListItem>Books</asp:ListItem>
                                      <asp:ListItem>Stationary</asp:ListItem>
                                      <asp:ListItem>Camera</asp:ListItem>
                                      <asp:ListItem>Clothes</asp:ListItem>
                                      <asp:ListItem>Mobile</asp:ListItem>
                                      <asp:ListItem>Home Appliances</asp:ListItem>
                                      <asp:ListItem>Office needs</asp:ListItem>
                                      <asp:ListItem>Mechinary goods</asp:ListItem>
                              </asp:DropDownList>
                             
                            </div></td>
                         
                          <%-- <tr>
                            <td><div align="right" class="body_text_black">Do you Sent Email to Customer </div></td>
                            <td><div align="center" class="body_text_black">:</div></td>
                            <td><div align="left">
                              <table width="60%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                  <td width="10%"><input name="semail" type="checkbox" id="semail" value="1" checked="checked" /></td>
                                  <td width="90%">&nbsp;</td>
                                </tr>--%>
                           
                            <td class="style7"><div align="right"><span class="style20"><strong>Website</strong></span> </div></td>
                            <td class="style17"><div align="left">
                            <asp:TextBox ID="txtwebsite" runat="server" CssClass="table_text_11px" Width="246px" Height="30px"></asp:TextBox>
                              
                            </div></td>
                          </tr>
                          <tr>
                            <td class="style7"><div align="right"><span class="style20"><strong>Contact</strong></span>  </div></td>
                             <td class="style17">
                              <div align="left">
                              <asp:TextBox ID="txtcontact" runat="server" class="table_text_11px" Width="246px" Height="30px"></asp:TextBox>
                              
                                </div></td>
                         
                            <td class="style7"><div align="right"><span class="style20"><strong>Mail</strong></span> </div></td>
                            <td class="style17"><div align="left">
                            <asp:TextBox ID="txtmail" runat="server" class="table_text_11px" Width="246px" Height="30px"></asp:TextBox>
                   
                            </div></td>  </tr>                  
    
    
              <tr>
                    <td align="center" colspan="2"> <asp:Button ID="btsave" runat="server" BackColor="#00C4C4" 
                        onclick="btnsave_Click" Text="Save Details" Height="30px" Width="150px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                      <td colspan="2" align="center" class="style17"><asp:Button ID="btnreset" 
                              runat="server" BackColor="#00C4C4" 
                        onclick="btnreset_Click" Text="Back" Height="30px" Width="150px" /></td>
                   </tr>
                   
                                  
         
</table>
               </fieldset>
                   
                    
 
</div>
    </form>
</body>
</html>
