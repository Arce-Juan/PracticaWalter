using SistemaAlumno.Backend.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumno.Backend.Infraestructura.Repositorios.Interfaces
{
    internal interface IAlumnoRepositorio
    {
        void Agregar(Alumno alumno);
        void ObtenerTodos(List<Alumno> alumno);

    }
}
