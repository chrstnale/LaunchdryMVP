using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaunchdryMVP.Models
{
    public class OrderModel
    {
        [Required]
        public int No { get; set; }
        [Required]
        public string Jenis_Layanan { get; set; }
        [Required]
        public string Jenis_Pakaian { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Tanggal_Masuk { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Tanggal_Ambil { get; set; }
        [Required]
        public string Metode_Pembayaran { get; set; }
        [Required]
        public int Berat_Perkiraan { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Alamat_Pengantaran { get; set; }
        public int Biaya { get; set; }


        public OrderModel()
        {
            No = 0;
            Jenis_Layanan = "Jenis Layanan";
            Jenis_Pakaian = "Jenis Pakaian";
            Tanggal_Masuk = DateTime.Now;
            Tanggal_Ambil = DateTime.Now;
            Metode_Pembayaran = "Bayar";
            Berat_Perkiraan = 0;
            Status = "Diproses";
            Alamat_Pengantaran = "Alamat";
            Biaya = 0;
        }

        public OrderModel(int no, string jenis_Layanan, string jenis_Pakaian, DateTime hari_Masuk, DateTime hari_Ambil, string metode_Pembayaran, int berat_Perkiraan, string alamat_Pengantaran)
        {
            No = no;
            Jenis_Layanan = jenis_Layanan;
            Jenis_Pakaian = jenis_Pakaian;
            Tanggal_Masuk = DateTime.Now;
            Tanggal_Ambil = hari_Ambil;
            Metode_Pembayaran = metode_Pembayaran;
            Berat_Perkiraan = berat_Perkiraan;
            if (hari_Masuk >= DateTime.Now)
            {
                Status = "Diproses";
            }
            else
            {
                Status = "Sudah Jadi";
            };
            Alamat_Pengantaran = alamat_Pengantaran;
            Biaya = (berat_Perkiraan * 3000 + 10000);
        }

    }
}