using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lets.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        ApplicationContext context;
        public UserController(ApplicationContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await context.Books.ToListAsync());

        }
        public async Task<IActionResult> About(int? id)
        {
            if (id != null)
            {
                Book book = await context.Books.FirstOrDefaultAsync(p => p.Id == id);
                if (book != null)
                    return View(book);
            }
            return NotFound();
        }
       
     
    }
}
