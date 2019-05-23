using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentsWebApp.Models
{
     public class IndexViewModel
    {

        public IEnumerable<Torrents> torrents { get; set; }
        public PageInfo PageInfo { get; set; }
        public string Name { get; set; }

    }
}
