using Ekmek.UI.Entity;
using Ekmek.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ekmek.UI.Controllers
{
    public class HomeController : Controller
    {
        MyDataContext context = new MyDataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = context.Products
                .Where(i => i.IsHome == true && i.IsApproved == true)
                .Select(i => new ProductVM()
                {
                    Id = i.Id,
                    ProductName = i.ProductName.Length > 30 ? i.ProductName.Substring(0, 15) + "..." : i.ProductName,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "DefaultImage.jpg",
                    CategoryID = i.CategoryID
                }).ToList();

            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            var urunler = context.Products.Where(i => i.Id == id).FirstOrDefault();
            return View(urunler);
        }

        public ActionResult ShowList()
        {
            var urunler = context.Products
                .Where(i => i.IsApproved == true)
                .Select(i => new ProductVM()
                {
                    Id = i.Id,
                    ProductName = i.ProductName.Length > 30 ? i.ProductName.Substring(0, 15) + "..." : i.ProductName,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stcok = i.Stcok,
                    Image = i.Image ?? "DefaultImage.jpg",
                    CategoryID = i.CategoryID

                }).ToList();

            return View(urunler);
        }
    }
}