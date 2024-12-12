using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cnaProcesos
{
    public class OperBas
    {
        public static double iRes;
        private static int iNum1 = 0, iNum2 = 0;

        // Método Main corregido con cuerpo
        static void Main(string[] args)
        {
            OperBas operacion = new OperBas();
            operacion.OperBasicas();
        }

        // Método que realiza las operaciones básicas
        public void OperBasicas()
        {
            Console.WriteLine("\t\t\t Operaciones Matemáticas Básicas\t\t\t");
            Console.Write("Digite Num1: ");
            iNum1 = int.Parse(Console.ReadLine());
            Console.Write("Digite Num2: ");
            iNum2 = int.Parse(Console.ReadLine());

            // Suma
            Console.WriteLine("Suma");
            iRes = iNum1 + iNum2;
            Console.WriteLine(iNum1 + " + " + iNum2 + " = " + iRes);

            // Resta
            Console.WriteLine("Resta");
            iRes = iNum1 - iNum2;
            Console.WriteLine(iNum1 + " - " + iNum2 + " = " + iRes);

            // Multiplicación
            Console.WriteLine("Multiplicación");
            iRes = iNum1 * iNum2;
            Console.WriteLine(iNum1 + " * " + iNum2 + " = " + iRes);

            // Exponenciación
            Console.WriteLine("Exponenciación");
            iRes = Math.Pow(iNum1, iNum2);
            Console.WriteLine(iNum1 + " ^ " + iNum2 + " = " + iRes);

            // Valor absoluto
            Console.WriteLine("Valores Absolutos");
            iRes = Math.Abs(iNum1);
            Console.WriteLine("Valor Absoluto [" + iNum1 + "] = " + iRes);

            Console.ReadKey();
        }
    }
}
