﻿using Microsoft.AspNetCore.Mvc;

namespace OA.WEB.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
