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
    public partial class WebForm1 : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;User Id=system;Password=1Shakespear23#;");
            Con.Open();
            Adp = new OleDbDataAdapter("Select * from bill_admin where username=@U and password=@P", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@U", Login1.UserName);
            Adp.SelectCommand.Parameters.AddWithValue("@P", Login1.Password);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds,"D");
            if (Ds.Tables["D"].Rows.Count == 0)
                Login1.FailureText = "Username and/or password is incorrect.";    
            else
                Response.Redirect("billrun.aspx");
            Con.Close();
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}