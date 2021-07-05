using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2020_LABCOMPRAS.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Index";
            return View();
        }

        public IActionResult NovaDespesas()
        {
            ViewData["Title"] = "NovaDespesas";
            return View();
        }
    }
}
