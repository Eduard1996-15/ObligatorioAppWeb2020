using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Telefono
    {
        private int _telefono;
      
        //propiedades 
        public int NumeroTelefono
        {
            get { return _telefono; }
            set { if (value <= 100000000 && value >= 10000000)
                    _telefono = value;
                else
                    throw new Exception("error debe tener 8 o 9  digitos telefono");
            }
        }
        //constructor 
        public Telefono ( int pnumtel)
        {
            NumeroTelefono = pnumtel;
        }


    }
}
