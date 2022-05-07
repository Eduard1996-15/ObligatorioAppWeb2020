using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using Persistencia;

namespace Logica
{
    public class LogicaAlumno
    {
        public static void EliminarTel(int numero)
        {
            PersistenciaAlumno.EliminarTel(numero);
        }
        public static void AgregarAlumno(Alumno nAlumno)
        {
            PersistenciaAlumno.AgregarAlumno(nAlumno);
        }
        public static void AgregarTelefono(int ci, Telefono unT)
        {
            PersistenciaAlumno.AgregarTelefono(ci, unT);
        }
        public static void Eliminar(Alumno nAlumno)
        {
            PersistenciaAlumno.Eliminar(nAlumno);
        }

        public static void Editar(Alumno unA)
        {
            PersistenciaAlumno.Editar(unA);
        }
       

        public static Alumno Buscar(int pCedula)
        {
           return ( PersistenciaAlumno.Buscar(pCedula));
        }
        public static List<Alumno> ListarAlumnos()
        {
            return PersistenciaAlumno.ListarAlumnos();
        }
        public static List<Telefono> ListarTelefono(int cedula)
        {
            return PersistenciaAlumno.ListarTelefono(cedula);
        }
    }
}
