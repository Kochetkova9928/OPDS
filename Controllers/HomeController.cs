using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OPDS.Data;
using OPDS.Models;

namespace OPDS.Controllers;

public class HomeController : Controller
{
    private UserManager<IdentityUser> _userManager;
    private readonly ApplicationDbContext _context;

    public HomeController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.Categories = await _context.CategoryModel.ToListAsync();
        return View(new UserModel { IsAdmin = IsAdmin() });
    }

    public IActionResult Search()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private bool IsAdmin()
    {
        if (User.Identity.Name == "blabla@mail.ru")
        {
            return true;
        }

        return false;
    }
}

