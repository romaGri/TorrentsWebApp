using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentsWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
//@foreach(var i in Model)
//{
//            < tr >< td >< a href = "Content" /> @i.Id </ td >< td > @i.RegistredAt </ td >< td > @i.Title </ td >< td > @i.Size Byte </ td >< td > @i.TrackerId </ td ></ tr >
//        }

//@model IEnumerable<TorrentsWebApp.Models.Torrents>