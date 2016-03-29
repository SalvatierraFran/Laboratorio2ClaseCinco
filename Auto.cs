using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio2Clase5_01
{
    class Auto
    {
        public Rueda RuedaUno;
        public Rueda RuedaDos;
        public Rueda RuedaTres;
        public Rueda RuedaCuatro;

        private string _Marca;
        public static string fecha;

        static Auto()
        {
            Auto.fecha = (new DateTime()).ToString();
        }

        public Auto(string Marca)
        {
            this._Marca = Marca;
        }
    }
}
