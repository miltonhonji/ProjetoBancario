using System;
using System.Globalization;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;

namespace BancoDosDevs.Business
{
    public class CurrentAccountRepository : ICurrentAccountRepository
    {
        public void DepositOperation()
        {
            Model.CurrentAccount currentAccount = new Model.CurrentAccount();
            Model.CurrentAccount destinationAccount = new Model.CurrentAccount();

            Console.Clear();
            
            Console.WriteLine("Conta Corrente - Opção Depósito");
            Console.WriteLine();

            Console.WriteLine("Digite o Número da Agência: ");
            destinationAccount.Agency = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número da Conta:");
            destinationAccount.AccountNumber = Console.ReadLine();

            Console.WriteLine("Digite o valor para depósito: ");
            var depositAmount = decimal.Parse(Console.ReadLine());

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Dados para o Depósito");
            Console.WriteLine();
            Console.WriteLine($"Número da Agência: { destinationAccount.Agency }");
            Console.WriteLine($"Número da Conta: { destinationAccount.AccountNumber }");
            Console.WriteLine($"Valor para Depósito: { depositAmount.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")) }");
            
            Console.WriteLine("Deseja Confirmar o depósito: ");
        
            Console.ReadKey();
            
        }

        public List<CurrentAccount> GetExtract()
        {
            throw new NotImplementedException();
        }

        public void TakeOutInsurance(string bankCode)
        {
            throw new NotImplementedException();
        }

        public void TransferOperation()
        {
            throw new NotImplementedException();
        }

        public void WithdrawOperation()
        {
            throw new NotImplementedException();
        }
    }
}