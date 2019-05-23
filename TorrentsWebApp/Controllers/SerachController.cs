using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorrentsWebApp.Models;

namespace TorrentsWebApp.Views.Content
{
    public class SerachController : Controller
    {

        torrentsdbContext db;

        public SerachController(torrentsdbContext context)
        {
            db = context;
        }

        //public async Task<IActionResult> Serach(string id)
        //{
        //    var torrents = from m in db.Torrents
        //                 select m;

        //    if (!String.IsNullOrEmpty(id))
        //    {
        //        torrents = torrents.Where(p => p.Title.Contains(id));
        //    }

        //    return View(await torrents.ToListAsync());
        //}

        public  async Task<IActionResult> Seracher(string id, int page = 1)
        {
            
            //var torrents = from m in db.Torrents
            //               select m;
            //string name = Request.Query.FirstOrDefault(p => p.Key == "SerachString").Value;
            IQueryable<Torrents> source = db.Torrents;
            if (!String.IsNullOrEmpty(id))
            {
                source = source.Where(p => p.Title.Contains(id));
            }
            //TorrentsListViewModel viewModel = new TorrentsListViewModel
            //{
            //    Name = id
            
            //};
            int pageSize = 10;   // количество элементов на странице

            
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

      
        [HttpPost]
        public string Serach(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
    }
}