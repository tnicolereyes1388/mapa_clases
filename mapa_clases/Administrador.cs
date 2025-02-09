namespace Comunidad
{
    public class Administrador : Docente
    {
        public string CargoAdministrativo { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cargo Administrativo: {CargoAdministrativo}");
        }
    }
}
