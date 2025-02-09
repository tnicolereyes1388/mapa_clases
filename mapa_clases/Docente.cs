namespace Comunidad
{
    public class Docente : Empleado
    {
        public string Asignatura { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Asignatura: {Asignatura}");
        }
    }
}
