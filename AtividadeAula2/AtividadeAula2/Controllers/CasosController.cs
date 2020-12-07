using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AtividadeAula2.Models;
using AtividadeAula2.DAL;

namespace AtividadeAula2.Controllers
{
    public class CasosController : Controller
    {

        private readonly Context _context;
        CasosDAL casosDAL = new CasosDAL();


        public CasosController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Casos> casos = new List<Casos>();

            casos = casosDAL.listarCasos(_context);

            return View(casos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(Casos caso)
        {


            if (casosDAL.addCasos(caso, _context))
            {
                return RedirectToAction("Index");

            }
            else
            {

                return RedirectToAction("Cadastrar");
            }


        }

        public IActionResult Sobre()
        {
            return View();
        }




    }
}
