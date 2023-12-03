using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSteve.Data;
using PizzaSteve.Models;

namespace PizzaSteve.Controllers
{
    public class NewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            var New = _context.News.ToList();
            return View(New);
        }
        [HttpGet("ManageIndex")]
        public IActionResult ManageIndex()
        {
            var New = _context.News.ToList();
            return View(New);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var New = _context.News.FirstOrDefault(c => c.Id == id);
            if (New == null)
            {
                return NotFound();
            }
            return View(New);

        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(New New)
        {
            _context.News.Add(New);
            _context.SaveChanges();
            return RedirectToAction(nameof(ManageIndex));

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var New = _context.News.FirstOrDefault(c => c.Id == id);
            if (New == null)
            {
                return NotFound();
            }
            return View(New);
        }

        [HttpPost]
        public IActionResult Edit(New New)
        {


            if (New.Id == 0)

            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(New);
                _context.SaveChanges();
                return RedirectToAction(nameof(ManageIndex));

            }

            return View(New);

        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var New = _context.News.FirstOrDefault(c => c.Id == id);
            if (New == null)
            {
                return NotFound();
            }
            return View(New);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var New = _context.News.FirstOrDefault(c => c.Id == id);

            if (New == null)
            {
                return NotFound();
            }
            
                _context.News.Remove(New);
                _context.SaveChanges();
                return RedirectToAction(nameof(ManageIndex));
            

        }
    }
}
