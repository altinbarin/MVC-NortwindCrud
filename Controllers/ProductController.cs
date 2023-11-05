using _10_MVC_NortwindCrud.AppDbContext;
using _10_MVC_NortwindCrud.Models;
using _10_MVC_NortwindCrud.Models.DTO;
using _10_MVC_NortwindCrud.Models.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _10_MVC_NortwindCrud.Controllers
{
    public class ProductController : Controller
    {
        private readonly NORTHWNDContext db;
        public ProductController(NORTHWNDContext db)
        {
            this.db = db;
        }
        ProductVM pm = new ProductVM();
        public IActionResult Liste()
        {
            pm.plist = db.Products.Select(x => new ProductDTO
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                CompanyName = x.Supplier.CompanyName,
                CategoryName = x.Category.CategoryName,
                UnitPrice = (decimal)x.UnitPrice,
                Discontinued = x.Discontinued
            }).ToList();
            return View(pm);
        }
        public IActionResult Details(int id)
        {
            pm.product = db.Products.Find(id);
            return View(pm);
        }
        public IActionResult Update(int id)
        {
            pm.product = db.Products.Find(id);
            pm.SupplierForDropDown = FillSupplier();
            pm.CategoriesForDropDown = FillCategory();
            return View(pm);
        }
        [HttpPost]
        public IActionResult Update(int id,ProductVM pM)
        {
            Product p = db.Products.Find(id);
            p.ProductName = pM.product.ProductName;
            p.SupplierId = pM.product.SupplierId;
            p.CategoryId = pM.product.CategoryId;
            p.UnitPrice = pM.product.UnitPrice;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
        public IActionResult Create()
        {
            pm.CategoriesForDropDown = FillCategory();
            pm.SupplierForDropDown = FillSupplier();
            return View(pm);
        }
        [HttpPost]
        public IActionResult Create(ProductVM pM)
        {
           db.Products.Add(pM.product);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
        public IActionResult Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
        private List<SelectListItem> FillCategory()
        {
            return db.Categories.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
        }
        private List<SelectListItem> FillSupplier()
        {
            return db.Suppliers.Select(x => new SelectListItem
            {
                Text = x.CompanyName,
                Value = x.SupplierId.ToString()
            }).ToList();
        }
    }
}
