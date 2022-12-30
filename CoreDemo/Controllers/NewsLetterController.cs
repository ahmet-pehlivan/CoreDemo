﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus=true;
			nm.AddNewsLetter(p);
			Response.Redirect("/Blog/BlogReadAll/"+1); //ajax ve jquery uygula
			return PartialView();
		}
	}
}
