using System;
using System.Collections.Generic;

namespace TorrentsWebApp.Entities
{
    public partial class Forum
    {
       

        public int Id { get; set; }

        public int? ForumId { get; set; }
        public string Value { get; set; }

       
    }
}
