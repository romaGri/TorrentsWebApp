using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentsWebApp.Models
{
    public class TorrentsListViewModel
    {
        public IEnumerable<Torrents> torrents { get; set; }
        public string Name { get; set; }
    }
}
