using System;

namespace BancoDosDevs.Model
{
    public class CurrentAccount : BankAccount
    {
        public int BankCode { get; set; }

        public CurrentAccount()
        {}

        public CurrentAccount(int agency, string accountNumber, int bankCode)
        {
            this.Agency = agency;
            this.AccountNumber = accountNumber;
            this.BankCode = bankCode;
        }
    }
}