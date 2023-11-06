using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace read_data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {
                // Utiliza AsNoTracking para no tener que hacer seguimiento de los cambios en la base de datos
                var cursos = db.TbCursos.Include(p=> p.TbPrecio).AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    Console.WriteLine(curso.TbPrecio.PrecioActual);
                }
            }
        }
    }
}
