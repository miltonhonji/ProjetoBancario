using System;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;

namespace BancoDosDevs.Business
{
    public class SavingsAccountRepository : ISavingsAccountRepository
    {
        public void DepositOperation()
        {
            throw new NotImplementedException();
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