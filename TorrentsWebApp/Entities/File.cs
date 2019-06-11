

namespace TorrentsWebApp.Entities

{
    public  class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int TorrentId { get; set; }

    }
}
