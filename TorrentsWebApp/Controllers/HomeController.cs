using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorrentsWebApp.Entities;
using TorrentsWebApp.Infrastructure;
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

        public async Task<IActionResult> Index()
        {
            int page = 1;
            int pageSize = 30;   // количество элементов на странице

            List<Torrent> source = db.Torrents.Take(pageSize).ToList();
            var count = db.Torrents.Count();
            PageInfo pageViewModel = new PageInfo(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageInfo = pageViewModel,
                torrents = source
            };
            return View("PageHelper", viewModel);
        }

        public async Task<IActionResult> PageHelper(string s, int page = 1)
        {
            int pageSize = 30;
            IQueryable<Torrent> torrents = db.Torrents.Where(p => p.Title.Contains(s ?? "")).Skip((page - 1) * pageSize).Take(pageSize);
            var count = db.Torrents.Count();
            List<Torrent> torents_count = torrents.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync().Result;
            PageInfo pageViewModel = new PageInfo(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageInfo = pageViewModel,
                torrents = torrents,
                SearchString = s
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
