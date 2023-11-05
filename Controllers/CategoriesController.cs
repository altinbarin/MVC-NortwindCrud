using _10_MVC_NortwindCrud.AppDbContext;
using _10_MVC_NortwindCrud.Models;
using _10_MVC_NortwindCrud.Models.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace _10_MVC_NortwindCrud.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly NORTHWNDContext db;

        public CategoriesController(NORTHWNDContext db)
        {
            this.db = db;
        }
        CategoryVM model = new CategoryVM();
        public IActionResult Liste(string name)
        {
            if(name  is null)
                name= "";
            model.clist = db.Categories.Where(x => x.CategoryName.Contains(name)).ToList();
            return View(model);
        }

        public IActionResult Detay(int id)
        {
            model.Category = db.Categories.FirstOrDefault(x => x.CategoryId.Equals(id));
            return View(model);
        }
        public IActionResult Guncelle(int id)
        {
            model.Category = db.Categories.FirstOrDefault(x => x.CategoryId.Equals(id));
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(int id, CategoryVM vM)
        {
            Category category = db.Categories.Find(id);
            category.CategoryName = vM.Category.CategoryName;
            category.Description = vM.Category.Description;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Create(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            TempData["result"] = category.CategoryName + "İsminde yeni bir kayıt eklendi";

            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int id)
        {
            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
            TempData["result"] = "Silme işlemi başarılı";
            return RedirectToAction("Liste");
        }



    }



}
