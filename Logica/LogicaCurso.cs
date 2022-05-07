using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using Persistencia;


namespace Logica
{
    public class LogicaCurso
    {
        public static CursoEspecializado BuscarCurso(string Ide)
        {
            return (PersistenciaCurso.BuscarCurso(Ide));
        }
        public static CursoEspecializado BuscarCursoEsp(string Ide)
        {
            return (PersistenciaCurso.BuscarCursoEsp(Ide));
        }
        public static CursoCorto BuscarCursoCorto(string Ide)
        {
            return (PersistenciaCurso.BuscarCursoCorto(Ide));
        }
        public static void AgregarCursoCorto(CursoCorto nCursoCorto)
        {
             PersistenciaCurso.AgregarCursoCorto(nCursoCorto);
        }

        public static void  AgregarCursoEspecializado(CursoEspecializado nCursoEsp)
        {
             PersistenciaCurso.AgregarCursoEspecializado(nCursoEsp);
        }
            public static List<CursoCorto> listarCursoCorto()
            {
                  
                return PersistenciaCurso.listarCursoCorto();
            }

        public static List<CursoEspecializado> ListarCursoEspecializado()
        {
            return PersistenciaCurso.ListarCursoEspecializado();
        }
    }
}
