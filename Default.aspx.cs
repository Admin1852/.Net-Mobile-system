using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con.Open();
        if (TextBox1.Text.Length > 6)
        {
            if (TextBox2.Text != "")
            {
                if (TextBox3.Text != "")
                {
                    SqlCommand cmdLogin = new SqlCommand("select *  from userreg where UserId='" + TextBox1.Text + "' and Mail='" + TextBox2.Text + "'", con);
                    //SqlDataReader Dr = cmdLogin.ExecuteReader();
                    SqlCommand cmd = new SqlCommand("insert into userreview values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "', '" + TextBox3.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    Label2.Visible = true;
                    Label2.Text = "Thank you for your Review";
                }
                else
                {
                    Label2.Visible = true;
                    Label2.Text = "You are not allowed to add Review";
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "You are not allowed to add Review";
            }
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "You are not allowed to add Review";
        }
        con.Close();
        Response.Redirect("userreview.aspx");

    }

}