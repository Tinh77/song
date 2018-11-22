using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoloSong.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public List<SongCategory> SongCategories { get; set; }
    }
}
