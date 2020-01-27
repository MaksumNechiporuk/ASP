using Blog.Main.Interfaces;
using Blog.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Main.MockData
{
    public class MockCategory : ICategory, IBlog
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {Id=1,Name="Personal",categoryDescription="Is maintained by one person (usually its owner)"},
                    new Category {Id=2,Name="Collective",categoryDescription="Is managed by a group of persons according to the rules defined by the owner"},
                    new Category {Id=3,Name="Content blog",categoryDescription="Blog that publishes original copyrighted content"},
                    new Category {Id=4,Name="Monitoring blog",categoryDescription="Blog whose main content is commenting on links to other sites"},
                    new Category {Id=5,Name="Corporate blog",categoryDescription="Is maintained by employees of one organization"}
                };
            }
        }
        public IEnumerable<BlogVM> blogVMs
        {
            get
            {
                return new List<BlogVM>
                {
                    new BlogVM {Id=1,Name="About me",Author="Banan",Date=DateTime.Now,Description="Hi. This is a blog about me"},
                    new BlogVM {Id=2,Name="My family",Author="Programist",Date=DateTime.Now,Description="Hi. This is a blog about my family"},
                    new BlogVM {Id=3,Name="The best content",Author="Developer",Date=DateTime.Now,Description="Hi. This blog has the best content"},
                    new BlogVM {Id=4,Name="Weather monitoring",Author="oldBrother",Date=DateTime.Now,Description="Hi. This blog is weather monitoring"},
                    new BlogVM {Id=5,Name="My blog",Author="Lekar",Date=DateTime.Now,Description="Hi. This is my blog "}
                };
            }
        }

        //public List<Category> FillData()
        //{
        //    var blogs = blogVMs.ToList();
        //    int i = 0;
        //    foreach (var item in AllCategories)
        //    {
        //        item.blogVMs = new List<BlogVM> { blogs[i] };
        //        blogs[i].Category = item;
        //        i++;
        //    }
        //    return AllCategories.ToList();
        //}
    }
}
