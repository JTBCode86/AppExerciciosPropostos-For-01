using System;

namespace AppExerciciosPropostos_For__01
{
    /// <summary>
    /// Exercícios sobre Estrutura Repetitiva FOR
    /// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
    /// </summary>
    class Program
    {
        public static void validarParImpar(int x) 
        {
            for (int i = x; i <= x && i != 0; i--)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número qualquer: ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Lista de números impares:");
            validarParImpar(x);
            Console.ReadLine();
        }
    }
}
