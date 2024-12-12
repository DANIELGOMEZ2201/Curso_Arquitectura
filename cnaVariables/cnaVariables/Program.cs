    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnaVariables
{
    internal class Program
    {
        private const string sTitulo = "Datos Personales";
        public static int iCedula;
        private static string sNombre;
        public static string sApellido;
        private static int _Edad;
        public static double dPeso;
        public char cGenero;
        private static string dFecnac;

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t" + sTitulo + "\t\t\t");
            Console.Write("\nDigite Cedula: ");
            iCedula = int.Parse(Console.ReadLine());
            Console.Write("\nDigite Nombre: ");
            sNombre = Console.ReadLine();
            Console.WriteLine("\nCedula: " + iCedula +
                "\nNombre: " + sNombre);
            Console.ReadKey();
        }
    }
}
