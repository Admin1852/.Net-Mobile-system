using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class cluster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnew_Click(object sender, EventArgs e)
    {
        con.Open();
        if (DropDownList1.SelectedValue == "1")
        {
            Response.Redirect("chart1.aspx");
        }
        else if (DropDownList1.SelectedValue == "2")
        {
            Response.Redirect("chart2.aspx");
        }
        else if (DropDownList1.SelectedValue == "3")
        {
            Response.Redirect("chart3.aspx");
        }
        else if (DropDownList1.SelectedValue == "4")
        {
            Response.Redirect("chart4.aspx");
        }
        else if (DropDownList1.SelectedValue == "5")
        {
            Response.Redirect("chart5.aspx");
        }
        else if (DropDownList1.SelectedValue == "6")
        {
            Response.Redirect("chart6.aspx");
        }
        else if (DropDownList1.SelectedValue == "7")
        {
            Response.Redirect("chart7.aspx");
        }
        else if (DropDownList1.SelectedValue == "8")
        {
            Response.Redirect("chart8.aspx");
        }
        else if (DropDownList1.SelectedValue == "9")
        {
            Response.Redirect("chart9.aspx");
        }
        else if (DropDownList1.SelectedValue == "10")
        {
            Response.Redirect("chart10.aspx");
        }
        con.Close();
    }
}