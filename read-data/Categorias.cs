using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace read_data
{
    public class Categorias
    {
        public int CategoriasId { get; set; }
        public string NombreCategoria { get; set; }
        public Cursos TbCursos { get; set; }
    }
}