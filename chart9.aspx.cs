using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization;
using System.Web.UI.DataVisualization.Charting;
using System.Data;

public partial class chart9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlConnection objConn = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");

        SqlDataAdapter objDa = new SqlDataAdapter();

        string Select;

        Select = "Select * From userreg where Field='9'";

        objDa = new SqlDataAdapter(Select, objConn);

        objDa.Fill(ds);

        ChartID.DataSource = ds;

        ChartID.Legends.Add("average_marks").Title = "Cluster in Graph";

        ChartID.Series["Series1"].XValueMember = "Name";

        ChartID.Series["Series1"].YValueMembers = "Field";

        ChartID.DataBind();
    }
    protected void bindgrid()
    {
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from userreg where Field=9", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gduser.DataSource = ds;
        gduser.DataBind();
        con.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        bindgrid();
    }
}