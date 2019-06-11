
using System.Collections.Generic;

using TorrentsWebApp.Entities;

namespace TorrentsWebApp.Models
{
     public class IndexViewModel
    {

        public IEnumerable<Torrent> torrents { get; set; }
        public PageInfo PageInfo { get; set; }
        //public string Name { get; set; }
        public string SearchString { get; set; }

    }
}
