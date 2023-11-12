using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaSteve.Data;
using System.Threading.Tasks;

namespace PizzaSteve.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public RolesController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Add(RoleFormViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return View("Index", await _roleManager.Roles.ToListAsync());

        //    if (await _roleManager.RoleExistsAsync(model.Name))
        //    {
        //        ModelState.AddModelError("Name", "Role is exists!");
        //        return View("Index", await _roleManager.Roles.ToListAsync());
        //    }

        //    await _roleManager.CreateAsync(new IdentityRole(model.Name.Trim()));

        //    return RedirectToAction(nameof(Index));
        //}

    }
}
