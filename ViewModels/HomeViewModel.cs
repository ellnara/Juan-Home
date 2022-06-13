using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juan.Models;

namespace Juan.ViewModels
{
    public class HomeViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Category> Categories { get; set; }
        public List<Feature> Features { get; set; }
        public List<Product> Products { get; set; }
        public List<Slide> Slides { get; set; }
    }
}