using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnaProcesos
{
    internal class EstSelSi
{
    public static int nCod = 2356;
    private static char cGen = 'f';
    public static string sColor = "negro";
    static void Main(string[] args)
    {
        Console.WriteLine("Estructura Si Simple");
        if (nCod == 2356)
        {
            Console.WriteLine("Acceso Concedido");
        }

        Console.WriteLine("Estructura Si Compuesta");
        if (cGen == 'F' || cGen == 'f')
        {
            Console.WriteLine("Poder Femenino");
        }
        else
        {
            Console.WriteLine("Hombre");
        }


        Console.WriteLine("Estructura Si Anidada");
        if (sColor == "BLANCO" || sColor == "Blanco" || sColor == "blanco")
        {
            Console.WriteLine("Mañana");
        }
        else if (sColor == "AMARILLO" || sColor == "Amarillo" || sColor == "amarillo")
        {
            Console.WriteLine("1/2 dia");
        }
        else if (sColor == "NARANJA" || sColor == "Naranja" || sColor == "naranja")
        {
            Console.WriteLine("Tarde");
        }

        Console.WriteLine("Estructura Si Horizontal");
        if (sColor == "NEGRO" || sColor == "Negro" || sColor == "negro") Console.WriteLine("Noche"); else Console.WriteLine("Madrugada");


        Console.ReadKey();

    }
}
}
