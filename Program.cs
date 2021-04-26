using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--Divisão--");
            Console.ResetColor();
            Console.WriteLine();

            double numerador;
            double denominador;
            double resultado; 

            Console.WriteLine("Vamos calcular a sua divisão!");
            Console.WriteLine();
            Console.Write("Digite o numerador....: ");
            numerador = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o denominador..: ");
            denominador = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            resultado = numerador/denominador;

            if (denominador ==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível dividir por zero.");
                Console.ResetColor();
            }
            
            else
            {
               Console.Write($"{numerador} dividido por {denominador} é...: {resultado}");
               Console.WriteLine();
            }
             Console.WriteLine();
        }
    }
}
