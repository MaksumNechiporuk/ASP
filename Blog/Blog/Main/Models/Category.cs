using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Main.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string categoryDescription { get; set; }
        public List<BlogVM> blogVMs { get; set; }
    }
}
