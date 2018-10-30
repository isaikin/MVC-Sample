using AutoMapper;
using Sgu.Entities;
using SGU.Epam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGU.Epam.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpGet]
		public ActionResult Registration()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Registration(UserCreateVM model)
		{	
	
			if(ModelState.IsValid)
			{

			}

			return View();
		}
	}
}