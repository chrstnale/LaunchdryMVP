using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;

namespace SignUp
{
    public partial class FormSignUp : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\LaunchdryMVP\App_Data\LaunchdryDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\UserSignUp.mdf;Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hapus();

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbNomor_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                lblGagal.Text = "Lengkapi Data Sign Up dengan benar!";
            else if (tbPassword.Text != tbKonfirmasi.Text)
                lblGagal.Text = "Password yang dimasukkan berbeda! Coba Ulang!";
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmnd = new SqlCommand("UserAddorEdit", sqlCon);
                    sqlCmnd.CommandType = CommandType.StoredProcedure;
                    sqlCmnd.Parameters.AddWithValue("@IDUser", Convert.ToInt32(hfIDUser.Value == "" ? "0" : hfIDUser.Value));
                    sqlCmnd.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@NomorTelepon",  tbNomor.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@Alamat", tbAlamat.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                    sqlCmnd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                    sqlCmnd.ExecuteNonQuery();
                    Hapus();
                    lblBerhasil.Text = "Sign Up Berhasil";
                    //lblGagal.Text = "Sign Up Gagal! Coba Lagi";
                }
            }
        }

        void Hapus()
        {
            tbFirstName.Text = tbLastName.Text = tbNomor.Text = tbEmail.Text = tbAlamat.Text = tbUsername.Text = tbPassword.Text = tbKonfirmasi.Text = "";
            hfIDUser.Value = "";
            lblBerhasil.Text = lblGagal.Text = "";

        }

        protected void btnLogin_click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

    }



}

