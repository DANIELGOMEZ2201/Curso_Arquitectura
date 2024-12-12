using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palabra a adivinar
            string palabra = "programacion";
            // Convertir palabra en un array de caracteres para mostrar el progreso
            char[] progreso = new char[palabra.Length];

            // Inicializar el progreso con guiones bajos
            for (int i = 0; i < palabra.Length; i++)
            {
                progreso[i] = ' _ ';
            }

            int intentos = 6;  // Intentos permitidos
            bool juegoTerminado = false;  // Estado del juego

            // Representación del ahorcado en diferentes etapas
            string[] ahorcado = new string[]
            {
            @"
   ------
   |    |
        |
        |
        |
        |
   ======
            ",
            @"
   ------
   |    |
   O    |
        |
        |
        |
   ======
            ",
            @"
   ------
   |    |
   O    |
   |    |
        |
        |
   ======
            ",
            @"
   ------
   |    |
   O    |
  /|    |
        |
        |
   ======
            ",
            @"
   ------
   |    |
   O    |
  /|    |
  /     |
        |
   ======
            ",
            @"
   ------
   |    |
   O    |
  /|    |
  / \   |
        |
   ======
            "
            };

            // mi estructura de control
            while (intentos > 0 && !juegoTer--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------minado)
            {
                Console.Clear();
                Console.WriteLine("Palabra: " + new string(progreso));
                Console.WriteLine("Intentos restantes: " + intentos);

                Console.WriteLine(ahorcado[6 - intentos]);
                Console.Write("Ingresa una letra: ");
                char letra = Console.ReadLine()[0];

                bool acierto = false;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        progreso[i] = letra;
                        acierto = true;
                    }
                }

                if (!acierto)
                {
                    intentos--;
                    Console.WriteLine("Letra incorrecta.");
                }
                else
                {
                    Console.WriteLine("¡Letra correcta!");
                }


                juegoTerminado = true;
                for (int i = 0; i < progreso.Length; i++)
                {
                    if (progreso[i] == '_')
                    {
                        juegoTerminado = false;
                        break;
                    }
                }
            }

            Console.Clear();
            if (juegoTerminado)
            {
                Console.WriteLine("¡Felicidades, ganaste! La palabra era: " + palabra);
            }
            else
            {
                Console.WriteLine(ahorcado[6 - intentos]); // Mostrar el dibujo completo al perder
                Console.WriteLine("Has perdido. La palabra era: " + palabra);
            }
            Console.ReadKey();
        }

    }
}