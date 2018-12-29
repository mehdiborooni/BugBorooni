using BugApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BugApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BugApp.Controllers
{
    public class BugController:Controller
    {
        private readonly BugDbContext _db;

        public BugController(BugDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var model = _db.Bugs;

            //var model = new List<Bug>
            //{
            //    new Bug{Id= 1, Name = "ali"},
            //    new Bug{Id= 2, Name = "reza"},
            //    new Bug{Id= 3, Name = "ahmad"},
            //    new Bug{Id= 4, Name = "mehdi"},
            //    new Bug{Id= 5, Name = "hamid"},
            //    new Bug{Id= 6, Name = "hasan"},
            //    new Bug{Id= 7, Name = "nader"},
            //    new Bug{Id= 8, Name = "vahid"},
            //    new Bug{Id= 9, Name = "mohsen"},
            //};
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bug model)
        {
            _db.Bugs.Add(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var model = _db.Bugs.Find(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _db.Bugs.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Bug model)
        {
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _db.Bugs.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Bug model)
        {
            _db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
