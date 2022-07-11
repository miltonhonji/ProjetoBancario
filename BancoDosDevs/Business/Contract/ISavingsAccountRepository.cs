using System;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;

namespace BancoDosDevs.Business.Contract
{
    public interface ISavingsAccountRepository : IBaseOperationRepository<SavingsAccount>
    {
        void TransferToOtherBankAccount(SavingsAccount savingsAccount);
    }
}