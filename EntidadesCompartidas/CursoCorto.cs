using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class CursoCorto : Curso
    {
        //atributos
        private string _AreaAplicacion;

        //Propiedades

        public string AreaAplicacion
        {
            set
            { if (value.Trim().Length >= 1)
                    _AreaAplicacion = value;
                else
                    throw new Exception("debe elejir una de las areas ");
            }
            get { return _AreaAplicacion; }
        }
        //Contructor por defecto

        //constructor 
        public CursoCorto(string pIDE, string pNomber, byte pDuracion, int pPrecio, string pAreaAplicacon)
            : base(pIDE, pNomber, pDuracion, pPrecio)
        {
            AreaAplicacion = pAreaAplicacon;
        }

    }
}
