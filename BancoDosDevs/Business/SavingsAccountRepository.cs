using System;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;
using System.Globalization;

namespace BancoDosDevs.Business
{
    public class SavingsAccountRepository : ISavingsAccountRepository
    {
        public void DepositOperation()
        {
            try
            {
                Model.SavingsAccount savingsAccount = new Model.SavingsAccount();
                Model.SavingsAccount destinationAccount = new Model.SavingsAccount();

                Console.Clear();

                Console.WriteLine("Conta Poupança - Opção Depósito");
                Console.WriteLine();

                Console.WriteLine("Digite o Número da Agência: ");
                savingsAccount.Agency = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Número da Conta: ");
                savingsAccount.AccountNumber = Console.ReadLine();

                Console.WriteLine("Digite o valor para o depósito: ");
                var depositAmount = decimal.Parse(Console.ReadLine());

                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Dados para o Depósito");
                Console.WriteLine();
                Console.WriteLine($"Número da Agência: { destinationAccount.Agency }");
                Console.WriteLine($"Número da Conta: { destinationAccount.AccountNumber }");
                Console.WriteLine($"Valor para Depósito: { depositAmount.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")) }");

                Console.WriteLine();
                Console.WriteLine("Deseja confirmar o depósito: ");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int depositConfirm = int.Parse(Console.ReadLine());

                switch(depositConfirm)
                {
                    case 1:
                        int initialDepositTime = 0;
                        int finalDepositTime = 10;
                        Console.Clear();
                        Console.WriteLine("Insira o seu envelope preenchido");

                        /*while(finalDepositTime >= initialDepositTime)
                        {
                            initialDepositTime += initialDepositTime + 1;
                            Console.WriteLine("")
                        }*/

                    break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<SavingsAccount> GetExtract()
        {
            throw new NotImplementedException();
        }

        public void TransferOperation()
        {
            throw new NotImplementedException();
        }

        public void TransferToOtherBankAccount(SavingsAccount savingsAccount)
        {
            throw new NotImplementedException();
        }

        public void WithdrawOperation()
        {
            throw new NotImplementedException();
        }
    }
}