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
    public partial class Login : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger");
            Con.Open();
            Adp = new OleDbDataAdapter("Select * from login", Con);
            //Adp.SelectCommand.Parameters.AddWithValue("@U", Login1.UserName.ToString());
            //Adp.SelectCommand.Parameters.AddWithValue("@P", Login1.Password.ToString());
            DataSet Ds = new DataSet();
            Adp.Fill(Ds, "D");
            if (Ds.Tables["D"].Rows.Count == 0)
                Login1.FailureText = "Username and/or password is incorrect.";
            else
                Response.Redirect("BillPage2.aspx");
            Con.Close();
          
        }
    }
}