using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
    public class DairyEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DairyEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DairyEntry> objDairyEntryList = _db.DairyEntrys.ToList();
            return View(objDairyEntryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DairyEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too Shor");
            }
            if (ModelState.IsValid)
            {
                _db.DairyEntrys.Add(obj); // Adds the new dairy entry to the database 
                _db.SaveChanges(); // Saves the changs to the database
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            DairyEntry? dairyEntry = _db.DairyEntrys.FirstOrDefault(e => e.Id == id);
            if (dairyEntry == null)
            {
                return NotFound();
            }
            return View(dairyEntry);
        }
        [HttpPost]
        public IActionResult Edit(DairyEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too Shor");
            }
            if (ModelState.IsValid)
            {
                _db.DairyEntrys.Update(obj); // Adds the new dairy entry in the database 
                _db.SaveChanges(); // Saves the changs to the database
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DairyEntry? dairyEntry = _db.DairyEntrys.FirstOrDefault(e => e.Id == id);
            if (dairyEntry == null)
            {
                return NotFound();
            }
            return View(dairyEntry);
        }

        [HttpPost]
        public IActionResult Delete(DairyEntry obj)
        {
          
          
                _db.DairyEntrys.Remove(obj); // Adds the new dairy entry in the database 
                _db.SaveChanges(); // Saves the changs to the database
                return RedirectToAction("Index");
            
          
        }


    }
}
