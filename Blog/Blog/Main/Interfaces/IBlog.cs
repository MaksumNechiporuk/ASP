using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Main.Models;

namespace Blog.Main.Interfaces
{
    interface IBlog
    {
        IEnumerable<BlogVM> blogVMs { get; }
    }
}
