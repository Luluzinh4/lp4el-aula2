using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;

            Console.WriteLine("Calculadora de Inteiro\n");

            Console.Write("Digite o primeiro valor: ");
            String num1 = Console.ReadLine();
            Console.Write("Digite o segundo valor: ");
            String num2 = Console.ReadLine();
            numero1 = Int32.Parse(num1);
            numero2 = Int32.Parse(num2);

            Console.WriteLine("\nOperações realizadas com sucesso!\n");

            resultado = numero1 + numero2;
            Console.WriteLine("Soma -> " + numero1 + " + " + numero2 + " = " + resultado);

            resultado = numero1 - numero2;
            Console.WriteLine("Subtração -> " + numero1 + " - " + numero2 + " = " + resultado);

            resultado = 0;
            for(int i = 0; i < numero1; i++)
            {
                resultado += numero2;
            }
            Console.WriteLine("Multiplicação -> " + numero1 + " * " + numero2 + " = " + resultado);

            resultado = 0;
            int auxiliar = numero1;
            while(auxiliar > numero2)
            {
                resultado += 1;
                auxiliar -= numero2;
            }
            Console.WriteLine("Divisão -> " + numero1 + " / " + numero2 + " = " + resultado);

            Console.ReadKey();
        }
    }
}
