using System;
using System.Collections.Generic;

namespace TorrentsWebApp.Models
{
    public partial class Files
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int TorrentId { get; set; }

        public virtual Torrents Torrent { get; set; }
    }
}
