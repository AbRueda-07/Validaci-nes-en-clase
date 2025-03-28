public class Vehiculo
{
    // Propiedades
    public string Color { get; set; }
    public string Modelo { get; }
    public int Year { get; }

    // Campos protegidos
    protected int CapacidadTanque { get; set; } = 50; // Valor por defecto (galones)
    protected int ConsumoCombustible { get; set; } = 10; // Valor por defecto (km/galón)
    protected int VelocidadMaxima { get; set; } = 120; // Valor por defecto (km/h)

    private int velocidad = 0; // Corregido: nombre de variable consistente (antes Velocidad/Velocidad)
    private Chofer piloto = null;
    private int estadoVehiculo = 0; // 0=apagado, 1=encendido, 2=en movimiento

    protected List<string> tipoLicenciaAceptados = new List<string> { "A", "B", "C" };

    public Vehiculo(int anio, string elColor, string elModelo)
    {
        this.Color = elColor;
        this.Modelo = elModelo;
        this.Year = anio;
    }

    // Método Frenar
    public void Frenar(int cuanto)
    {
        if (estadoVehiculo == 2) // Si está en movimiento
        {
            velocidad = Math.Max(0, velocidad - cuanto);
            Console.WriteLine($"Frenando... Velocidad actual: {velocidad} km/h");

            if (velocidad == 0)
            {
                estadoVehiculo = 1; // Cambia a encendido
                Console.WriteLine("Vehículo detenido");
            }
        }
        else
        {
            Console.WriteLine("El vehículo no está en movimiento.");
        }
    }

    // Método Apagar modificado
    public string Apagar()
    {
        if (velocidad > 0)
            return "No se puede apagar el vehículo en movimiento.";

        if (estadoVehiculo == 1)
        {
            estadoVehiculo = 0;
            return "Vehículo apagado.";
        }
        return "El vehículo ya está apagado.";
    }

    // Método Acelerar modificado
    public virtual void Acelerar(int cuanto)
    {
        if (estadoVehiculo == 0)
        {
            Console.WriteLine("No se puede acelerar con el vehículo apagado.");
            return;
        }

        if (estadoVehiculo == 1 || estadoVehiculo == 2)
        {
            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
                velocidad = VelocidadMaxima;
            }
            else
            {
                velocidad += cuanto;
            }

            estadoVehiculo = 2; // Cambia a en movimiento
            Console.WriteLine($"Vas a {velocidad} km/h.");
        }
    }

    // Método Encender
    public string Encender()
    {
        if (piloto == null)
        {
            return "No se puede encender el vehículo sin piloto.";
        }
        if (estadoVehiculo == 0) // Si el vehículo está apagado
        {
            estadoVehiculo = 1; // Cambia el estado a encendido
            return "Vehículo encendido.";
        }
        return "El vehículo ya está encendido.";
    }

    // Método AsignarPiloto
    public string AsignarPiloto(Chofer elPiloto)
    {
        if (elPiloto == null)
        {
            return "No se puede asignar un piloto nulo.";
        }
        if (!tipoLicenciaAceptados.Contains(elPiloto.TipoLicencia))
        {
            return "El piloto no tiene el tipo de licencia adecuada para este vehículo.";
        }
        if (piloto != null)
        {
            return "Ya tiene un piloto asignado.";
        }
        piloto = elPiloto;
        return "Piloto asignado exitosamente.";
    }

    // Método InformacionVehiculo mejorado
    public void InformacionVehiculo()
    {
        Console.WriteLine("=== INFORMACIÓN DEL VEHÍCULO ===");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Año: {Year}");
        Console.WriteLine($"Velocidad actual: {velocidad} km/h");
        Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");
        Console.WriteLine($"Capacidad de tanque: {CapacidadTanque} galones");
        Console.WriteLine($"Consumo: {ConsumoCombustible} km/galón");

        string estado = estadoVehiculo switch
        {
            0 => "Apagado",
            1 => "Encendido",
            2 => "En movimiento",
            _ => "Desconocido"
        };
        Console.WriteLine($"Estado: {estado}");

        if (piloto != null)
            Console.WriteLine($"Piloto asignado: {piloto.Nombre} (Licencia: {piloto.TipoLicencia})");
        else
            Console.WriteLine("No hay piloto asignado.");
    }
}