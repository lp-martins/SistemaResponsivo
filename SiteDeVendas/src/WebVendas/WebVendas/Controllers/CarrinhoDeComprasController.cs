﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVendas.Controllers
{
    public class CarrinhoDeComprasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
