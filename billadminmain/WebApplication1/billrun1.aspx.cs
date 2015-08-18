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
    public partial class billrun1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection Con = null;
            OleDbDataAdapter Adp = null;
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger");
            
            
           //Adp = new OleDbDataAdapter("Select * from bill", Con);
            Adp = new OleDbDataAdapter("Select bill_cycle_number,count(*) as noofcustomers from billing_details group by bill_cycle_number", Con);
            DataSet Ds = new DataSet();
            if (!IsPostBack)
            {
                Adp.Fill(Ds, "D");
                GridView1.DataSource = Ds.Tables[0];
                GridView1.DataBind();
            }

        }
    }
}