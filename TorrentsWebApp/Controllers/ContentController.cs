﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TorrentsWebApp.Helpers;
using TorrentsWebApp.Infrastructure;

namespace TorrentsWebApp.Controllers
{
    public class ContentController : Controller
    {
        torrentsdbContext db;

        public ContentController(torrentsdbContext context)
        {
            db = context;
        }

        [Route("Content/{id:int}")]
        public IActionResult Content(int id)
        {
            var torrent = db.Torrents.FirstOrDefault(c => c.Id == id);

            torrent.Content = BBCodeHelper.Format(torrent.Content);
            torrent.Files.Select(f => f.TorrentId == id).ToArray();
            

            return View(torrent);
        }
    }
}