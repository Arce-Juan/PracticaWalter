using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumno.Backend.Dominio.Entidades
{
    internal class Curso
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}
