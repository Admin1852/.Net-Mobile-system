using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=localhost:3306");
    protected void Page_Load(object sender, EventArgs e)
    {
        lab1.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (txtUser.Text == "admin" && txtpass.Text == "admin")
        {
            Response.Redirect("adminhome.aspx");
        }
        else if (txtUser.Text != null && txtpass.Text != null)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from comreg where UserName='" + txtUser.Text + "'", con);
            SqlDataReader Dr = cmd.ExecuteReader();
            if (!Dr.Read())
            {
                lab1.Visible = true;
                lab1.Text = "Invalid User";
            }
            else
            {
                if (Dr[3].ToString() == txtpass.Text)
                {
                    Session["Field"] = Dr[6].ToString();
                    Response.Redirect("home.aspx");
                }
                else
                {
                    lab1.Visible = true;
                    lab1.Text = "Invalid User";

                }
                con.Close();

            }
        }
    }
}