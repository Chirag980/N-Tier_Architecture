using DotNetCore.DataAccess.Data;
using DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class CategoryController : Controller
    {
        //We are using ApplicationDbContext by using dependency Injection to show the Category Data.
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();//This code will run like Select * from Category Table it is for getting the all the data from the particular model or table
            return View(objCategoryList);
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category obj) 
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Name should not be same to Display Order.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id==0)
            {
                return NotFound();
            }
            Category? categoryDetails = _db.Categories.Find(Id);
            if (categoryDetails == null)
            {
                return NotFound();
            }
			return View(categoryDetails);
        }
        [HttpPost]
        public IActionResult Edit(Category obj) 
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Delete(int? Id)
        {
            if(Id == null || Id==0)
            {
                return NotFound();
            }
            Category? categoryDetails = _db.Categories.Find(Id);
            if (categoryDetails == null)
            {
                return NotFound();
            }
			return View(categoryDetails);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? Id) 
        {
            Category deleteCategory = _db.Categories.Find(Id);
            if (deleteCategory == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(deleteCategory);
            _db.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
