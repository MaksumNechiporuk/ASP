using ShopPC.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPC.Main.Interfaces
{
    interface IVideoCard
    {
        IEnumerable<VideoCard> videoCards { get; }
        
    }
}
