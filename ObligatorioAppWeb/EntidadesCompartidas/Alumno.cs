using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EntidadesCompartidas
{
    public class Alumno
    {
        //atributos
        private int _Cedula;
        private string _Nombre;
        private string _Calle;
        private int _Num;
        private string _Barrio;


        //propiedades
        public int Cedula
        {
            set
            {
                if (value <= 10000000 && value >= 1000000)
                {
                    _Cedula = value;
                }else
                {
                    throw new Exception("cedula debe tener 8 digitos ");
                }
            }
            get { return _Cedula; }
        }

        public string Nombre
        {

            set
            {
                if (value.Trim().Length >= 3)
                    _Nombre = value;
                else
                    throw new Exception("Error_ debe tener  3 digitos ");
            }
            get { return _Nombre; }
        }

      

        public string Calle
        {
            set
            {
                if (value.Trim().Length >= 5)
                    _Calle = value;
                else
                    throw new Exception("Error_   5 digitos MINIMO la direccion ");
            }
            get { return _Calle; }
        }

        public int Num
        {
            set
            {
                if (value >= 1)
                    _Num = value;
                else
                    throw new Exception("Error_  no pudede ser negativo ");
            }
            get { return _Num; }
        }

        public string Barrio
        {
            set
            {
                if (value.Trim().Length >= 3)
                    _Barrio = value;
                else
                    throw new Exception("Error_   3 digitos MINIMO el Barrio ");
            }
            get { return _Barrio; }
        }

        //constructor completo
        public Alumno(int pCedula, string pNombre, string pCalle, int pNum, string pBarrio)
        {
            Cedula = pCedula;
            Nombre = pNombre;
            Calle = pCalle;
            Num = pNum;
            Barrio = pBarrio;
        }

        public override string ToString()
        {
            return (  "  " + Nombre );
        }
        //public bool Equals(Object obj)
        //{
        //    bool valido = false;
        //    if (obj is Alumno)
        //    {
        //        Alumno aux = (Alumno)obj;
        //        if (aux.Cedula == _Cedula)
        //        {
        //            valido = true;
        //        }
        //    }
        //    return valido;
        //}
    }
}
