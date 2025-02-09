namespace Comunidad
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public string AñoGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }
}
