using LaunchdryMVP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LaunchdryMVP.Data
{
    internal class OrderDAO
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\LaunchdryMVP\App_Data\LaunchdryDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

        public List<OrderModel> FetchAll()
        {
            List<OrderModel> returnList = new List<OrderModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.[Order]";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderModel order = new OrderModel();
                        order.No = reader.GetInt32(0);
                        order.Jenis_Layanan = reader.GetString(1);
                        order.Jenis_Pakaian = reader.GetString(2);
                        order.Tanggal_Masuk = reader.GetDateTime(3);
                        order.Tanggal_Masuk = reader.GetDateTime(4);
                        order.Metode_Pembayaran = reader.GetString(5);
                        order.Berat_Perkiraan = reader.GetInt32(6);
                        order.Status = reader.GetString(7);
                        order.Alamat_Pengantaran = reader.GetString(8);
                        order.Biaya = reader.GetInt32(9);


                        returnList.Add(order);
                    }
                }
            }
            return returnList;

        }

        internal int Delete(int no)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.[Order] WHERE No = @no";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@No", System.Data.SqlDbType.Int).Value = no;

                connection.Open();

                int deletedId = command.ExecuteNonQuery();

                return deletedId;

            }

        }
        public OrderModel FetchOne(int no)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.[Order] WHERE No = @no";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@no", System.Data.SqlDbType.Int).Value = no;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                OrderModel order = new OrderModel();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        order.No = reader.GetInt32(0);
                        order.Jenis_Layanan = reader.GetString(1);
                        order.Jenis_Pakaian = reader.GetString(2);
                        order.Tanggal_Masuk = reader.GetDateTime(3);
                        order.Tanggal_Masuk = reader.GetDateTime(4);
                        order.Metode_Pembayaran = reader.GetString(5);
                        order.Berat_Perkiraan = reader.GetInt32(6);
                        order.Status = reader.GetString(7);
                        order.Alamat_Pengantaran = reader.GetString(8);
                        order.Biaya = reader.GetInt32(9);

                    }
                }
                return order;
            }

        }

        public int Create(OrderModel orderModel)
        {
            string sqlQuery = "";
            //if (orderModel.No <= 0)
            //{
                sqlQuery = "INSERT INTO dbo.[Order] VALUES(" +
                    "@Jenis_Layanan, " +
                    "@Jenis_Pakaian, " +
                    "@Tanggal_Masuk, " +
                    "@Tanggal_Ambil, " +
                    "@Metode_Pembayaran, " +
                    "@Berat_Perkiraan, " +
                    "@Status, " +
                    "@Alamat_Pengantaran," +
                    "@Biaya)";
            //}
            //else
            //{
            //    sqlQuery = "UPDATE dbo.[Order] SET " +
            //        "Jenis_Layanan = @Jenis_Layanan, " +
            //        "Jenis_Pakaian = @Jenis_Pakaian, " +
            //        "Tanggal_Masuk = @Tanggal_Masuk, " +
            //        "Tanggal_Ambil = @Tanggal_Ambil, " +
            //        "Metode_Pembayaran = @Metode_Pembayaran, " +
            //        "Berat_Perkiraan = @Berat_Perkiraan, " +
            //        "Status = @Status, " +
            //        "Alamat_Pengantaran = @Alamat_Pengantaran," +
            //        "Biaya = @Biaya";
            //}

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //command.Parameters.Add("@No", System.Data.SqlDbType.Int).Value = orderModel.No;
                command.Parameters.Add("@Jenis_Layanan", System.Data.SqlDbType.VarChar, 1000).Value = orderModel.Jenis_Layanan;
                command.Parameters.Add("@Jenis_Pakaian", System.Data.SqlDbType.VarChar, 1000).Value = orderModel.Jenis_Pakaian;
                command.Parameters.Add("@Tanggal_Masuk", System.Data.SqlDbType.DateTime).Value = orderModel.Tanggal_Masuk;
                command.Parameters.Add("@Tanggal_Ambil", System.Data.SqlDbType.DateTime).Value = orderModel.Tanggal_Ambil;
                command.Parameters.Add("@Metode_Pembayaran", System.Data.SqlDbType.VarChar, 1000).Value = orderModel.Metode_Pembayaran;
                command.Parameters.Add("@Berat_Perkiraan", System.Data.SqlDbType.Int).Value = orderModel.Berat_Perkiraan;
                if (orderModel.Tanggal_Ambil >= DateTime.Now)
                {
                    command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 1000).Value = orderModel.Status;
                }
                    else
                {
                    command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 1000).Value = "Diproses";
                };
            command.Parameters.Add("@Alamat_Pengantaran", System.Data.SqlDbType.VarChar, 1000).Value = orderModel.Alamat_Pengantaran;
                command.Parameters.Add("@Biaya", System.Data.SqlDbType.Int).Value= orderModel.Biaya * 3000 + 10000;

                connection.Open();

                int newNo = command.ExecuteNonQuery();

                return newNo;
            }

        }
    }
}