using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class CursoEspecializado : Curso
    {
        //atributos 
        private string _PreRequisito;

        //propiedades 
        public string PreRequisitos
        {
            set
            {
                if (value.Trim().Length >= 3)
                    _PreRequisito = value;
                else
                    _PreRequisito = "Sin Prerrequisistos";
            }
            get { return _PreRequisito; }
        }

        //constructor 
        public CursoEspecializado(string pIDE, string pNomber, byte pDuracion, int pPrecio, string pPreRequisitos)
            : base(pIDE, pNomber, pDuracion, pPrecio)
        {
            PreRequisitos = pPreRequisitos;
        }

    }
}
