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

        [HttpGet("Details/{id}")]
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

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet("Edit/{id}")]
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

        [HttpPost("Edit/{id}")]
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
                return RedirectToAction(nameof(Index));

            }

            return View(inventory);

        }


        [HttpGet("Delete/{id}")]
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

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var inventory = _context.Inventories.FirstOrDefault(c => c.Id == id);

            if (inventory == null)
            {
                return NotFound();
            }

            _context.Inventories.Remove(inventory);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
