using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SignUp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\LaunchdryMVP\App_Data\LaunchdryDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserSignUp WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'", con);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Session["UserName"] = tbUsername.Text.Trim();
                Response.Redirect("~/Home/Laundry");
            }
            else { lblMessage.Visible = true; }
        }

        protected void btnSignUp_click(object sender, EventArgs e)
        {
               Response.Redirect("~/FormSignUp.aspx");
        }
    }
}