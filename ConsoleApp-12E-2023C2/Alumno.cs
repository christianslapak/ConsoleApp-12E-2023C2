using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_12E_2023C2
{
    class Alumno:Persona
    {
        public int NroLegajo { get; set; }

        public string Materia { get; set; }


        public new string MostrarDatos()
        {
            string salida;
            salida = base.MostrarDatos() + " " + NroLegajo + " " + Materia;
            return salida;
        }
    }
}
