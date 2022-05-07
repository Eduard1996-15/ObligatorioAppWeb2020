using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Inscripcion
    {
        //atributos 

        private int _NumInscripcion;
        private string _IdeCurso;
        private int _CedulaAlumno;
        private DateTime _Fecha;
        private string _Empleado;
        //Propiedades

        public string Empleado
        {
            get { return _Empleado; }
            set
            {
                if (value.Trim().Length >= 3)
                    _Empleado = value;
                else
                    throw new Exception("Error nombre debe se mayor a 3 digitos ");
            }


        }
        public int CedulaAlumno
        {
            set
            {
                if (value <= 10000000 && value >= 1000000)
                {
                    _CedulaAlumno = value;
                }
                else
                {
                    throw new Exception("cedula debe tener 8 digitos ");
                }
            }
            get { return _CedulaAlumno; }
        }

        public string IDE
        {
            set
            {
                if (value.Trim().Length == 6)
                    _IdeCurso = value;
                else
                    throw new Exception("Error IDE-debe tener 6 caracteres ");
            }
            get { return _IdeCurso; }
        }

        public int NumInscripcion
        {
            set
            {
                _NumInscripcion = value;
            }
            get { return _NumInscripcion; }
        }

        public DateTime Fecha
        {
            set
            {
                //esta menos o igual porque los datos de prueba de base no pueden ser actuales --cambiar el menor igual "<=" a igual "="
                if (value <= DateTime.Now )
                    _Fecha = value;
                else
                {
                    throw new Exception("Error - debe ser la fecha actual");
                }


            }
            get { return _Fecha; }
        }

        //constructor

        public Inscripcion(  int pIns , int pCedula,  DateTime pDate, string pEmpleado, string pIdeCurso)
        {
          
            NumInscripcion = pIns;
            CedulaAlumno = pCedula;
            Fecha = pDate;
            Empleado = pEmpleado;
            IDE = pIdeCurso;
        }

        public   override string ToString()
        {
            return ("  " + IDE);
        }
    }
}
