using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVendas.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Camisa()
        {
            return View();
        }
        public IActionResult Relogio()
        {
            return View();
        }
        public IActionResult Whisky()
        {
            return View();
        }
    }
}
