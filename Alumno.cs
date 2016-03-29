using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio2Clase5_01
{
    class Alumno
    {
        //Puedo tener infinitos de objetos y, todos van a respetar una misma estructura y comportamiento.

        private string nombre;
        private int legajo;

        public void Mostrar()
        {
            Console.Write(this.nombre);
            Console.Write("\n" + this.legajo);
        }

        private bool Compararme(Alumno UnAlumno)
        {
            bool respuesta = false;
            if (this.nombre == UnAlumno.nombre && this.legajo == UnAlumno.legajo)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public Alumno(int legajo)
        {
            this.nombre = "FranFran";
            this.legajo = legajo;
        }

        public int GetLegajo()
        {
            return this.legajo;
        }

        public void SetNombre(string AuxNombre)
        {
            this.nombre = AuxNombre;
        }

        public static bool CompararDosAlumnos(Alumno AlumnoUno, Alumno AlumnoDos)
        {
            bool respuesta = false;

            if (AlumnoUno.nombre == AlumnoDos.nombre && AlumnoUno.legajo == AlumnoDos.legajo)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static void MostrarAlumno(Alumno AlumnoAux)
        {
            Console.Write("\n" + AlumnoAux.nombre); 
        }
    }
}
