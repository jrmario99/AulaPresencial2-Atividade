using AtividadeAula2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeAula2.DAL
{
    public class CasosDAL
    {

        public Boolean addCasos(Casos p, Context _context)
        {
            _context.Add(p);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Casos> listarCasos(Context _context)
        {
            List<Casos> casos = new List<Casos>();

            casos = _context.Casos.ToList();

            if (casos.Count == 0)
            {

                return null;
            }


            return casos;

        }



    }
}
