using SistemaAlumno.Backend.Dominio.Entidades;
using SistemaAlumno.Backend.Infraestructura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumno.Backend.Infraestructura.Repositorios
{
    internal class AlumnoRepositorio : IAlumnoRepositorio
    {
        /// <summary>
        /// no es parte de la arquitectura
        /// </summary>
        public List<Alumno> AlumnoBD = new List<Alumno>();

        public AlumnoRepositorio()
        {
            AlumnoBD.Add(new Alumno()
            {
                Dni = 11,
                Apellido = "Diaz",
                Nombre = "Martin"

            });
            AlumnoBD.Add(new Alumno()
            {
                Dni = 22,
                Apellido = "lopez",
                Nombre = "diego"

            });
            AlumnoBD.Add(new Alumno()
            {
                Dni = 33,
                Apellido = "gomez",
                Nombre = "marcos"

            });

            AlumnoBD.Add(new Alumno()
            {
                Dni = 33,
                Apellido = "gomez",
                Nombre = "pedro"

            });

            AlumnoBD.Add(new Alumno()
            {
                Dni = 33,
                Apellido = "gomez",
                Nombre = "pablo"

            });
        }

        /// <summary>
        /// no es parte de la arquitectura
        /// </summary>

        public void Agregar(Alumno alumno)
        {
            AlumnoBD.Add(alumno);
        }

        // public (Nivel de acceso) ; void (Dato y tipo de SALIDA) ;  ObtenerTodos (Nombre del metodo) ; (Alumno alumno) = DAto y tipo de ENTRADA
        // public (Nivel de acceso) ; int (Dato y tipo de SALIDA) ;  ObtenerTodos (Nombre del metodo) ; (Alumno alumno) = DAto y tipo de ENTRADA
        // public (Nivel de acceso) ; List<Alumno> (Dato y tipo de SALIDA) ;  ObtenerTodos (Nombre del metodo) ; (Alumno alumno) = DAto y tipo de ENTRADA

        public List<Alumno> ObtenerTodos() 
        {
            return AlumnoBD;
        }

        public Alumno BuscarPorDni(int dni) 
        {
            //// la lista es = AlumnoBD
            //for (int i = 0; i < AlumnoBD.Count; i++)
            //{ 
            //    //AlumnoBD[i]
            //    if (AlumnoBD[i].Dni == dni)
            //    {
            //        return AlumnoBD[i];
            //    }
            //}

            //return null;

            return AlumnoBD.Where(a => a.Dni == dni).FirstOrDefault();
        }

        public List<Alumno> BuscarPorApellido(string apellido)
        {
            //List<Alumno> listaNueva = new List<Alumno>();
            //for (int i = 0; i < AlumnoBD.Count; i++)
            //{
            //    if (AlumnoBD[i].Apellido == apellido)
            //    {
            //        listaNueva.Add(AlumnoBD[i]);
            //    }
            //}
            //return listaNueva;

            return AlumnoBD.Where(x => x.Apellido == apellido).ToList();
        }
    }
}
