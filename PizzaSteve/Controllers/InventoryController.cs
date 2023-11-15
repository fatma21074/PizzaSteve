using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSteve.Data;
using PizzaSteve.Models;

namespace PizzaSteve.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var inventory = _context.Inventories.ToList();
            return View(inventory);
        }
        public IActionResult ManageIndex()
        {
            var inventory = _context.Inventories.ToList();
            return View(inventory);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = _context.Inventories.FirstOrDefault(c => c.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);

        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
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

            var inventory = _context.Inventories.FirstOrDefault(c => c.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);

        }

        [HttpPost]
        public IActionResult Edit(Inventory inventory)
        {


            if (inventory.Id == 0)

            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(inventory);
                _context.SaveChanges();
                return RedirectToAction(nameof(ManageIndex));

            }

            return View(inventory);

        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = _context.Inventories.FirstOrDefault(c => c.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var inventory = _context.Inventories.FirstOrDefault(c => c.Id == id);

            if (inventory == null)
            {
                return NotFound();
            }

            _context.Inventories.Remove(inventory);
            _context.SaveChanges();

            return RedirectToAction(nameof(ManageIndex));
        }
    }
}
