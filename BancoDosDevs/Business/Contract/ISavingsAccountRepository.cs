namespace BancoDosDevs.Business.Contract
{
    public class ISavingsAccountRepository : IBaseOperationRepository<SavingsAccount>
    {
        void TransferToOtherBankAccount();
    }
}