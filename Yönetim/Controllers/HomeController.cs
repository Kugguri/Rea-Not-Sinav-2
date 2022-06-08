using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Yönetim.Models;

namespace Yönetim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoteContext _context;

        public HomeController(ILogger<HomeController> logger,NoteContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Category()
        {
            List<Category> List = _context.Category.ToList();
            return View(List);
        }

        public async Task<IActionResult> AddCategory(Category category) 
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            Category category = await _context.Category.FindAsync(id);
            _context.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        public IActionResult Account()
        {
            List<Account> List = _context.Account.ToList();
            return View(List);
        }
        public async Task<IActionResult> AddAccount(Account account)
        {
            await _context.AddAsync(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(account));
        }
        public async Task<IActionResult> DeleteAccount(int? id)
        {
            Account account = await _context.Account.FindAsync(id);
            _context.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(account));
        }
        public IActionResult Index()
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
    }
}
