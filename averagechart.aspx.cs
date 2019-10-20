using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class averagechart : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    SqlCommand cm = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text == "micromax")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Feature,Rating from microrating", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            Chart1.DataSource = ds;
            Chart1.Series["Series1"].XValueMember = "Feature";
            Chart1.Series["Series1"].YValueMembers = "Rating";
            Chart1.DataBind();
            con.Close();
        }
        if (DropDownList1.Text == "lenovo")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Feature,Rating from lenovorating", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            Chart1.DataSource = ds;
            Chart1.Series["Series1"].XValueMember = "Feature";
            Chart1.Series["Series1"].YValueMembers = "Rating";
            Chart1.DataBind();
            con.Close();
        }
        if (DropDownList1.Text == "lava")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Feature,Rating from lavarating", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            Chart1.DataSource = ds;
            Chart1.Series["Series1"].XValueMember = "Feature";
            Chart1.Series["Series1"].YValueMembers = "Rating";
            Chart1.DataBind();
            con.Close();
        }
        if (DropDownList1.Text == "samsung")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Feature,Rating from samsungrating", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            Chart1.DataSource = ds;
            Chart1.Series["Series1"].XValueMember = "Feature";
            Chart1.Series["Series1"].YValueMembers = "Rating";
            Chart1.DataBind();
            con.Close();
        }
        if (DropDownList1.Text == "intex")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Feature,Rating from intexrating", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            Chart1.DataSource = ds;
            Chart1.Series["Series1"].XValueMember = "Feature";
            Chart1.Series["Series1"].YValueMembers = "Rating";
            Chart1.DataBind();
            con.Close();
        }


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}