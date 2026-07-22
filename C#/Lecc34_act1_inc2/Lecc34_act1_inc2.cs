using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecc34_act1_inc2
{
    internal class Lecc34_act1_inc2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su peso en kilogramos (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Su Indice de Masa Corporal (IMC) es: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Clasificacion: Bajo peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Clasificacion: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Clasificacion: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Clasificacion: Obesidad");
            }
        }
    }
}
