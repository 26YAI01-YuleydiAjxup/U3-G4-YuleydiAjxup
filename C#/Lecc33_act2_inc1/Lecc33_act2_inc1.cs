using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc33_act2_inc1
{
    internal class Lecc33_act2_inc1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            char[] caracteres = frase.ToCharArray();
            Array.Reverse(caracteres);
            string fraseInvertida = new string(caracteres);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Frase invertida: {fraseInvertida}");
        }
    }
}
