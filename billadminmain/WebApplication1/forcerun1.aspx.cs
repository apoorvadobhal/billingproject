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
    public partial class forcerun1 : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        OleDbDataAdapter Adp1 = null;
        OleDbDataAdapter Adp2 = null;
        OleDbDataAdapter Adp3 = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger;");
            Adp = new OleDbDataAdapter("Scott.generate_bill_force", Con);
            Adp.SelectCommand.CommandType=CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("?", DateTime.Parse(TextBox1.Text));
            DataSet Ds = new DataSet();
            DateTime Ft = DateTime.Parse(TextBox1.Text);
            Cache["D"] = Ft;
            Adp.Fill(Ds);
            Adp1 = new OleDbDataAdapter("select * from invoice_details where bill_gen_date=?", Con);
            Adp1.SelectCommand.Parameters.AddWithValue("?", DateTime.Parse(TextBox1.Text));
            DataSet Ds1 = new DataSet();
            Adp1.Fill(Ds1, "D");
            GridView1.DataSource = Ds1.Tables[0];
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger;");
            Adp2 = new OleDbDataAdapter("update invoice_details set finalise='y'  where bill_gen_date=?", Con);
            Adp2.SelectCommand.Parameters.AddWithValue("?", DateTime.Parse(TextBox1.Text));
            DataSet Ds2 = new DataSet();
            Adp2.Fill(Ds2);
            Adp3 = new OleDbDataAdapter("Scott.generate_payment", Con);
            Adp3.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp3.SelectCommand.Parameters.AddWithValue("?", DateTime.Parse(TextBox1.Text));
            DataSet Ds3 = new DataSet();
            Adp3.Fill(Ds3);
           
            Response.Redirect("forcerun2.aspx");
        }
    }
}