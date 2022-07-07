using System;

namespace BancoDosDevs.Business.Contract
{
    public interface IBaseOperationRepository <OEntity>
    {
        void DepositOperation();
        void TransferOperation();
        void WithdrawOperation();
    }
}