using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPC.Main.Models
{
    public class VideoCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public uint Price { get; set; }
        public Category Category { get; set; }
    }
}
