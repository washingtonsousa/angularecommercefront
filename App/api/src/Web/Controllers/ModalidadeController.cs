﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class ModalidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}