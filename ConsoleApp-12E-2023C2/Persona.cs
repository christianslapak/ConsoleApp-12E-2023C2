using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_12E_2023C2
{
    class Persona
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }


        public string MostrarDatos() {
            string salida;
            salida = "Datos: " + DNI + " " + Apellido + " " + Nombre;
            return salida;
        }
    }
}
