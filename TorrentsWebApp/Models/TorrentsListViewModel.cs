
using System.Collections.Generic;


namespace TorrentsWebApp.Models
{
    public class TorrentsListViewModel
    {
        public IEnumerable<Torrents> torrents { get; set; }
        public string Name { get; set; }
    }
}
