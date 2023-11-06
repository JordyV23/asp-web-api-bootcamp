using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace read_data
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Alumno { get; set; }
        public int Puntaje { get; set; }
        public string ComentarioTexto { get; set; }
        public int CursosId { get; set; }
        public Cursos TbCursos { get; set; }
    }
}