using System;

namespace Comunidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrador admin = new Administrador
            {
                Nombre = "Carlos Pérez",
                Edad = 45,
                Puesto = "Director",
                Asignatura = "Matemáticas",
                CargoAdministrativo = "Jefe de Estudios"
            };

            Estudiante estudiante = new Estudiante
            {
                Nombre = "Ana López",
                Edad = 20,
                Carrera = "Ingeniería"
            };

            admin.MostrarInformacion();
            Console.WriteLine(); 
            estudiante.MostrarInformacion();
        }
    }
}
