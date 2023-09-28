using System;

namespace ConsoleApp_12E_2023C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            p.DNI = 12345678;
            p.Nombre = "Alejandro";
            p.Apellido = "Fernandez";

            Console.WriteLine(p.MostrarDatos());
            Console.ReadKey();


            Alumno a = new Alumno();
            a.DNI = 9876543;
            a.Nombre = "Alejandra";
            a.Apellido = "MArtinez";
            a.NroLegajo = 334455;
            a.Materia = "PNT1";

            Console.WriteLine(a.MostrarDatos());
            Console.ReadKey();

        }
    }
}
