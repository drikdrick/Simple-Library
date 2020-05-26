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
        public ActionResult Index()
        {
            Buku[] array =
            {
                new Buku{ kodeBuku="B101", judulBuku="Everything is Fucked", pengarangBuku="Mark Manson", tglTerbit="14 Mei 2019" },
                new Buku{ kodeBuku="B102", judulBuku="C For Dummies", pengarangBuku="Dan Gookin", tglTerbit="14 Mei 2004" },
                new Buku{ kodeBuku="B103", judulBuku="Teach C Yourself in 21 Days", pengarangBuku="Peter Aitken, Bradley L. Jones", tglTerbit="14 Mei 2000" },
            };
            return View(array);
        }

        [HttpGet]
        public ActionResult FormPesan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormPesan(Models.Peminjam Peminjam)
        {
            return View("Terimakasih", Peminjam);
        }
    }
    
}