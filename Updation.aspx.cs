using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;

public partial class Updation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        label.Visible = false;
    }
    protected void btsend_Click(object sender, EventArgs e)
    {
       
    }
    protected void imgbt_Click(object sender, ImageClickEventArgs e)
    {
        string id = "";
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from userreg where Field='" + Session["Field"].ToString() + "'", con);
        //SqlDataReader dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    id = dr[5].ToString();
        //}
        //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(" http://dnd.airsmsmarketing.info/api/sendmsg.php?user=india123&pass=123456&sender=OUTRAN&phone=" + id + "&text=" + txtupload.Text + "&priority=dnd&stype=normal");
        //HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        //System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
        //string responseString = respStreamReader.ReadToEnd();
        //respStreamReader.Close();
        //myResp.Close();
        //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://smstrans.adwise.org.in/sendsms.jsp?user=solarix&password=123456a&mobiles=" +id + "&sms=" + txtupload.Text + "&senderid=GRENAP");
        //HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        //StreamReader respStreamReader = new StreamReader(myResp.GetResponseStream());
        //string responseString = respStreamReader.ReadToEnd();
        //respStreamReader.Close();
        //myResp.Close();
        label.Visible = true;
        label.Text = "Your Details are Successfully Send to the User";
    }
}