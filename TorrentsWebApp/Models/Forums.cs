using System;
using System.Collections.Generic;

namespace TorrentsWebApp.Models
{
    public partial class Forums
    {
        public Forums()
        {
            Torrents = new HashSet<Torrents>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Torrents> Torrents { get; set; }
    }
}
