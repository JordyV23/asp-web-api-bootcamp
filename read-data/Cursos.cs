using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace read_data
{
    // Esta clase es la representación de la tabla 'Curso' de la base de datos
    // Diese Klasse ist die Darstellung der Tabelle 'Curso' in der Datenbank
    public class Cursos
    {
        public int CursosId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Precio TbPrecio { get; set; }
    }
}