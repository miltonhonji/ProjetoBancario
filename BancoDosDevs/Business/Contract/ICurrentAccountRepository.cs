using System;
using BancoDosDevs.Model;

namespace BancoDosDevs.Business.Contract
{
    public interface ICurrentAccountRepository : IBaseOperationRepository<CurrentAccount>
    {
        void TakeOutInsurance(string bankCode);
    }
}