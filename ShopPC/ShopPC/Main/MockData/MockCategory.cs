using ShopPC.Main.Interfaces;
using ShopPC.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPC.Main.MockData
{
    public class MockCategory : IVideoCardsCategory
    {
        public IEnumerable<Category> AllCategories { get {

                return new List<Category>
                {
                    new Category {Id=1,Name="Games",categoryDescription="Video card for games"},
                    new Category {Id=2,Name="Designers",categoryDescription="Video card for 3d"}
                };
            } }
    }
}
