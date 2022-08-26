using System;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;

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

                Console.WriteLine("Digite o Número da Agência");
                savingsAccount.Agency = int.Parse(Console.ReadLine());
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