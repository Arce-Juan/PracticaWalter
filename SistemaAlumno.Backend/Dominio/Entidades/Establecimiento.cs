using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumno.Backend.Dominio.Entidades
{
    internal class Establecimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}
