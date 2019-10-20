using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class companyregister : System.Web.UI.Page
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
            string sqlstr = "select * from comreg";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, con);
            DataSet dst = new DataSet();
            sda.Fill(dst);


            if (dst.Tables[0].Rows.Count != 0)
            {
                a = dst.Tables[0].Rows.Count;
                a = a + 1;
                Label12.Text = "AID0012345" + Convert.ToString(a);
                txtcname.Focus();
            }
            else
            {
                Label12.Text = "AID0012345";
                txtcname.Focus();
            }
            con.Close();
        }
    }


    protected void btnsave_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into comreg values('" + Label12.Text + "', '" + txtcname.Text + "', '" + txtUser.Text + "', '" + txtpass.Text + "', '" + txtfounder.Text + "', '" + txtaddress.Text + "', '" + ddlfield.SelectedValue + "', '" + txtwebsite.Text + "', '" + txtcontact.Text + "', '" + txtmail.Text + "')", con);
            cmd.ExecuteNonQuery();
            Response.Redirect("login.aspx");
            con.Close();
       
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }


    protected void ddlfield_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from new", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddlfield.DataSource = ds;
        ddlfield.DataBind();
        con.Close();
    }
}