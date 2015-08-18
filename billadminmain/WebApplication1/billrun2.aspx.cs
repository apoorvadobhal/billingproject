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
    public partial class billrun2 : System.Web.UI.Page
    {
        int b;
         
          
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        OleDbDataAdapter Adp1 = null;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["V"];
            b = Convert.ToInt32(a);
            DateTime dt = DateTime.Now;
            int y = dt.Year;
            int m = dt.Month;
            int d = b;
            DateTime Ft1 = new DateTime(y, m, d);
             Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger");
             Adp = new OleDbDataAdapter("Scott.generate_bill_force", Con);
             Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
             Adp.SelectCommand.Parameters.AddWithValue("?",Ft1 );
             DataSet Ds = new DataSet();
             Adp.Fill(Ds);
             Adp1 = new OleDbDataAdapter("Select * from invoice_details where  bill_gen_date=?", Con);
             Adp1.SelectCommand.Parameters.AddWithValue("?", Ft1);
             DataSet Ds1 = new DataSet();
             Adp1.Fill(Ds1,"D");
             GridView1.DataSource = Ds1.Tables[0];
             GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter Adp2 = null;
            OleDbDataAdapter Adp3 = null;
            DateTime dt1 = DateTime.Now;
            int y1 = dt1.Year;
            int m1 = dt1.Month;
            int d1 = b;
            DateTime Ft2 = new DateTime(y1, m1, d1);
            Cache["V"] = Ft2;
            Adp2 = new OleDbDataAdapter("update invoice_details set finalise='y' where bill_gen_date=?", Con);
            Adp2.SelectCommand.Parameters.AddWithValue("?", Ft2);
            DataSet Ds = new DataSet();
            Adp2.Fill(Ds, "D");
            Adp3 = new OleDbDataAdapter("Scott.generate_payment", Con);
             Adp3.SelectCommand.CommandType = CommandType.StoredProcedure;
             Adp3.SelectCommand.Parameters.AddWithValue("?", Ft2);
             DataSet Ds1 = new DataSet();
             Adp3.Fill(Ds1, "D");
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("billrun1.aspx");
        }
    }
}