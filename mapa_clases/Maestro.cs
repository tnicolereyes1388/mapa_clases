namespace Comunidad
{
    public class Maestro : Docente
    {
        public string Grado { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Grado que enseña: {Grado}");
        }
    }
}
