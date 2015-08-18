using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication1
{
    public partial class login11 : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                Con = new OleDbConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger");
                Adp = new OleDbDataAdapter("Select * from login where USERNAME=? and PASSWORD=?", Con);
                Adp.SelectCommand.Parameters.AddWithValue("?", TextBox1.Text);
                Adp.SelectCommand.Parameters.AddWithValue("?", TextBox2.Text);
                DataSet Ds = new DataSet();
                Adp.Fill(Ds, "D");

                if (Ds.Tables["D"].Rows.Count == 0)
                    Label1.Text = "Invalid Username/Password";
                else
                    Response.Redirect("BillPage2.aspx");
            
            //catch (OleDbException E)
            //{
            //    Console.WriteLine("Error", E.Message);
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}