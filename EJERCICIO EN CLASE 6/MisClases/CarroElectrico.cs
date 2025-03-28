using System;

namespace EJERCICIO_EN_CLASE_6.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        // Campo privado para el nivel de carga de la batería
        private int cargaBateria;

        // Constructor que llama al constructor de la clase base (Vehiculo)
        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50; // Inicializa la carga de la batería en 50%
        }

        // Método para obtener el nivel de carga de la batería
        public int NivelBateria()
        {
            return cargaBateria;
        }

        // Método para cargar la batería
        public void CargarBateria()
        {
            if (cargaBateria < 100) // Asegura que la batería no se cargue más del 100%
            {
                cargaBateria++;
                Console.WriteLine("Batería cargada al {0}%.", cargaBateria);
            }
            else
            {
                Console.WriteLine("La batería ya está completamente cargada.");
            }
        }

        // Sobrescribe el método Acelerar de la clase base
        public override void Acelerar(int cuanto)
        {
            if (cargaBateria > 0) // Verifica que haya carga en la batería
            {
                base.Acelerar(cuanto); // Llama al método Acelerar de la clase base
                cargaBateria--; // Reduce la carga de la batería
                Console.WriteLine("Batería restante: {0}%", cargaBateria);
            }
            else
            {
                Console.WriteLine("No hay suficiente carga en la batería para acelerar.");
            }
        }

    }
}