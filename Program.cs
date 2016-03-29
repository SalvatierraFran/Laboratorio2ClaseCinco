using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio2Clase5_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Alumno UnAlumno = new Alumno(666);

            //UnAlumno.nombre = "Franco";
            //UnAlumno.legajo = 0;

            UnAlumno.Mostrar();

            Rueda UnaRueda = new Rueda();

            Console.Write(UnAlumno.GetLegajo());
            UnAlumno.SetNombre("FrancoFranco");

            Auto Auto1 = new Auto("Fiat");
            Auto Auto2 = new Auto("Fiat");
            Auto Auto3 = new Auto("Fiat");

            Alumno.MostrarAlumno(UnAlumno);

            Console.ReadKey();
        }
    }
}
