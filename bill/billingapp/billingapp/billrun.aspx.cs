using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
namespace billingapp
{
    public partial class billrun : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;User Id=system;Password=1Shakespear23#;");
            Con.Open();
            Adp = new OleDbDataAdapter("Select instance_create_date as Bill_Cycle_No,count(*) as No_of_Customers from cust_prod group by instance_create_date", Con);
            DataSet Ds = new DataSet();
            if (!IsPostBack)
            {
                Adp.Fill(Ds, "D");
                GridView1.DataSource = Ds.Tables[0];
                GridView1.DataBind();
            }
            Con.Close();
        }
    }
}