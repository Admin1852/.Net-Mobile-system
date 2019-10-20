using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Name, Address, Field, Contact, Mail from userreg where Field='" + Session["Field"].ToString() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gdview.DataSource = ds;  
            gdview.DataBind();
            con.Close();
        
    }
    
    
}