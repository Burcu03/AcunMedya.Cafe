﻿using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
