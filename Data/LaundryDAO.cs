using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaunchdryMVP.Models;
using System.Data.SqlClient;


namespace LaunchdryMVP.Data
{
    internal class LaundryDAO
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\LaunchdryMVP\App_Data\LaunchdryDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";


        public List<LaundryModel> FetchAll()
        {
            List<LaundryModel> returnList = new List<LaundryModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.ListLaundry";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LaundryModel laundry = new LaundryModel();
                        laundry.ID = reader.GetInt32(0);
                        laundry.Name = reader.GetString(1);
                        laundry.Alamat = reader.GetString(2);
                        laundry.No_Telepon = reader.GetString(3);
                        laundry.Rating = reader.GetDecimal(4);
                        laundry.Jumlah_Reviewer = reader.GetString(5);
                        laundry.Jam_buka = reader.GetString(6);
                        laundry.Jam_tutup = reader.GetString(7);

                        returnList.Add(laundry);
                    }
                }
            }
            return returnList;
        }
    }
}