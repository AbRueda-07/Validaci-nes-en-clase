using EJERCICIO_EN_CLASE_6.Interface;

public class Chofer : IPiloto
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    private string _tipoLicencia;

    public string TipoLicencia
    {
        get => _tipoLicencia;
        set
        {
            // Validación de edad según tipo de licencia (Guatemala)
            switch (value.ToUpper())
            {
                case "M": // Motocicleta
                    if (Edad < 16)
                        throw new ArgumentException("Edad mínima para licencia M: 16 años");
                    break;
                case "A": // Livianos
                    if (Edad < 18)
                        throw new ArgumentException("Edad mínima para licencia A: 18 años");
                    break;
                case "B": // Pesados
                    if (Edad < 21)
                        throw new ArgumentException("Edad mínima para licencia B: 21 años");
                    break;
                case "C": // Transporte público
                    if (Edad < 23)
                        throw new ArgumentException("Edad mínima para licencia C: 23 años");
                    break;
                default:
                    throw new ArgumentException("Tipo de licencia no válido");
            }
            _tipoLicencia = value.ToUpper();
        }
    }

    public Chofer(string nombre, int laEdad, string licencia)
    {
        Nombre = nombre;
        Edad = laEdad;
        TipoLicencia = licencia; // Esto activará la validación
    }

    public void mostrarInformación()
    {
        Console.WriteLine($"El piloto es: {Nombre}");
        Console.WriteLine($"Licencia tipo: {TipoLicencia}");
        Console.WriteLine($"Edad: {Edad}");
    }
}