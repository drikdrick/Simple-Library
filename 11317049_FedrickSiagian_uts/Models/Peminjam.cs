using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _11317049_FedrickSiagian_uts.Models
{
    public class Peminjam
    {
        [Required(ErrorMessage ="Mohon masukkan nama anda.")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Mohon masukkan ID anda.")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Mohon masukkan Alamat anda.")]
        public string Alamat { get; set; }
    }
}