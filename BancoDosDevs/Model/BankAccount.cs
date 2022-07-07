using System;

namespace BancoDosDevs.Model
{
    public class BankAccount
    {
        public ind Id { get; set; }
        public int Agency { get; set; }
        public string AccountNumber { get; set; }
        public EAccountType AccountType { get; set; }
    }

    enum EAccountType
    {
        ContaCorrente = 1,
        ContaPoupanca = 2,
        ContaInvestimento = 3
    }
}