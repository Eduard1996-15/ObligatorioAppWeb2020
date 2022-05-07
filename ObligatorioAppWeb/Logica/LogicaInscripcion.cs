using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using Persistencia;

namespace Logica
{
    public class LogicaInscripcion
    {
        public static List<Inscripcion> ListarPorAlumno(Alumno unA)
        {
            return (PersistenciaInscripcion.ListarPorAlumno(unA));
        }
        public static void AgregarInscripcion(Inscripcion nInscripcion)
        {
            PersistenciaInscripcion.AgregarInscripcion(nInscripcion);
        }


        public static List<Inscripcion> ListarInscripcionXCurso(string  IDE)
        {
            return PersistenciaInscripcion.ListarInscripcionXCurso(IDE);
        }
    }
}
