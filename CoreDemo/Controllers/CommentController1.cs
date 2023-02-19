using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class CommentController1 : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			//var jsonComments = JsonConvert.SerializeObject(p);
			//return Json(jsonComments);
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 2;
			cm.CommentAdd(p);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
