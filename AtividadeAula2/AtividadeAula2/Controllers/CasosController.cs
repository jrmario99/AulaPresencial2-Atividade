using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeAula2.Controllers
{
    public class CasosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
