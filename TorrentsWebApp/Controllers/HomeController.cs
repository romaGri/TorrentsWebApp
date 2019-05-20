using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorrentsWebApp.Models;

namespace TorrentsWebApp.Controllers
{
    public class HomeController : Controller
    {
        torrentsdbContext db;

        public HomeController(torrentsdbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 10;   // количество элементов на странице

            IQueryable<Torrents> source = db.Torrents;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageInfo pageViewModel = new PageInfo(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageInfo = pageViewModel,
                torrents = items
            };
            return View(viewModel);
        }
        [Route("Content/{id:int}")]
        public IActionResult Content(int id)
        {
            IQueryable<string> content = db.Torrents.Where(c => c.Id == id).Select(c => c.Content);
      
            return View(content);
        }

        public ActionResult Serach(string name)
        {
            IQueryable<Torrents> torrents = db.Torrents;
            if (!String.IsNullOrEmpty(name))
            {
                torrents = torrents.Where(p => p.Title.Contains(name));
            }
            TorrentsListViewModel viewModel = new TorrentsListViewModel
            {
                Name = name
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
