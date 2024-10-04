using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4_WebsiteQuanLySanPhamm;
using Bai4_WebsiteQuanLySanPhamm.Models;

namespace Bai4_WebsiteQuanLySanPhamm.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
			string connectionString = @"Data Source=LAPTOP-J7OECDJF\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True";
            QuanLySanPhamDataContext dataContext = new QuanLySanPhamDataContext(connectionString);
            List<Product> dsProducts = dataContext.Products.ToList();
			return View(dsProducts);
        }
    }
}