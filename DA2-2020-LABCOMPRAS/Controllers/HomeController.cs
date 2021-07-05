using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2020_LABCOMPRAS.Controllers
{
    //Passo 2.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Entrada";

            return View();
        }

        //Passo 5.
        public IActionResult Conceito()
        {
            ViewData["Title"] = "Conceito";

            return View();
        }
    }
}
