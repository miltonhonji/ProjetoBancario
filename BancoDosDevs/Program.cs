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
            try
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
            catch (System.Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
        }

        public static void CurrentAccountOptions()
        {
            var bankCode = String.Empty;
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
                case 2: currentAccountRepository.TakeOutInsurance(bankCode); break;
                case 3: currentAccountRepository.GetExtract(); break;
                case 4: currentAccountRepository.WithdrawOperation(); break;
                case 5: currentAccountRepository.TransferOperation(); break;
                case 6: Menu(); break;
                default: System.Environment.Exit(1); break;
            }
                    
            Console.ReadKey();
        }
    }
}
