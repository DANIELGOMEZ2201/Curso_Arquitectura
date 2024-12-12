using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaExtendido
{
    internal class Program


    {
        public static string[] sCabecera = { "id", "nombres", "apellido", "genero", "eda", "FecNac" };

        static void Main(string[] args)

        {
            Console.WriteLine("Iteracion para Natural");
            for (int i = 0 < sCabecera.Length; i++)
            {
                Console.WriteLine("\nsCabecera[" + i + "]=" + sCabecera[i]);


            }
            {
                Console.WriteLine("\n\nIteracion para extendido");
                int nCont = 0;
                foreach (string sVector in sCabecera) ;

                {
                    Console.WriteLine("\n\nPos[" + nCont + "] = " + sVector);
                    nCont++



            }

            }
        }
    }
}

        
    

