﻿using AcunMedya.Coffe.Context;
using AcunMedya.Coffe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribeController : Controller
    {



        private readonly CafeContext _context;

        public SubscribeController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Subscribes.ToList();
            return View(value);
        }
        public IActionResult AddSubscribes()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddSubscribes(Subscribe p)
        {
            _context.Subscribes.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DeleteSubscribes(int id)
        {
            var value = _context.Subscribes.Find(id);
            _context.Subscribes.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSubscribes(int id)
        {
            var value = _context.Subscribes.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSubscribes(Subscribe p)
        {
            _context.Subscribes.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}