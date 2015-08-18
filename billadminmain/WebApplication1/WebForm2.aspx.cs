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
    public partial class WebForm2 : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string a = Request.QueryString["V1"].ToString();
            int b = Int32.Parse(a);
            
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.146/orcl;User Id=hr;Password=hr");
            Adp = new OleDbDataAdapter("Select * from payment where cust_id=?", Con);
            Adp.SelectCommand.Parameters.AddWithValue("?", b);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds, "D");
            GridView1.DataSource = Ds.Tables[0];
            GridView1.DataBind();
            
        }
    }
}