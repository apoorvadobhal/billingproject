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
    public partial class forcerun2 : System.Web.UI.Page
    {
        OleDbDataAdapter Adp4 = null;
        OleDbConnection Con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime Ft2 = DateTime.Parse(Cache["D"].ToString());
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger;");
            Adp4 = new OleDbDataAdapter("select cust_id,invoice_id,status,bill_gen_date from payment where bill_gen_date=?", Con);
            Adp4.SelectCommand.Parameters.AddWithValue("?",Ft2);
            DataSet Ds4 = new DataSet();
            Adp4.Fill(Ds4);
            GridView1.DataSource = Ds4.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forcerun1.aspx");
        }
    }
}