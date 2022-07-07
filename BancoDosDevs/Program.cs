using System;
using BancoDosDevs.Model;

namespace BancoDosDevs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Bando dos Dev´s");
            Console.WriteLine();
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            Console.WriteLine("3 - Conta Investimento");
            Console.WriteLine();
            
            Console.WriteLine("Insira uma opção: ");
            int optionChoosed = int.Parse(Console.ReadLine());
            
            Console.ReadKey();
        }

    }
}
