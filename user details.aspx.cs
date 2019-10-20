using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from userreg", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gduser.DataSource = ds;
        gduser.DataBind();
        con.Close();
    }
}