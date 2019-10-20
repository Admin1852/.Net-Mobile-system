using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class userreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBind();
            txtincr();
        }
    }
    protected void DataBind()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from new", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddlfield.DataSource = ds;
        ddlfield.DataTextField = "Add_NewField";
        ddlfield.DataValueField = "id";
        ddlfield.DataBind();
        con.Close();
    }

    private void txtincr()
    {
        int a;

        if (Label12.Text == "")
        {

            if (con.State == 0)
            {
                con.Open();
            }
            string sqlstr = "select * from userreg";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, con);
            DataSet dst = new DataSet();
            sda.Fill(dst);


            if (dst.Tables[0].Rows.Count != 0)
            {
                a = dst.Tables[0].Rows.Count;
                a = a + 1;
                Label12.Text = "UID1234500" + Convert.ToString(a);
                txtname.Focus();
            }
            else
            {
                Label12.Text = "UID1234500";
                txtname.Focus();
            }
            con.Close();
        }
    }

    protected void button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into userreg values('" + Label12.Text + "','" + txtname.Text + "', '" + txtfname.Text + "', '" + txtaddress.Text + "', '" + ddlfield.SelectedValue + "', '" + txtcontact.Text + "', '" + txtmail.Text + "')", con);
        cmd.ExecuteNonQuery();
        info.Text = "Congradulations We have created a New Account for you!";
        con.Close();
       
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");

    }


    
}