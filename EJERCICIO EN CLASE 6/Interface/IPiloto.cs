using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_EN_CLASE_6.Interface
{
    public interface IPiloto
    {
        string Nombre { get; set; }//get, set sirven para obtener y modificar el valor de la variable.
        int Edad { get; set; }
        string TipoLicencia { get; set; }//estos son los tipos de licencia : a,b,c,m.

        void mostrarInformación();




    }
}
