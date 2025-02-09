namespace Comunidad
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }
}
