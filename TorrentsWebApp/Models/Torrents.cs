using System;
using System.Collections.Generic;

namespace TorrentsWebApp.Models
{
    public partial class Torrents
    {
        public Torrents()
        {
            Files = new HashSet<Files>();
        }

        public int Id { get; set; }
        public DateTime RegistredAt { get; set; }
        public string Size { get; set; }
        public string Title { get; set; }
        public string Hash { get; set; }
        public int? TrackerId { get; set; }
        public string Content { get; set; }
        public string Dir { get; set; }
        public int? ForumId { get; set; }
        public bool Del { get; set; }

        public virtual Forums Forum { get; set; }
        public virtual ICollection<Files> Files { get; set; }
    }
}
