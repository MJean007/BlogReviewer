using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogEngine.Models;
namespace BlogReviewer.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public void Add(BlogEngine.Models.category model)
        {
            BlogDBContext context = new BlogDBContext();
            category cat = new category();
            cat.title = model.title;
            if (context != null)
            {
                context.Categories.Add(cat);
                context.SaveChanges();
            }
            
        }

    }
}