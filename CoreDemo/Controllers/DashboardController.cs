﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    //BlogManager bm = new BlogManager(new EfBlogRepository());
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c= new Context();
            var username = User.Identity.Name;  //sisteme name uzerinden giris yapildigi icin identity sadece name veriyor
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid=c.Writers.Where(x => x.WriterMail== usermail).Select(y => y.WriterID).FirstOrDefault();

            ViewBag.v1=c.Blogs.Count().ToString();
            ViewBag.v2=c.Blogs.Where(x=>x.WriterID==writerid).Count();
            ViewBag.v3=c.Categories.Count().ToString();
            return View();
        }
    }
}
