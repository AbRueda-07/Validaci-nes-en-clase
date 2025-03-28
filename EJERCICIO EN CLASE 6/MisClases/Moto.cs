public class Moto : Vehiculo
{
    private int velocidadAnterior = 0;

    public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        // ... (igual que antes)
    }

    public override void Acelerar(int cuanto)
    {
        base.Acelerar(cuanto);
        velocidadAnterior = GetVelocidadEstimada();
    }

    public void HacerCaballito()
    {
        if (velocidadAnterior > 50)
        {
            Console.WriteLine("¡Realizando caballito!");
        }
        else
        {
            Console.WriteLine("No se puede hacer caballito. Se necesita >50 km/h");
        }
    }

    private int GetVelocidadEstimada()
    {
        // Lógica para estimar velocidad basada en aceleraciones/frenadas
        return velocidadAnterior;
    }
}