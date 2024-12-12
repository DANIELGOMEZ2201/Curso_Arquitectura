using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnaProcesos
{
    internal class EstSelSw
    {
        public static string sColor;
        static void Main(string[] args)
        {
            Console.Write("\nDigite Color: ");
            sColor = Console.ReadLine();
            switch (sColor)
            {
                case "Blanco":
                case "BLANCO":
                case "blanco":
                    Console.WriteLine("Mañana");
                    break;
                case "Amarillo":
                case "AMARILLO":
                case "amarillo":
                    Console.WriteLine("1/2 dia");
                    break;
                case "Naranja":
                case "NARANJA":
                case "naranja":
                    Console.WriteLine("Tarde");
                    break;
                default:
                    Console.WriteLine("Otra Jornada");
                    break;


            }
            Console.ReadKey();
        }

    }
}

