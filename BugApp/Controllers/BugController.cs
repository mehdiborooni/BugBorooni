using BugApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugApp.Controllers
{
    public class BugController:Controller
    {
        public IActionResult Index()
        {
            var model = new List<Bug>
            {
                new Bug{Id= 1, Name = "ali"},
                new Bug{Id= 2, Name = "reza"},
                new Bug{Id= 3, Name = "ahmad"},
                new Bug{Id= 4, Name = "mehdi"},
                new Bug{Id= 5, Name = "hamid"},
                new Bug{Id= 6, Name = "hasan"},
                new Bug{Id= 7, Name = "nader"},
                new Bug{Id= 8, Name = "vahid"},
                new Bug{Id= 9, Name = "mohsen"},
            };
            return View(model);
        }

    }
}
