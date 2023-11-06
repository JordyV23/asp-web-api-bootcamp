using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace read_data
{
    public class Precio
    {
        public int PrecioId { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public Cursos TbCursos {get;set;}
        public int CursosId { get; set; }
    }
}