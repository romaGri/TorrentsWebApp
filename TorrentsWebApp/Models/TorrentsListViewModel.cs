
using System.Collections.Generic;
using TorrentsWebApp.Entities;

namespace TorrentsWebApp.Models
{
    public class TorrentsListViewModel
    {
        public IEnumerable<Torrent> torrents { get; set; }
        public string Name { get; set; }
    }
}
