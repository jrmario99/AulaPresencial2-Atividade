using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AtividadeAula2.Models;
using AtividadeAula2.DAL;

namespace AtividadeAula2.Controllers
{
    [Route("api/CasosCovid")]
    [ApiController]
    public class CasosAPIController : ControllerBase
    {

        private readonly Context _context;
        CasosDAL casosDAL = new CasosDAL();


        public CasosAPIController(Context context)
        {
            _context = context;
        }

        //GET : /api/CasosCovid/Listar
        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {

            List<Casos> casos = new List<Casos>();

            casos = casosDAL.listarCasos(_context);

            if (casos.Count == 0)
            {
    
                return BadRequest(new { msg = "Sem Casos Cadastrados" });
            
            }
            
            return Ok(casos);

        }

        //GET : /api/CasosCovid/Buscar/1
        [HttpGet]
        [Route("Buscar/{id}")]
        public IActionResult Buscar(int id)
        {

            Casos caso = new Casos();

            caso = casosDAL.BuscarPorId(id, _context);
                        
            if (caso.Equals(null))
            {
                return BadRequest(new { msg = "Caso não encontrado" });
            }
            return Ok(caso);

        }


        //POST : /api/CasosCovid/Cadastrar
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(Casos caso)
        {

            casosDAL.addCasos(caso, _context);
            return Created("", caso);

        }


        //DELETE : /api/CasosCovid/DeletarCaso/1
        [HttpDelete]
        [Route("DeletarCaso/{id}")]
        public IActionResult DeletarCaso(int id)
        {           

            var data = casosDAL.Delete(id, _context);

            if (data == false)
            {
                return BadRequest(new { msg = "Caso não encontrado" });
            }
            return Ok(new { msg = "Caso deletado com sucesso"});

        }



















    }
}
