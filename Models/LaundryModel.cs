using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaunchdryMVP.Models
{
    public class LaundryModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alamat { get; set; }
        [Required]
        public string No_Telepon { get; set; }
        [Required]
        public decimal Rating { get; set; }
        [Required]
        public string Jumlah_Reviewer { get; set; }
        [Required]
        public string Jam_buka { get; set; }
        [Required]
        public string Jam_tutup { get; set; }

        public LaundryModel()
        {
            ID = 0;
            Name = "Laundry Name";
            Alamat = "Product Name";
            No_Telepon = "0";
            Rating = 0;
            Jumlah_Reviewer = "0";
            Jam_buka = "Jam buka";
            Jam_tutup = "Jam tutup";
        }

        public LaundryModel(int id, string name, string alamat, string noTelp, decimal rating, string jumlahReview, string jamBuka, string jamTutup)
        {
            ID = id;
            Name = name;
            Alamat = alamat;
            No_Telepon = noTelp;
            Rating = rating;
            Jumlah_Reviewer = jumlahReview;
            Jam_buka = jamBuka;
            Jam_tutup = jamTutup;
        }
    }
}