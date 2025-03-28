public class CarroToyota : Vehiculo
{
    public CarroToyota(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        CapacidadTanque = 55; // 55 galones
        ConsumoCombustible = 15; // 15 km/galón
        VelocidadMaxima = 200; // 200 km/h
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Carro Toyota: Modelo {Modelo}, Año {Year}, Color {Color}");
        InformacionVehiculo();
    }

    public void VerificarLicencia(string tipoLicencia)
    {
        if (tipoLicencia == "B")
        {
            Console.WriteLine("Licencia válida. Puede conducir el carro Toyota.");
        }
        else
        {
            Console.WriteLine("Licencia no válida. Se requiere licencia tipo B para conducir este carro Toyota.");
        }
    }
}