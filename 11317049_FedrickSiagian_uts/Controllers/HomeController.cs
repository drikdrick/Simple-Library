using _11317049_FedrickSiagian_uts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace _11317049_FedrickSiagian_uts.Controllers
{
    public class HomeController : Controller
    {
        static List<Buku> buku = new List<Buku>()
        {
                new Buku{ kodeBuku="B101", judulBuku="Everything is Fucked", pengarangBuku="Mark Manson", tglTerbit="14 Mei 2019" },
                new Buku{ kodeBuku="B102", judulBuku="C For Dummies", pengarangBuku="Dan Gookin", tglTerbit="14 Mei 2004" },
                new Buku{ kodeBuku="B103", judulBuku="Teach C Yourself in 21 Days", pengarangBuku="Peter Aitken, Bradley L. Jones", tglTerbit="14 Mei 2000" },
        };
        static List<Peminjaman> peminjaman = new List<Peminjaman>()
        {
                new Peminjaman{ID="11317049", Nama="Fedrick Siagian", Alamat="Tambunan", kodeBuku="B101", judulBuku="Everything is Fucked", pengarangBuku="Mark Manson"},
                new Peminjaman{ID="11317048", Nama="Tommy Sitinjak", Alamat="Tambunan", kodeBuku="B102", judulBuku="C For Dummies", pengarangBuku="Dan Gookin"},
                new Peminjaman{ID="11317047", Nama="Jo Sitorus", Alamat="Tambunan", kodeBuku="B103", judulBuku="Teach C Yourself in 21 Days", pengarangBuku="Peter Aitken, Bradley L. Jones"},
        };

        static List<Peminjam> peminjam = new List<Peminjam>()
        {
            new Peminjam{ID="11317049", Nama="Fedrick Siagian", Alamat="Tambunan" },
            new Peminjam{ID="11317048", Nama="Tommy Sitinjak", Alamat="Tambunan" },
            new Peminjam{ID="11317047", Nama="Jo Sitorus", Alamat="Tambunan" },
        };
        public ActionResult Index()
        { 
            return View(buku);
        }

        public ActionResult dataPeminjaman()
        {
            return View(peminjaman);
        }

        [HttpGet]
        public ActionResult FormPesan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormPesan(Models.Peminjaman model)
        {
            peminjaman.Add(model);
            return View("Terimakasih", model);
        }
    }
    
}