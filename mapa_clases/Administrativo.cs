namespace Comunidad
{
    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}

