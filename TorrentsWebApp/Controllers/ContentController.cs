using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TorrentsWebApp.Models;

namespace TorrentsWebApp.Controllers
{
    public class ContentController : Controller
    {
        torrentsdbContext db;

        public ContentController (torrentsdbContext context)
        {
            db = context;
        }
        [Route("Content/{id:int}")]
        public IActionResult Content(int id)
        {
            IQueryable<string> content = db.Torrents.Where(c => c.Id == id).Select(c => c.Content);

            return View(content);
        }
    }
}