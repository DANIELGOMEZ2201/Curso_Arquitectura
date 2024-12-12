using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnaVariables
{
    internal class Primitivas
    
      {
        private const string sTitulo = "Datos Personasles";
        public static int iCedula = 1223;
        private static string sNombre = "Martin";
        public static string sApellido = "Pescador";
        int _Edad = 67;
        const double dPeso = 52.3;
        public char cGenero = 'M';
        static void Main(string[] args)
        {
            Console.Write("\t\t\t" + sTitulo + "\t\t\t");
            Console.Write("\nIndentificacion: " + iCedula +
                "\nNombre: " + sNombre);

            //dPi=double.Parse(Console.ReadLine());
            //Console.Write(dPi);
            Console.ReadKey();
        }
    }
}
