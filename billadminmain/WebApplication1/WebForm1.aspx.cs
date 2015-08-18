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
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        //OleDbDataAdapter Adp1 = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["V"].ToString();



            DateTime Ft2 = DateTime.Parse(Cache["V"].ToString());
            
            //Con = new OleDbConnection("Provider=MSDAORA;Data Source=192.168.0.171/orcl1;Password=tiger;User ID=scott");
            //Con = new ObConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger");
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.16/orcl;User Id=scott;Password=tiger");
            Adp = new OleDbDataAdapter("Select a.cust_id,b.invoice_id,a.bill_cycle_number,a.last_billed_date from billing_details a,payment b where a.cust_id=b.cust_id and bill_gen_date=?", Con);
            Adp.SelectCommand.Parameters.AddWithValue("?", Ft2);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds, "D");
            //Response.Write(Ds.Tables[0].Rows.Count);

            if (!IsPostBack)
            {
                GridView1.DataSource = Ds.Tables[0];
                GridView1.DataBind();
            }
        }

      

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("billrun1.aspx");
        }
    }
}