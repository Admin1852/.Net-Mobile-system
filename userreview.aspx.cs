using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class userreview : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
    SqlCommand cm = new SqlCommand();
    string a1 = "Camera";
    string b1 = "Storage";
    string c1 = "Battery_Life";
    string d1 = "Weight";
    string e1 = "Design";
    string f1 = "Screen";
    protected void Page_Load(object sender, EventArgs e)
    {

       

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



        if (DropDownList1.Text == "micromax")
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                TextBox1.Text = "Positive";

            }
            else
            {
                TextBox1.Text = "Negative";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                TextBox2.Text = "Positive";
            }
            else
            {
                TextBox2.Text = "Negative";
            }
            if (CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                TextBox3.Text = "Negative";
            }
            else
            {
                TextBox3.Text = "Positive";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                TextBox4.Text = "Positive";
            }
            else
            {
                TextBox4.Text = "Negative";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                TextBox5.Text = "Positive";
            }
            else
            {
                TextBox5.Text = "Negative";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                TextBox6.Text = "Positive";
            }
            else
            {
                TextBox6.Text = "Negative";
            }

            using (SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
            {
                using (SqlCommand com1 = new SqlCommand())
                {

                    con.Open();
                    cm = new SqlCommand("insert into micromax values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
                    cm.ExecuteNonQuery();
                    Response.Write("<script>alert('Review submitted successfully');</script>");
                    con.Close();
                }
            }
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Camera)from micromax where Camera='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Camera)from micromax where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
               

              
           double cc = (double)a / c;
          
               

           double ccc = (double)cc * 100;

         
               
              Label10.Text = ccc.ToString();;
              

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' Feature='"+a1+"'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

 catch
            {
            }

            ////Storage//////
            
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Storage)from micromax where Storage='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Storage)from micromax where Storage='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
             
               
                double cc = (double)a / c;
                
                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;
             

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                       
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' where Feature='" + b1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Battery Life////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Battery_Life)from micromax where Battery_Life='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Battery_Life)from micromax where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
       

               
                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;
              

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                       
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' where Feature='" + c1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            /////weight/////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Weight)from micromax where Weight='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Weight)from micromax where Weight='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
               

                
                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); 
               

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                       
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' where Feature='" + d1+ "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Design///
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Design)from micromax where Design='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Design)from micromax where Design='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
               

               
                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); 
               

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                       
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' where Feature='" + e1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Screen////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Screen)from micromax where Screen='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Screen)from micromax where Screen='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
                Response.Write("values is:" + c);

               
                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); 
               
                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update microrating set Rating='" + Label10.Text + "' where Feature='" + f1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }







        }


        ////// samsung///////



        if (DropDownList1.Text == "samsung")
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                TextBox1.Text = "Postive";

            }
            else
            {
                TextBox1.Text = "Negative";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                TextBox2.Text = "Positive";
            }
            else
            {
                TextBox2.Text = "Negative";
            }
            if (CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                TextBox3.Text = "Negative";
            }
            else
            {
                TextBox3.Text = "Positive";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                TextBox4.Text = "Positive";
            }
            else
            {
                TextBox4.Text = "Negative";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                TextBox5.Text = "Positive";
            }
            else
            {
                TextBox5.Text = "Negative";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                TextBox6.Text = "Positive";
            }
            else
            {
                TextBox6.Text = "Negative";
            }
            con.Open();
            cm = new SqlCommand("insert into samsung values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('Review submitted successfully');</script>");
            con.Close();

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Camera)from samsung where Camera='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Camera)from samsung where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;



                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + a1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Storage//////

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Storage)from samsung where Storage='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Storage)from samsung where Storage='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;


                double cc = (double)a / c;

                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + b1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Battery Life////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Battery_Life)from samsung where Battery_Life='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Battery_Life)from samsung where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + c1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            /////weight/////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Weight)from samsung where Weight='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Weight)from samsung where Weight='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + d1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Design///
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Design)from samsung where Design='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Design)from samsung where Design='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + e1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Screen////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Screen)from samsung where Screen='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Screen)from samsung where Screen='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
                Response.Write("values is:" + c);


                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update samsungrating set Rating='" + Label10.Text + "' where Feature='" + f1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }



        }



        ////intex////
        if (DropDownList1.Text == "intex")
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                TextBox1.Text = "Postive";

            }
            else
            {
                TextBox1.Text = "Negative";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                TextBox2.Text = "Positive";
            }
            else
            {
                TextBox2.Text = "Negative";
            }
            if (CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                TextBox3.Text = "Negative";
            }
            else
            {
                TextBox3.Text = "Positive";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                TextBox4.Text = "Positive";
            }
            else
            {
                TextBox4.Text = "Negative";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                TextBox5.Text = "Positive";
            }
            else
            {
                TextBox5.Text = "Negative";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                TextBox6.Text = "Positive";
            }
            else
            {
                TextBox6.Text = "Negative";
            }
            con.Open();
            cm = new SqlCommand("insert into intex values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('Review submitted successfully');</script>");
            con.Close();



            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Camera)from intex where Camera='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Camera)from intex where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;



                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" +a1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Storage//////

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Storage)from intex where Storage='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Storage)from intex where Storage='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;


                double cc = (double)a / c;

                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" + b1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Battery Life////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Battery_Life)from intex where Battery_Life='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Battery_Life)from intex where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" + c1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            /////weight/////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Weight)from intex where Weight='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Weight)from intex where Weight='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" + d1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Design///
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Design)from intex where Design='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Design)from intex where Design='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" + e1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Screen////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Screen)from intex where Screen='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Screen)from intex where Screen='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
                Response.Write("values is:" + c);


                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update intexrating set Rating='" + Label10.Text + "' where Feature='" + f1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }




        }


        ////lenovo////
        if (DropDownList1.Text == "lenovo")
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                TextBox1.Text = "Postive";

            }
            else
            {
                TextBox1.Text = "Negative";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                TextBox2.Text = "Positive";
            }
            else
            {
                TextBox2.Text = "Negative";
            }
            if (CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                TextBox3.Text = "Negative";
            }
            else
            {
                TextBox3.Text = "Positive";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                TextBox4.Text = "Positive";
            }
            else
            {
                TextBox4.Text = "Negative";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                TextBox5.Text = "Positive";
            }
            else
            {
                TextBox5.Text = "Negative";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                TextBox6.Text = "Positive";
            }
            else
            {
                TextBox6.Text = "Negative";
            }
            con.Open();
            cm = new SqlCommand("insert into lenovo values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('Review submitted successfully');</script>");
            con.Close();
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Camera)from lenovo where Camera='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Camera)from lenovo where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;



                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lenovorating set Rating='" + Label10.Text + "' where Feature='" + a1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Storage//////

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Storage)from lenovo where Storage='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Storage)from lenovo where Storage='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;


                double cc = (double)a / c;

                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lenovorating set Rating='" + Label10.Text + "' where Feature='" + b1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Battery Life////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Battery_Life)from lenovo where Battery_Life='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Battery_Life)from lenovo where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lenovorating set Rating='" + Label10.Text + "' where Feature='" + c1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            /////weight/////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Weight)from lenovo where Weight='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Weight)from lenovo where Weight='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update  lenovorating set Rating='" + Label10.Text + "' where Feature='" + d1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Design///
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Design)from lenovo where Design='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Design)from lenovo where Design='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lenovorating set Rating='" + Label10.Text + "' where Feature='" + e1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Screen////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Screen)from lenovo where Screen='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Screen)from lenovo where Screen='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
                Response.Write("values is:" + c);


                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lenovorating set Rating='" + Label10.Text + "' where Feature='" + f1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


        }

        /////lava////

        if (DropDownList1.Text == "lava")
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                TextBox1.Text = "Postive";

            }
            else
            {
                TextBox1.Text = "Negative";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                TextBox2.Text = "Positive";
            }
            else
            {
                TextBox2.Text = "Negative";
            }
            if (CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                TextBox3.Text = "Negative";
            }
            else
            {
                TextBox3.Text = "Positive";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                TextBox4.Text = "Positive";
            }
            else
            {
                TextBox4.Text = "Negative";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                TextBox5.Text = "Positive";
            }
            else
            {
                TextBox5.Text = "Negative";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                TextBox6.Text = "Positive";
            }
            else
            {
                TextBox6.Text = "Negative";
            }
            con.Open();
            cm = new SqlCommand("insert into lava values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('Review submitted successfully');</script>");
            con.Close();

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Camera)from lava where Camera='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Camera)from lava where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;



                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + a1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Storage//////

            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Storage)from lava where Storage='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Storage)from lava where Storage='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;


                double cc = (double)a / c;

                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + b1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            ////Battery Life////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Battery_Life)from lava where Battery_Life='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Battery_Life)from lava where Camera='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString(); ;


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + c1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }

            /////weight/////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Weight)from lava where Weight='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Weight)from lava where Weight='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;


                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + d1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Design///
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Design)from lava where Design='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Design)from lava where Design='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;



                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();


                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + e1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }


            ////Screen////
            try
            {
                string status = "Positive";
                con.Open();
                cm = new SqlCommand("select count(Screen)from lava where Screen='" + status + "'", con);
                Label6.Text = cm.ExecuteScalar().ToString();
                con.Close();
                string sts = "negative";
                SqlConnection con1 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select count(Screen)from lava where Screen='" + sts + "'", con1);
                Label11.Text = cmd1.ExecuteScalar().ToString();
                con1.Close();

                int a = Convert.ToInt32(Label6.Text);
                int b = Convert.ToInt32(Label11.Text);
                int c = a + b;
                Response.Write("values is:" + c);


                double cc = (double)a / c;



                double ccc = (double)cc * 100;

                Label10.Text = ccc.ToString();

                using (SqlConnection con11 = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True"))
                {
                    using (SqlCommand com11 = new SqlCommand())
                    {
                        con11.Open();
                        cm = new SqlCommand("update lavarating set Rating='" + Label10.Text + "' where Feature='" + f1 + "'", con11);
                        cm.ExecuteNonQuery();
                        con11.Close();
                    }
                }
            }

            catch
            {
            }




          


        }
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
        CheckBox4.Checked = false;
        CheckBox5.Checked = false;
        CheckBox6.Checked = false;
        CheckBox7.Checked = false;
        CheckBox8.Checked = false;
        CheckBox9.Checked = false;
        CheckBox10.Checked = false;
        CheckBox11.Checked = false;
        CheckBox12.Checked = false;
        CheckBox13.Checked = false;
        CheckBox14.Checked = false;
        CheckBox15.Checked = false;
        CheckBox16.Checked = false;
        CheckBox17.Checked = false;
        CheckBox18.Checked = false;
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";





    }
}

    

    

    
    



      

  

