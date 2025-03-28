public class Camioneta : Vehiculo
{
    public Camioneta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        CapacidadTanque = 70; // 70 galones
        ConsumoCombustible = 8; // 8 km/galón
        VelocidadMaxima = 150; // 150 km/h
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Camioneta: Modelo {Modelo}, Año {Year}, Color {Color}");
        InformacionVehiculo();
    }

    public void VerificarLicencia(string tipoLicencia)
    {
        if (tipoLicencia == "A")
        {
            Console.WriteLine("Licencia válida. Puede conducir la camioneta.");
        }
        else
        {
            Console.WriteLine("Licencia no válida. Se requiere licencia tipo A para conducir esta camioneta.");
        }
    }
}