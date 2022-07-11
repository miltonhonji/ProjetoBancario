using System;
using BancoDosDevs.Model;
using BancoDosDevs.Business;

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

            switch (optionChoosed)
            {
                case 1: CurrentAccountOptions(); break;
            }
                 
            Console.ReadKey();
        }

        public static void CurrentAccountOptions()
        {
            Business.CurrentAccountRepository currentAccountRepository = new Business.CurrentAccountRepository();
            
            Console.Clear();
            Console.WriteLine("**** Banco dos Dev's - Conta Corrente ****");
            Console.WriteLine();

            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Fazer Seguro");
            Console.WriteLine("3 - Obter Extrato");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Transferir");
            Console.WriteLine("6 - Menu");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("Escolha uma opção: ");
            int currentAccountOption = int.Parse(Console.ReadLine());

            switch (currentAccountOption)
            {
                case 1: currentAccountRepository.DepositOperation(); break;
                default: System.Environment.Exit(1); break;
            }
                    
            Console.ReadKey();
        }
    }
}
