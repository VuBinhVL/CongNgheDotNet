using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4_WebsiteQuanLySanPhamm;
using Bai4_WebsiteQuanLySanPhamm.Models;

namespace Bai4_WebsiteQuanLySanPhamm.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            string connectionString = @"Data Source=LAPTOP-J7OECDJF\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True";
			QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}