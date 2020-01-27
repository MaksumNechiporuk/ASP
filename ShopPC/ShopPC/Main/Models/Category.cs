using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPC.Main.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string categoryDescription { get; set; }
        public List<VideoCard>videoCards { get; set; }

    }
}
